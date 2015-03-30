using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoLCurrentGame.Business.Entities
{
    public class Enums
    {
        public RiotSharp.Region Region { get; set; }
        public RiotSharp.MapType MapType { get; set; }
        public RiotSharp.GameType GameType { get; set; }
        public RiotSharp.GameMode GameMode { get; set; }
        public RiotSharp.Queue Queue { get; set; }

    }
}