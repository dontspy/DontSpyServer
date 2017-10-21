﻿using System.Collections.Generic;
using ModernEncryption.Interfaces;
using ModernEncryption.Utils;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ModernEncryption.Model
{
    [Table("User")]
    public class User : IEntity
    {
        [PrimaryKey, JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [ManyToMany(typeof(ChannelUser), CascadeOperations = CascadeOperation.All), JsonIgnore]
        public List<Channel> Channels { get; set; }

        [JsonProperty(PropertyName = "firstname")]
        public string Firstname { get; set; }

        [JsonProperty(PropertyName = "surname")]
        public string Surname { get; set; }

        [Unique, MaxLength(32), JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        public User()
        {
        }

        public User(string firstname, string surname, string email)
        {
            Id = IdentifierCreator.UniqueDigits();
            Firstname = firstname;
            Surname = surname;
            Email = email;
        }
    }
}
