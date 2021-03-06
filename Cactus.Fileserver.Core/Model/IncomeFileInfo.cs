﻿using System;
using System.Collections.Generic;

namespace Cactus.Fileserver.Core.Model
{
    public class IncomeFileInfo : IFileInfo
    {
        public IncomeFileInfo()
        {
            Extra = new Dictionary<string, string>();
        }

        public IncomeFileInfo(IFileInfo copyFrom) : this()
        {
            if (copyFrom != null)
            {
                Extra = copyFrom.Extra;
                MimeType = copyFrom.MimeType;
                OriginalName = copyFrom.OriginalName;
                Owner = copyFrom.Owner;
                Icon = copyFrom.Icon;
            }
        }

        public string MimeType { get; set; }
        public string OriginalName { get; set; }
        public string Owner { get; set; }
        public Uri Icon { get; set; }
        public IDictionary<string, string> Extra { get; set; }
    }
}
