// <copyright file="CA_Event.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Text.RegularExpressions;

namespace Drastic.ASS
{
    public class CA_Event
    {
        private string rawline = string.Empty;
        private int layer = 0;
        private long start = 0;
        private long end = 0;
        private string style = string.Empty;
        private string name_or_actor = string.Empty;
        private int marginL = 0;
        private int marginR = 0;
        private int marginV = 0;
        private string effect = string.Empty;
        private string text = string.Empty;
        private bool comment = false;

        private CA_Karaoke kara = null;

        public CA_Event()
        {
        }

        public CA_Event(string rawline)
        {
            this.comment = rawline.StartsWith("Comment");
            this.rawline = rawline;

            string str = rawline.StartsWith("Comment") == true ?
                rawline.Substring("Comment: ".Length) : rawline.Substring("Dialogue: ".Length);
            string[] table = str.Split(new char[] { ',' }, 10);

            this.layer = Convert.ToInt32(table[0]);
            this.start = this.GetTime(table[1]);
            this.end = this.GetTime(table[2]);
            this.style = table[3];
            this.name_or_actor = table[4];
            this.marginL = Convert.ToInt32(table[5]);
            this.marginR = Convert.ToInt32(table[6]);
            this.marginV = Convert.ToInt32(table[7]);
            this.effect = table[8];
            this.text = table[9];

            if (CA_Karaoke.HasKaraoke(this.text))
            {
                this.kara = CA_Karaoke.Create(this.text, this.start, this.end);
            }
        }

        public int Layer
        {
            get { return this.layer; }
            set { this.layer = value; }
        }

        public string GetRawLine()
        {
            string comment = this.comment == true ? "Comment: " : "Dialogue: ";
            string rawline =
                comment +
                this.layer + "," +
                this.SetTime(this.start) + "," +
                this.SetTime(this.end) + "," +
                this.style + "," +
                this.name_or_actor + "," +
                this.marginL + "," +
                this.marginR + "," +
                this.marginV + "," +
                this.effect + "," +
                this.text;

            return rawline;
        }

        public long GetTime(string rawTime)
        {
            string pat = @"(\d+):(\d+):(\d+).(\d+)";
            Regex r = new Regex(pat, RegexOptions.IgnoreCase);

            int hour = 0, min = 0, sec = 0, ms = 0;

            Match m = r.Match(rawTime);
            if (m.Success)
            {
                hour = Convert.ToInt32(m.Groups[1].Value);
                min = Convert.ToInt32(m.Groups[2].Value);
                sec = Convert.ToInt32(m.Groups[3].Value);
                ms = Convert.ToInt32(m.Groups[4].Value) * 10;
            }

            long time = (hour * 3600000) + (min * 60000) + (sec * 1000) + ms;

            return time;
        }

        public string SetTime(long time)
        {
            int hour = (int)(time / 3600000);
            int min = (int)((time - (3600000 * hour)) / 60000);
            int sec = (int)((time - (3600000 * hour) - (60000 * min)) / 1000);
            int mSec = (int)(time - (3600000 * hour) - (60000 * min) - (1000 * sec));

            int centi = mSec / 10;

            string h = Convert.ToString(hour);
            string m = min > 9 ? Convert.ToString(min) : "0" + Convert.ToString(min);
            string s = sec > 9 ? Convert.ToString(sec) : "0" + Convert.ToString(sec);
            string n = centi > 9 ? Convert.ToString(centi) : "0" + Convert.ToString(centi);

            return h + ":" + m + ":" + s + "." + n;
        }

        /// <summary>
        /// Change text (and change karaoke).
        /// </summary>
        /// <param name="text">Your text.</param>
        public void ChangeText(string text)
        {
            this.text = text;

            if (CA_Karaoke.HasKaraoke(text))
            {
                this.kara = CA_Karaoke.Create(text, this.start, this.end);
            }
        }

        public long Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public string StartString
        {
            get { return this.SetTime(this.start); }
        }

        public long End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public string EndString
        {
            get { return this.SetTime(this.end); }
        }

        public string Style
        {
            get { return this.style; }
            set { this.style = value; }
        }

        public string NameOrActor
        {
            get { return this.name_or_actor; }
            set { this.name_or_actor = value; }
        }

        public int MarginL
        {
            get { return this.marginL; }
            set { this.marginL = value; }
        }

        public int MarginR
        {
            get { return this.marginR; }
            set { this.marginR = value; }
        }

        public int MarginV
        {
            get { return this.marginV; }
            set { this.marginV = value; }
        }

        public string Effect
        {
            get { return this.effect; }
            set { this.effect = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public bool Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public CA_Karaoke Karaoke
        {
            get { return this.kara; }
        }
    }
}
