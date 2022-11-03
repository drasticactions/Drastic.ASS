// <copyright file="CA_K_Syllable.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Collections.Generic;

namespace Drastic.ASS
{
    public class CA_K_Syllable
    {
        private string syl = string.Empty;
        private long duration = 0;
        private long start = 0;
        private long end = 0;
        private string sentence = string.Empty;
        private List<CA_K_Letter> letters = new List<CA_K_Letter>();

        public CA_K_Syllable()
        {
        }

        public CA_K_Syllable(string syl, long start, long end, string text)
        {
            this.syl = syl;
            this.duration = end - start;
            this.start = start;
            this.end = end;
            this.sentence = text;

            this.letters.Clear();

            if (syl.Length > 0)
            {
                long startlet = start;
                int index = 1;
                long max_letter_duration = this.duration / syl.Length;
                long min_letter_duration = this.duration - (max_letter_duration * (syl.Length - 1));
                foreach (char c in syl)
                {
                    if (index < syl.Length)
                    {
                        CA_K_Letter letter = new CA_K_Letter(
                            c.ToString(),
                            startlet,
                            startlet + max_letter_duration,
                            syl,
                            text);

                        this.letters.Add(letter);

                        startlet += max_letter_duration;
                    }
                    else
                    {
                        CA_K_Letter letter = new CA_K_Letter(
                            c.ToString(),
                            startlet,
                            startlet + min_letter_duration,
                            syl,
                            text);

                        this.letters.Add(letter);
                    }

                    index++;
                }
            }
        }

        public string Syllable
        {
            get { return this.syl; }
            set { this.syl = value; }
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

        public string FromText
        {
            get { return this.sentence; }
            set { this.sentence = value; }
        }

        public List<CA_K_Letter> Letters
        {
            get { return this.letters; }
        }
    }
}
