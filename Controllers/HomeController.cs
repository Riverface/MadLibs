using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;
namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/letter")]
        public ActionResult Letter(string recipient, string sender)
        {
            MadLib libSet = new MadLib();
            return View(libSet);
        }
        
        [Route("/form")]
        public ActionResult Form() { return View(); }
    }
}