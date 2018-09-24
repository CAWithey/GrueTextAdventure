using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureFinal
{
    class LevelChange : GlobalVar
    {
        /*
        public LevelChange()
        {
            //Console.WriteLine("Rawr?  Rawr!");
        }
        */

        public string LevelDesc(string x)
        {
            if (x == "0") { Console.WriteLine("A wide door stands ajar to your north, leading to the dreaded creature's domain."); }
            else if (x == "1")
            {
                Console.WriteLine("- You stand in the throne room of the mighty Grue, the shadowy beast staring upon you with beady red eyes.");
                Console.WriteLine("Doorways lead out of the throne room in each direction.");
            }
            else if (x == "2")
            {
                Console.WriteLine("- A great hall lies before you, windows of broken glass lining both sides. Dusty cobwebs and creeping vines hang across the arched ceiling.");
                Console.WriteLine("On either side of the hallway is a heavy wooden door.");
            }
            else if (x == "3")
            {
                Console.WriteLine("- The stone hall leads to the shores of a swiftly moving underground stream. A rotted wooden bridge sways uneasily above the babbling waters.");
                if (!bridgeBroken) { Console.WriteLine("The rickety bridge leads to the west while a small cave entrance leads north."); }
                else { Console.WriteLine("Sturdy ropes hang suspended from the side of the cliff, firmly attached to stalagmites where the bridge had once been."); }
            }
            else if (x == "4")
            {
                Console.WriteLine("- The bones of a great dragon lie here, a skeletal claw wrapped tightly around the hilt of a broken sword. Around it lay the charred and battered remains of previous adventurers.");
                Console.WriteLine("A small cave leads back south.");
            }
            else if (x == "5")
            {
                if (!coffinsOpen)
                {
                    Console.WriteLine("- Cold stone walls surround you, six coffins of stone standing sentinel upright along either side of the mausoleum. A stone slab of an altar stands at the end of the corridor, dusty with age and neglect.");
                }
                else
                {
                    Console.WriteLine("- Cold stone walls surround you, six coffins of stone standing sentinel upright, their lids pulled aside to reveal dust-covered mummies, empty eye sockets staring back. A stone slab of an altar stands at the end of the corridor, dusty with age and neglect.");
                }
                if (!hasGem) { Console.WriteLine("A dull green gem sits buried in cob web upon the altar."); }
                Console.WriteLine("A wooden doorway leads to the west.");
            }
            else if (x == "6")
            {
                Console.WriteLine("- Dank, dark passages of a mine shaft lead sharply down into the Earth. Wooden frames line the narrow dirt passage as it descends.");
                if (!hasTorch)
                {
                    Console.WriteLine("It is too dark to proceed.");
                    Console.WriteLine("A small doorway leads to the south.");
                }
                else
                {
                    Console.WriteLine("The mine shaft leads further down. Your torch lights the way.");
                    Console.WriteLine("A small doorway leads to the south while the mine leads north.");
                }
            }
            else if (x == "7")
            {
                Console.WriteLine("- The mine leads to the small, squat home of a troll. The small creature eyes you suspiciously. Behind him on a low bench rests a large sphere of glass.");
                Console.WriteLine("The cave leads back up to the south.");
            }
            else if (x == "8")
            {
                Console.WriteLine("- A fast moving stream cuts the chamber in two to the east. You stand on silt shores beside the stream in a wide, underground chasm. Remnants of an ancient rope bridge hang suspended near the stream.");
                Console.WriteLine("On the rocks beside you are carvings of different animals.");
                Console.WriteLine("A path leads down to the water to the south.");
            }
            else if (x == "9")
            {
                Console.WriteLine("- The path angles down to the stream edge. The walls of the cavern close in as water slickens the rocks, making travel difficult.");
                Console.WriteLine("A giant turtoise looks curiously at you from the water's edge. It speaks as you approach, offering you safe passage across, if you can complete its riddle.");
            }
            else if (x == "10")
            {
                Console.WriteLine("- Balancing upon the slick rocks at the water's edge, you find yourself in a small alcove at the side of the cliff. There is a beached canoe, fractured into pieces, containing wooden crates and debris.");
            }
            return "";
        }

        public string ChangeLevel(string x)
        {
            if (x == "north")
            {
                return "You travel north.";
            }
            if (x == "south")
            {
                return "You travel south.";
            }
            if (x == "east")
            {
                return "You travel east.";
            }
            if (x == "west")
            {
                return "You travel west.";
            }
            else return "";
        }
    }
}
