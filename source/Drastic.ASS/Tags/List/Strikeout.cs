// <copyright file="Strikeout.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags.List
{
    public class Strikeout : ATag
    {
        public Strikeout()
        {
            this.effectName = "Strikeout";
            this.effectInLineName = "\\s";
            this.effectHasParenthesis = false;

            this.effectFormat.AddNotFormatted("\\s");
            this.effectFormat.AddFormat(TagFormatEnum.Integer);
        }

        public bool IsStrikeout()
        {
            return this.effectInnerTagValues[0].Value != "0";
        }
    }
}
