// <copyright file="CA_Karaoke.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Drastic.ASS
{
    public class CA_Karaoke
    {
        private string text = string.Empty;
        private long duration = 0;
        private long start = 0;
        private long end = 0;
        private List<CA_K_Syllable> syllables = new List<CA_K_Syllable>();

        public CA_Karaoke()
        {
        }

        public List<CA_K_Syllable> Syllables
        {
            get { return this.syllables; }
        }

        public static bool HasKaraoke(string text)
        {
            return text.Contains(@"\k") | text.Contains(@"\K");
        }

        public static CA_Karaoke Create(string text, long start, long end)
        {
            CA_Karaoke kara = new CA_Karaoke();

            if (HasKaraoke(text) == true)
            {
                kara.syllables.Clear();

                kara.text = text;
                kara.start = start;
                kara.end = end;
                kara.duration = end - start;

                string ns;
                ns = text.Replace("\\K", "\\k");
                ns = ns.Replace("\\ko", "\\k");
                ns = ns.Replace("\\kf", "\\k");

                long startsyl = 0;

                Regex r = new Regex(@"\{[\\k]{1}(\d+)\}(\w+)");
                Match m = r.Match(ns);

                while (m.Success)
                {
                    long dur_centi = Convert.ToInt32(m.Groups[1].Value);
                    long dur_milli = dur_centi * 10;

                    CA_K_Syllable syl = new CA_K_Syllable(
                        m.Groups[2].Value,
                        startsyl + start,
                        startsyl + start + dur_milli,
                        text);

                    kara.syllables.Add(syl);

                    startsyl += dur_milli;

                    m.NextMatch();
                }
            }

            return kara;
        }
    }
}
