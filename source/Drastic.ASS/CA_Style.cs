// <copyright file="CA_Style.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.ASS
{
    public class CA_Style
    {
        // Format: Name, Fontname, Fontsize,
        // PrimaryColour, SecondaryColour, OutlineColour, BackColour,
        // Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle,
        // BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding
        private string name = "Default";
        private string fontname = "Arial";
        private string fontsize = "20";
        private string _1stColor1 = "00FFFFFF";
        private string _2ndColor1 = "00FFFFFF";
        private string _3rdColor1 = "00000000";
        private string _4thColor1 = "00000000";
        private string bold = "0";
        private string italic = "0";
        private string underline = "0";
        private string strikeout = "0";
        private string scaleX = "100";
        private string scaleY = "100";
        private string spacing = "0";
        private string angle = "0";
        private string borderstyle = "1";
        private string outline = "2";
        private string shadow = "2";
        private string alignment = "2";
        private string marginl = "0";
        private string marginr = "0";
        private string marginv = "0";
        private string encoding = "0";

        private CA_Font font = null;
        private CA_Color _11 = null;
        private CA_Color _21 = null;
        private CA_Color _31 = null;
        private CA_Color _41 = null;

        public CA_Style()
        {
        }

        public CA_Style(string rawline)
        {
            rawline = rawline.Substring("Style: ".Length);
            string[] table = rawline.Split(new char[] { ',' });
            this.name = table[0];
            this.fontname = table[1];
            this.fontsize = table[2];
            this._1stColor1 = table[3].Substring("&H".Length);
            this._2ndColor1 = table[4].Substring("&H".Length);
            this._3rdColor1 = table[5].Substring("&H".Length);
            this._4thColor1 = table[6].Substring("&H".Length);
            this.bold = table[7];
            this.italic = table[8];
            this.underline = table[9];
            this.strikeout = table[10];
            this.scaleX = table[11];
            this.scaleY = table[12];
            this.spacing = table[13];
            this.angle = table[14];
            this.borderstyle = table[15];
            this.outline = table[16];
            this.shadow = table[17];
            this.alignment = table[18];
            this.marginl = table[19];
            this.marginr = table[20];
            this.marginv = table[21];
            this.encoding = table[22];

            this.font = new CA_Font(this.fontname, this.fontsize, this.bold, this.italic, this.underline, this.strikeout);
            this._11 = new CA_Color(this._1stColor1);
            this._21 = new CA_Color(this._2ndColor1);
            this._31 = new CA_Color(this._3rdColor1);
            this._41 = new CA_Color(this._4thColor1);
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string GetRawLine()
        {
            string rawline =
                "Style: " +
                this.name + "," +
                this.font.FontName + "," +
                (int)this.font.FontSize + "," +
                "&H" + this._11.ABGR + "," +
                "&H" + this._21.ABGR + "," +
                "&H" + this._31.ABGR + "," +
                "&H" + this._41.ABGR + "," +
                this.font.BoldInt + "," +
                this.font.ItalicInt + "," +
                this.font.UnderlineInt + "," +
                this.font.StrikeoutInt + "," +
                this.scaleX + "," +
                this.scaleY + "," +
                this.spacing + "," +
                this.angle + "," +
                this.borderstyle + "," +
                this.outline + "," +
                this.shadow + "," +
                this.alignment + "," +
                this.marginl + "," +
                this.marginr + "," +
                this.marginv + "," +
                this.encoding;

            return rawline;
        }

        public CA_Font Font
        {
            get { return this.font; }
            set { this.font = value; }
        }

        public CA_Color PrimaryColour
        {
            get { return this._11; }
            set { this._11 = value; }
        }

        public CA_Color KaraokeColour
        {
            get { return this._21; }
            set { this._21 = value; }
        }

        public CA_Color OutlineColour
        {
            get { return this._31; }
            set { this._31 = value; }
        }

        public CA_Color BackColour
        {
            get { return this._41; }
            set { this._41 = value; }
        }

        public float ScaleX
        {
            get { return Convert.ToSingle(this.scaleX); }
            set { this.scaleX = Convert.ToString(value); }
        }

        public float ScaleY
        {
            get { return Convert.ToSingle(this.scaleY); }
            set { this.scaleY = Convert.ToString(value); }
        }

        public int Spacing
        {
            get { return Convert.ToInt32(this.spacing); }
            set { this.spacing = Convert.ToString(value); }
        }

        public float Angle
        {
            get { return Convert.ToSingle(this.angle); }
            set { this.angle = Convert.ToString(value); }
        }

        public int Borderline
        {
            get { return Convert.ToInt32(this.borderstyle); }
            set { this.borderstyle = Convert.ToString(value); }
        }

        public float Outline
        {
            get { return Convert.ToSingle(this.outline); }
            set { this.outline = Convert.ToString(value); }
        }

        public float Shadow
        {
            get { return Convert.ToSingle(this.shadow); }
            set { this.shadow = Convert.ToString(value); }
        }

        public int Alignment
        {
            get { return Convert.ToInt32(this.alignment); }
            set { this.alignment = Convert.ToString(value); }
        }

        public int MarginL
        {
            get { return Convert.ToInt32(this.marginl); }
            set { this.marginl = Convert.ToString(value); }
        }

        public int MarginR
        {
            get { return Convert.ToInt32(this.marginr); }
            set { this.marginr = Convert.ToString(value); }
        }

        public int MarginV
        {
            get { return Convert.ToInt32(this.marginv); }
            set { this.marginv = Convert.ToString(value); }
        }

        public int Encoding
        {
            get { return Convert.ToInt32(this.encoding); }
            set { this.encoding = Convert.ToString(value); }
        }
    }
}
