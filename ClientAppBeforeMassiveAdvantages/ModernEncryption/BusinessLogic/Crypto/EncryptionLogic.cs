﻿using System;
using System.Diagnostics;
using ModernEncryption.Interfaces;
using ModernEncryption.Model;

namespace ModernEncryption.BusinessLogic.Crypto
{
    internal class EncryptionLogic : IEncrypt
    {
        private readonly char[] _messageTextSymbols;
        private readonly DecryptedMessage _message;

        public EncryptionLogic(DecryptedMessage message)
        {
            _message = message;
            _messageTextSymbols = message.Text.ToCharArray();
        }

        public EncryptedMessage Encrypt()
        {
            var concatenatedEncryptedSymbols = string.Empty;

            foreach (var symbol in _messageTextSymbols)
            {
                var chipher = CreateChipher(symbol);
                var permutedChipher = RunPermutationFor(chipher);

                concatenatedEncryptedSymbols += CreateCharacterPair(permutedChipher);
            }

            return new EncryptedMessage(concatenatedEncryptedSymbols, _message);
        }

        private int CreateChipher(char symbol)
        {
            var rnd = new Random();
            var interval = MathematicalMappingLogic.IntervalTable[symbol];
            return rnd.Next(interval.Start, interval.End + 1);
        }

        private int RunPermutationFor(int chipher)
        {
            if (MathematicalMappingLogic.KeyTable.ContainsKey(chipher))
                return MathematicalMappingLogic.KeyTable[chipher];
            return chipher;
        }

        private string CreateCharacterPair(int permutedChipher)
        {
            var keyA = (permutedChipher - 1) / 40 + 1;
            var keyB = (permutedChipher - 1) % 40 + 1;
            return "" + MathematicalMappingLogic.TransformationTable[keyA] + MathematicalMappingLogic.TransformationTable[keyB];
        }
    }
}