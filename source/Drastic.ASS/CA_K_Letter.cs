// <copyright file="CA_K_Letter.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

namespace Drastic.ASS
{
    public class CA_K_Letter
    {
        private string let = string.Empty;
        private long duration = 0;
        private long start = 0;
        private long end = 0;
        private string syl = string.Empty;
        private string sentence = string.Empty;

        public CA_K_Letter()
        {
        }

        public CA_K_Letter(string letter, long start, long end, string syl, string text)
        {
            this.let = letter;
            this.duration = end - start;
            this.start = start;
            this.end = end;
            this.syl = syl;
            this.sentence = text;
        }

        public string Letter
        {
            get { return this.let; }
            set { this.let = value; }
        }

        public long Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public long Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public long End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        public string FromSyllable
        {
            get { return this.syl; }
            set { this.syl = value; }
        }

        public string FromText
        {
            get { return this.sentence; }
            set { this.sentence = value; }
        }
    }
}
