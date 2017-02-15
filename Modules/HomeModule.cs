using Nancy;
using System.Collections.Generic;
using RockPaperScissorsApp.Objects;

namespace RockPaperScissorsApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/"] = _ => {
                Game newGame = new Game(Request.Form["user-move"]);
                return View["index.cshtml", newGame];
            };
        }
    }
}
