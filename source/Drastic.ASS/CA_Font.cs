// <copyright file="CA_Font.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Drawing;

namespace Drastic.ASS
{
    public class CA_Font
    {
        private Font font = new Font("Arial", 12f, FontStyle.Regular);

        public CA_Font(string fontname = "Arial", string fontsize = "12",
            string bold = "0", string italic = "0", string underline = "0", string strikeout = "0")
        {
            float fs = Convert.ToSingle(fontsize);
            int b = Convert.ToInt32(bold);
            int i = Convert.ToInt32(italic);
            int u = Convert.ToInt32(underline);
            int s = Convert.ToInt32(strikeout);

            this.Configure(fontname, fs, b, i, u, s);
        }

        public CA_Font(string fontname = "Arial", float fontsize = 12f,
            int bold = 0, int italic = 0, int underline = 0, int strikeout = 0)
        {
            this.Configure(fontname, fontsize, bold, italic, underline, strikeout);
        }

        public CA_Font(Font font)
        {
            this.Configure(
                font.Name,
                font.Size,
                this.ConvertBoolean(font.Bold),
                this.ConvertBoolean(font.Italic),
                this.ConvertBoolean(font.Underline),
                this.ConvertBoolean(font.Strikeout));
        }

        public Font Font
        {
            get { return this.font; }
            set { this.font = value; }
        }

        private void Configure(string fontname = "Arial", float fontsize = 12f,
            int bold = 0, int italic = 0, int underline = 0, int strikeout = 0)
        {
            bool b = this.ConvertInteger(bold);
            bool i = this.ConvertInteger(italic);
            bool u = this.ConvertInteger(underline);
            bool s = this.ConvertInteger(strikeout);

            FontStyle defFS = FontStyle.Regular;
            defFS = b == true ? defFS | FontStyle.Bold : defFS;
            defFS = i == true ? defFS | FontStyle.Italic : defFS;
            defFS = u == true ? defFS | FontStyle.Underline : defFS;
            defFS = s == true ? defFS | FontStyle.Strikeout : defFS;

            this.font = new Font(fontname, fontsize, defFS);
        }

        public string FontName
        {
            get { return this.font.FontFamily.Name; }
        }

        public float FontSize
        {
            get { return this.font.Size; }
        }

        public bool Bold
        {
            get { return this.font.Bold; }
        }

        public bool Italic
        {
            get { return this.font.Italic; }
        }

        public bool Underline
        {
            get { return this.font.Underline; }
        }

        public bool Strikeout
        {
            get { return this.font.Strikeout; }
        }

        public int BoldInt
        {
            get { return this.ConvertBoolean(this.font.Bold); }
        }

        public int ItalicInt
        {
            get { return this.ConvertBoolean(this.font.Italic); }
        }

        public int UnderlineInt
        {
            get { return this.ConvertBoolean(this.font.Underline); }
        }

        public int StrikeoutInt
        {
            get { return this.ConvertBoolean(this.font.Strikeout); }
        }

        public int ConvertBoolean(bool b)
        {
            return b == true ? -1 : 0;
        }

        public bool ConvertInteger(int i)
        {
            return i == -1 ? true : false;
        }
    }
}
