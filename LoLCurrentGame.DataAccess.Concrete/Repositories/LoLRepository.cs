using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using LoLCurrentGame.Business.Entities;
using LoLCurrentGame.DataAccess.Abstract.Interfaces;
using RiotSharp;

namespace LoLCurrentGame.DataAccess.Concrete.Repositories
{
    
    public class LoLRepository : ILoLRepository
    {
        public static RiotApi Lolapi = RiotApi.GetInstance("2bc17473-cfd7-4584-b56e-fc93c735b340", 10, 500);


        public LoLSummoner GetSummonerByName(string value, string region)
        {
            var lolsummoner = new LoLSummoner();
            var lol = RiotSharp.Region.euw;
            switch (region)
            {
                case "euw":
                    lol = RiotSharp.Region.euw;
                    break;
                case "na":
                    lol = RiotSharp.Region.na;
                    break;
                case "eune":
                    lol = RiotSharp.Region.eune;
                    break;
                case "br":
                    lol = RiotSharp.Region.br;
                    break;
                case "lan":
                    lol = RiotSharp.Region.lan;
                    break;
                case "las":
                    lol = RiotSharp.Region.las;
                    break;
                case "oce":
                    lol = RiotSharp.Region.oce;
                    break;
                default:
                    lol = RiotSharp.Region.euw;
                    break;
            }

            var summoner = Lolapi.GetSummoner(lol, value);
            lolsummoner.Summoner = summoner;
            return lolsummoner;
        }
    }
}