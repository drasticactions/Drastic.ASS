// <copyright file="CA_Infos.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.ASS
{
    public class CA_Infos
    {
        // [Script Info]
        private string title = string.Empty;
        private string original_script = string.Empty;
        private string original_translation = string.Empty;
        private string original_editing = string.Empty;
        private string original_timing = string.Empty;
        private string original_script_checking = string.Empty;
        private string scripttype = "v4.00+";
        private int playresX = 1280;
        private int playresY = 720;
        private int playdepth = 0;
        private string wav = string.Empty;
        private string lastwav = string.Empty;
        private float timer = 100f;
        private int wrapstyle = 0;
        private string video_aspect_ratio = string.Empty;
        private string video_zoom = string.Empty;
        private string ycbcr_matrix = string.Empty;

        // [Aegisub Project Garbage]
        private string last_style_storage = string.Empty;
        private string audio_file = string.Empty;
        private string video_file = string.Empty;
        private string video_ar_mode = string.Empty;
        private string video_ar_value = string.Empty;
        private string video_zoom_percent = string.Empty;
        private string active_line = string.Empty;
        private string video_position = string.Empty;

        public CA_Infos()
        {
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public void TryAdd(string rawline)
        {
            if (rawline.StartsWith("Title"))
            {
                this.title = rawline.Substring("Title: ".Length);
            }
            if (rawline.StartsWith("Original Script"))
            {
                this.original_script = rawline.Substring("Original Script: ".Length);
            }
            if (rawline.StartsWith("Original Translation"))
            {
                this.original_translation = rawline.Substring("Original Translation: ".Length);
            }
            if (rawline.StartsWith("Original Editing"))
            {
                this.original_editing = rawline.Substring("Original Editing: ".Length);
            }
            if (rawline.StartsWith("Original Timing"))
            {
                this.original_timing = rawline.Substring("Original Timing: ".Length);
            }
            if (rawline.StartsWith("Original Script Checking"))
            {
                this.original_script_checking = rawline.Substring("Original Script Checking: ".Length);
            }
            if (rawline.StartsWith("ScriptType"))
            {
                this.scripttype = rawline.Substring("ScriptType: ".Length);
            }
            if (rawline.StartsWith("PlayResX"))
            {
                this.playresX = Convert.ToInt32(rawline.Substring("PlayResX: ".Length));
            }
            if (rawline.StartsWith("PlayResY"))
            {
                this.playresY = Convert.ToInt32(rawline.Substring("PlayResY: ".Length));
            }
            if (rawline.StartsWith("PlayDepth"))
            {
                this.playdepth = Convert.ToInt32(rawline.Substring("PlayDepth: ".Length));
            }
            if (rawline.StartsWith("Wav"))
            {
                this.wav = rawline.Substring("Wav: ".Length);
            }
            if (rawline.StartsWith("LastWav"))
            {
                this.lastwav = rawline.Substring("LastWav: ".Length);
            }
            if (rawline.StartsWith("Timer"))
            {
                this.timer = Convert.ToSingle(rawline.Substring("Timer: ".Length));
            }
            if (rawline.StartsWith("WrapStyle"))
            {
                this.wrapstyle = Convert.ToInt32(rawline.Substring("WrapStyle: ".Length));
            }
            if (rawline.StartsWith("Video Aspect Ratio"))
            {
                this.video_aspect_ratio = rawline.Substring("Video Aspect Ratio: ".Length);
            }
            if (rawline.StartsWith("Video Zoom"))
            {
                this.video_zoom = rawline.Substring("Video Zoom: ".Length);
            }
            if (rawline.StartsWith("YCbCr Matrix"))
            {
                this.ycbcr_matrix = rawline.Substring("YCbCr Matrix: ".Length);
            }
            if (rawline.StartsWith("Last Style Storage"))
            {
                this.last_style_storage = rawline.Substring("Last Style Storage: ".Length);
            }
            if (rawline.StartsWith("Audio File"))
            {
                this.audio_file = rawline.Substring("Audio File: ".Length);
            }
            if (rawline.StartsWith("Video File"))
            {
                this.video_file = rawline.Substring("Video File: ".Length);
            }
            if (rawline.StartsWith("Video AR Mode"))
            {
                this.video_ar_mode = rawline.Substring("Video AR Mode: ".Length);
            }
            if (rawline.StartsWith("Video AR Value"))
            {
                this.video_ar_value = rawline.Substring("Video AR Value: ".Length);
            }
            if (rawline.StartsWith("Video Zoom Percent"))
            {
                this.video_zoom_percent = rawline.Substring("Video Zoom Percent: ".Length);
            }
            if (rawline.StartsWith("Active Line"))
            {
                this.active_line = rawline.Substring("Active Line: ".Length);
            }
            if (rawline.StartsWith("Video Position"))
            {
                this.video_position = rawline.Substring("Video Position: ".Length);
            }
        }

        public string OriginalScript
        {
            get { return this.original_script; }
            set { this.original_script = value; }
        }

        public string OriginalTranslation
        {
            get { return this.original_translation; }
            set { this.original_translation = value; }
        }

        public string OriginalEditing
        {
            get { return this.original_editing; }
            set { this.original_editing = value; }
        }

        public string OriginalTiming
        {
            get { return this.original_timing; }
            set { this.original_timing = value; }
        }

        public string OriginalScriptChecking
        {
            get { return this.original_script_checking; }
            set { this.original_script_checking = value; }
        }

        public string ScriptType
        {
            get { return this.scripttype; }
            set { this.scripttype = value; }
        }

        public int PlayResX
        {
            get { return this.playresX; }
            set { this.playresX = value; }
        }

        public int PlayResY
        {
            get { return this.playresY; }
            set { this.playresY = value; }
        }

        public int PlayDepth
        {
            get { return this.playdepth; }
            set { this.playdepth = value; }
        }

        public string Wav
        {
            get { return this.wav; }
            set { this.wav = value; }
        }

        public string LastWav
        {
            get { return this.lastwav; }
            set { this.lastwav = value; }
        }

        public float Timer
        {
            get { return this.timer; }
            set { this.timer = value; }
        }

        public int WrapStyle
        {
            get { return this.wrapstyle; }
            set { this.wrapstyle = value; }
        }

        public string VideoAspectRatio
        {
            get { return this.video_aspect_ratio; }
            set { this.video_aspect_ratio = value; }
        }

        public string VideoZoom
        {
            get { return this.video_zoom; }
            set { this.video_zoom = value; }
        }

        public string YCbCrMatrix
        {
            get { return this.ycbcr_matrix; }
            set { this.ycbcr_matrix = value; }
        }

        public string LastStyleStorage
        {
            get { return this.last_style_storage; }
            set { this.last_style_storage = value; }
        }

        public string AudioFile
        {
            get { return this.audio_file; }
            set { this.audio_file = value; }
        }

        public string VideoFile
        {
            get { return this.video_file; }
            set { this.video_file = value; }
        }

        public string VideoARMode
        {
            get { return this.video_ar_mode; }
            set { this.video_ar_mode = value; }
        }

        public string VideoARValue
        {
            get { return this.video_ar_value; }
            set { this.video_ar_value = value; }
        }

        public string VideoZoomPercent
        {
            get { return this.video_zoom_percent; }
            set { this.video_zoom_percent = value; }
        }

        public string ActiveLine
        {
            get { return this.active_line; }
            set { this.active_line = value; }
        }

        public string VideoPosition
        {
            get { return this.video_position; }
            set { this.video_position = value; }
        }
    }
}
