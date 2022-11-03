// <copyright file="ATag.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drastic.ASS.Tags
{
    public class ATag : ITag
    {
        protected string effectName = string.Empty;
        protected TagFormat effectFormat = new TagFormat();
        protected string effectInLineName = string.Empty;
        protected List<TagValue> effectInnerTagValues = new List<TagValue>();
        protected bool effectHasParenthesis = false;

        public ATag()
        {
        }

        /// <inheritdoc/>
        public virtual string GetEffectName()
        {
            return this.effectName;
        }

        /// <inheritdoc/>
        public virtual TagFormat GetFormat()
        {
            return this.effectFormat;
        }

        /// <inheritdoc/>
        public virtual string GetInLineName()
        {
            return this.effectInLineName;
        }

        /// <inheritdoc/>
        public virtual List<TagValue> GetInnerTagValues()
        {
            return this.effectInnerTagValues;
        }

        /// <inheritdoc/>
        public virtual bool HasParenthesis()
        {
            return this.effectHasParenthesis;
        }
    }
}
