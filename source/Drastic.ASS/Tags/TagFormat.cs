// <copyright file="TagFormat.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags
{
    public class TagFormat
    {
        private static string forInteger = "¤";
        private static string forFloat = "%";
        private static string forDouble = "µ";
        private static string forString = "@";
        private static int digitsAfterDot = 3;
        private static string forVariable = "$";
        private static string forCalculation = "!";

        private string tag = string.Empty;

        public TagFormat()
        {
        }

        public string Tag { get => this.tag; set => this.tag = value; }

        public void AddNotFormatted(string s)
        {
            this.tag += s;
        }

        public void AddFormat(TagFormatEnum kind)
        {
            switch (kind)
            {
                case TagFormatEnum.Integer: this.tag += forInteger; break;
                case TagFormatEnum.Float: this.tag += forFloat; break;
                case TagFormatEnum.Double: this.tag += forDouble; break;
                case TagFormatEnum.String: this.tag += forString; break;
                case TagFormatEnum.Variable: this.tag += forVariable; break;
                case TagFormatEnum.Calculation: this.tag += forCalculation; break;
            }
        }

        public static string GetFormattedTag(List<TagValue> values, TagFormat format)
        {
            int countTags = 0;
            string formatted = string.Empty;

            foreach (char c in format.Tag.ToCharArray())
            {
                string character = Convert.ToString(c);

                if (character == forInteger | character == forFloat | character == forDouble |
                    character == forString | character == forVariable | character == forCalculation)
                {
                    formatted += Convert.ToString(values[countTags]);
                    countTags++;
                }
                else
                {
                    formatted += character;
                }
            }

            return formatted;
        }
    }
}
