// <copyright file="Underline.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags.List
{
    public class Underline : ATag
    {
        public Underline()
        {
            this.effectName = "Underline";
            this.effectInLineName = "\\u";
            this.effectHasParenthesis = false;

            this.effectFormat.AddNotFormatted("\\u");
            this.effectFormat.AddFormat(TagFormatEnum.Integer);
        }

        public bool IsUnderline()
        {
            return this.effectInnerTagValues[0].Value != "0";
        }
    }
}
