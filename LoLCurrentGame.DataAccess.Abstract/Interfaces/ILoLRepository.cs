using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLCurrentGame.Business.Entities;

namespace LoLCurrentGame.DataAccess.Abstract.Interfaces
{
    public interface ILoLRepository
    {
        LoLSummoner GetSummonerByName(string value, string region);

    }
}
