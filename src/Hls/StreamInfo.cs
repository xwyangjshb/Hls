﻿using System;
using System.Collections.Generic;

namespace Hls
{
    public class StreamInfo
    {
        public string Audio { get; set; }

        public int? AverageBandwidth { get; set; }

        public int Bandwidth { get; set; }

        public IList<string> Codecs { get; set; } = new List<string>();

        public float? Framerate { get; set; }

        public Tuple<int, int> Resolution { get; set; }

        public string Subtitles { get; set; }

        public string Video { get; set; }

        public string ClosedCaptions { get; set; }
    }
}