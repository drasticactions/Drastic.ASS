// <copyright file="CA_TaggedText.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags
{
    public class CA_TaggedText
    {
        private List<ATag> tags = new List<ATag>();
        private string text = string.Empty;

        public CA_TaggedText()
        {
        }

        public List<ATag> Tags { get => this.tags; set => this.tags = value; }

        public string Text { get => this.text; set => this.text = value; }
    }
}
