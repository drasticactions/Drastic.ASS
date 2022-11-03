// <copyright file="TagValue.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags
{
    public class TagValue
    {
        private string name = null;
        private Type type = null;
        private string value = null;

        public TagValue()
        {
        }

        public string Name { get => this.name; set => this.name = value; }

        public Type Type { get => this.type; set => this.type = value; }

        public string Value { get => this.value; set => this.value = value; }
    }
}
