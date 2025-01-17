﻿// <copyright file="CA_Color.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Drawing;

namespace Drastic.ASS
{
    public class CA_Color
    {
        private Color color = Color.Red;

        public CA_Color()
        {
        }

        public CA_Color(string abgr)
        {
            abgr = abgr.Replace("&", string.Empty);
            abgr = abgr.Replace("H", string.Empty);

            if (abgr.Length == 8)
            {
                this.color = this.ABGRToColor(abgr);
            }
            else if (abgr.Length == 6)
            {
                this.color = this.BGRToColor(abgr);
            }
        }

        public Color Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string BGR
        {
            get { return this.ColorToBGR(this.color); }
            set { this.color = this.BGRToColor(value); }
        }

        public string ABGR
        {
            get { return this.ColorToABGR(this.color); }
            set { this.color = this.ABGRToColor(value); }
        }

        public Color BGRToColor(string bgr)
        {
            string b = bgr.Substring(0, 2);
            string g = bgr.Substring(2, 2);
            string r = bgr.Substring(4, 2);

            int red = int.Parse(r, System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(g, System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(b, System.Globalization.NumberStyles.HexNumber);

            Color c = Color.FromArgb(red, green, blue);

            return c;
        }

        public Color ABGRToColor(string abgr)
        {
            string a = abgr.Substring(0, 2);
            string b = abgr.Substring(2, 2);
            string g = abgr.Substring(4, 2);
            string r = abgr.Substring(6, 2);

            int alpha = int.Parse(a, System.Globalization.NumberStyles.HexNumber);
            int red = int.Parse(r, System.Globalization.NumberStyles.HexNumber);
            int green = int.Parse(g, System.Globalization.NumberStyles.HexNumber);
            int blue = int.Parse(b, System.Globalization.NumberStyles.HexNumber);

            Color c = Color.FromArgb(alpha, red, green, blue);

            return c;
        }

        public string ColorToBGR(Color c)
        {
            string hexa_r = c.R.ToString("X").Length > 1 ? c.R.ToString("X") : "0" + c.R.ToString("X");
            string hexa_g = c.G.ToString("X").Length > 1 ? c.G.ToString("X") : "0" + c.G.ToString("X");
            string hexa_b = c.B.ToString("X").Length > 1 ? c.B.ToString("X") : "0" + c.B.ToString("X");

            return hexa_b + hexa_g + hexa_r;
        }

        public string ColorToABGR(Color c)
        {
            string hexa_a = c.A.ToString("X").Length > 1 ? c.A.ToString("X") : "0" + c.A.ToString("X");
            string hexa_r = c.R.ToString("X").Length > 1 ? c.R.ToString("X") : "0" + c.R.ToString("X");
            string hexa_g = c.G.ToString("X").Length > 1 ? c.G.ToString("X") : "0" + c.G.ToString("X");
            string hexa_b = c.B.ToString("X").Length > 1 ? c.B.ToString("X") : "0" + c.B.ToString("X");

            return hexa_a + hexa_b + hexa_g + hexa_r;
        }
    }
}
