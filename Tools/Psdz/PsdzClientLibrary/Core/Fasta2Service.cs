﻿using PsdzClient.Core;
using System;

namespace PsdzClient.Core
{
    // [UH] dummy class
    public class Fasta2Service : IFasta2Service
    {
        public Fasta2Service()
        {

        }

        public bool AddServiceCode(string name, string value, LayoutGroup layoutGroup, bool allowMultipleEntries = false, bool bufferIfSessionNotStarted = false, DateTime? timeStamp = null, bool? isSystemTime = null)
        {
            return true;
        }
    }
}