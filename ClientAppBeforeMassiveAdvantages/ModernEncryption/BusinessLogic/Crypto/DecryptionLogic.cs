﻿using System.Diagnostics;
using ModernEncryption.Interfaces;
using ModernEncryption.Model;
using Newtonsoft.Json.Serialization;

namespace ModernEncryption.BusinessLogic.Crypto
{
    internal class DecryptionLogic : IDecrypt
    {
        private readonly char[] _messageTextSymbols;
        private readonly EncryptedMessage _message;

        public DecryptionLogic(EncryptedMessage message)
        {
            _messageTextSymbols = message.Text.ToCharArray();
            _message = message;
        }

        public DecryptedMessage Decrypt()
        {
            var concatenatedDecryptedSymbols = string.Empty;

            for (var i = 0; i < _messageTextSymbols.Length; i++)
            {
                var permutedChipher = RevertCharacterPair(_messageTextSymbols[i], _messageTextSymbols[++i]);
                var chiper = RevertPermutationFor(permutedChipher);
                concatenatedDecryptedSymbols += RevertChipher(chiper);
                if (chiper == '-')
                {
                    Debug.WriteLine("Ungültiger Eingabewert");
                }
            }

            return new DecryptedMessage(concatenatedDecryptedSymbols, _message);
        }

        private int RevertCharacterPair(char concatenatedSymbolPartA, char concatenatedSymbolPartB)
        {
            var keyA = MathematicalMappingLogic.BackTransformationTable[concatenatedSymbolPartA];
            var keyB = MathematicalMappingLogic.BackTransformationTable[concatenatedSymbolPartB];

            return (keyA - 1) * 40 + keyB;
        }

        private int RevertPermutationFor(int permutedChipher)
        {
            if (MathematicalMappingLogic.KeyTable.ContainsKey(permutedChipher))
                return MathematicalMappingLogic.KeyTable[permutedChipher];
            return permutedChipher;
        }

        private char RevertChipher(int chiper)
        {
            foreach (var symbol in MathematicalMappingLogic.TransformationTable.Values)
            {
                var interval = MathematicalMappingLogic.IntervalTable[symbol];
                if (chiper >= interval.Start && chiper <= interval.End)
                {
                    return symbol;
                }
            }

            return '-';
        }
    }
}