// <copyright file="Bold.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags.List
{
    public class Bold : ATag
    {
        public Bold()
        {
            this.effectName = "Bold";
            this.effectInLineName = "\\b";
            this.effectHasParenthesis = false;

            this.effectFormat.AddNotFormatted("\\b");
            this.effectFormat.AddFormat(TagFormatEnum.Integer);
        }

        public bool IsBold()
        {
            return this.effectInnerTagValues[0].Value != "0";
        }
    }
}
