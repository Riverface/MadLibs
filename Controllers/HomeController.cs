using FriendLetter.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {

        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/MadLibs/Result")]
        public ActionResult Result(
            string adjective1, string adjective2, string noun1, string noun2, string pluralnoun1, string gamenoun1, string pluralnoun2, string ingverb1,
            string ingverb2, string pluralnoun3, string ingverb3, string noun3, string plant1, string bodypart1, string place1, string ingverb4, string adjective3, string number1, string pluralnoun4)
        {
            Console.WriteLine(ingverb1);
            Console.WriteLine(ingverb2);
            Console.WriteLine(ingverb3);
            Console.WriteLine(ingverb4);

            MadLib libSet = new MadLib();
            Console.WriteLine(libSet.IngVerbs);
            libSet.Adjectives = new string[3] { adjective1, adjective2, adjective3 };
            libSet.Nouns = new string[3] { noun1, noun2, noun3 };
            libSet.PluralNouns = new string[4] { pluralnoun1, pluralnoun2, pluralnoun3, pluralnoun4 };
            libSet.GameNouns[0] = gamenoun1;
            libSet.IngVerbs = new string[4] {ingverb1,ingverb2,ingverb3,ingverb4};
            libSet.BodyPart[0] = bodypart1;
            libSet.Numbers[0] = number1;
            libSet.Places[0] = place1;
Console.WriteLine(libSet.IngVerbs);
            return View(libSet);
        }

        [Route("/MadLibs/Form")]
        public ActionResult Form() { return View(); }
    }
}