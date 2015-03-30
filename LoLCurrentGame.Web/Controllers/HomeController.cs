using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoLCurrentGame.DataAccess.Abstract.Interfaces;
using LoLCurrentGame.DataAccess.Concrete.Repositories;
using LoLCurrentGame.Web.ViewModels;

namespace LoLCurrentGame.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILoLRepository _repository = new LoLRepository();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new ViewModel();
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ViewModel value)
        {
            
            //var sum = _repository.GetSummonerByName(value.Summonername);
            
            //return CurrentGame();
            return Index();

        }


        // Get: /Home/CurrentGame
        [HttpGet]
        public ActionResult CurrentGame(DetailViewModel viewModel)
        {

            return View();
        }

    }
}
