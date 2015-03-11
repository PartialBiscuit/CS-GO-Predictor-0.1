using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press the Enter key.");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);

            Console.WriteLine("Who is going to win the ESL One Katowice 2015 Major?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "fnatic")

                message = ("Only if they will discover a new OP boost before the finals.");

            else if (userValue == "HellRaisers")

                message = ("cyka niet");

            else if (userValue == "hellraisers")

                message = ("cyka niet");

            else if (userValue == "NaVi")

                message = ("Da. They have a chance. Edward + Guardian = EZ WINS EZ SKINS ");

            else if (userValue == "navi")

                message = ("Da. They have a chance. Edward + Guardian = EZ WINS EZ SKINS ");

            if (userValue == "NiP")

                message = ("allu barely speaks Swedish, it's like having a Russian on your team in MM. Don't bet on them.");

            if (userValue == "nip")

                message = ("allu barely speaks Swedish, it's like having a Russian on your team in MM. Don't bet on them.");

            if (userValue == "PENTA")

                message = ("First, let's just hope nobody on their team gets VAC banned before the major and then we can predict. ");

            if (userValue == "penta")

                message = ("First, let's just hope nobody on their team gets VAC banned before the major and then we can predict.");

            if (userValue == "EnvyUS")

                message = ("EZ GROUP, EZ FINAL");

            if (userValue == "envyus")

                message = ("EZ GROUP, EZ FINAL");

            if (userValue == "TSM")

                message = ("TSM org is located in California. California = KQLYfornia. KQLYfornia = KQLY. KQLY = HAX. They will hax during the major. WAKE UP PEOPLE!");

            if (userValue == "tsm")

                message = ("TSM org is located in California. California = KQLYfornia. KQLYfornia = KQLY. KQLY = HAX. They will hax during the major. WAKE UP PEOPLE!");

            if (userValue == "Virtus.Pro")

                message = ("They've been choking too much lately, sry Poles. They will get out of the group so they've got that going for them which is nice.");

            if (userValue == "vp")

                message = ("They've been choking too much lately, sry Poles. They will get out of the group so they've got that going for them which is nice.");

            if (userValue == "VP")

                message = ("They've been choking too much lately, sry Poles. They will get out of the group so they've got that going for them which is nice.");

            if (userValue == "3dmax")

                message = ("no allu, no win.");

            if (userValue == "Cloud9")

                message = ("*chuckles*");

            if (userValue == "CLG")

                message = ("No. Traik will oversleep the final match.");

            if (userValue == "Flipsid3")

                message = ("Look at the group they are in. Yeah, not gonna happen.");

            if (userValue == "Keyd")

                message = ("Sorry, who?");

            if (userValue == "LGB")

                message = ("woah, this is a predictor. Not a dream fulfilment software. Don't be crazy.");

            if (userValue == "lgb")

                message = ("woah, this is a predictor. Not a dream fulfilment software. Don't be crazy.");

            if (userValue == "Titan")

                message = ("Let's hope that kennyS has the weight limit turned off.");

            if (userValue == "kennyS")

                message = ("Let's hope that kennyS has the weight limit turned off.");

            if (userValue == "Vox")

                message = ("No way, mate. Even a kangaroo can't carry them to the finals.");

            if (userValue == "VoxEminor")

                message = ("No way, mate. Even a kangaroo can't carry them to the finals.");





            else


                message = ("Sorry, we didn't understand.");
            Console.WriteLine(message);


                //string message = (userValue == "1") ? "boat" : "strand of lint" ;
                //Console.WriteLine("You won a {0}", message);

                Console.ReadLine();
            }
        }
    }

