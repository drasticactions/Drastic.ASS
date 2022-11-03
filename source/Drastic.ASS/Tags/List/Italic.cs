// <copyright file="Italic.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags.List
{
    public class Italic : ATag
    {
        public Italic()
        {
            this.effectName = "Italic";
            this.effectInLineName = "\\i";
            this.effectHasParenthesis = false;

            this.effectFormat.AddNotFormatted("\\i");
            this.effectFormat.AddFormat(TagFormatEnum.Integer);
        }

        public bool IsItalic()
        {
            return this.effectInnerTagValues[0].Value != "0";
        }
    }
}
