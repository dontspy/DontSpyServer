﻿using System.Collections.Generic;
using ModernEncryption.Interfaces;
using ModernEncryption.Presentation.View;
using Newtonsoft.Json;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;

namespace ModernEncryption.Model
{
    [Table("Channel")]
    public class Channel : IEntity
    {
        private ChannelPage _channelView;

        [PrimaryKey, JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [ManyToMany(typeof(ChannelUser), CascadeOperations = CascadeOperation.All)]
        public List<User> Members { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Message> Messages { get; set; } = new List<Message>();

        public string Name { get; set; }

        [Ignore]
        public ChannelPage View => _channelView ?? (_channelView = new ChannelPage(this));

        public Channel()
        {
        }

        public Channel(string id, List<User> members, string name = null)
        {
            Id = id;
            Members = members;

            if (name == null) Name = members[0].Firstname + " and " + (members.Count - 1) + " more members";
            else Name = name;
        }
    }
}
