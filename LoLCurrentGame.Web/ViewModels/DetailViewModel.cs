using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoLCurrentGame.Business.Entities;

namespace LoLCurrentGame.Web.ViewModels
{
    public class DetailViewModel
    {
        public LoLSummoner Summoner { get; set; }
        public CurrentGameEndpoint CurrentGame { get; set; }
        public Champion Champion { get; set; }
        public Enums Enums { get; set; }
    }
}