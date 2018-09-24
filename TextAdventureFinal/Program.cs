using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureFinal
{
    class Program : GlobalVar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings, adventurer. You have arrived upon the lair of the evil Grue, determined to smite it once and for all.");
            Console.WriteLine("Enter thy name:");
            playerName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("- The wide stone gate of creature's fortress stands ajar, daring any who enter the creature's domain.");
            Console.WriteLine("The door stands open to your north.");
            LevelLoop();
        }
        static void LevelChange(string direction)
        {
            Console.WriteLine("");

            switch (direction)
            {
                case "north":
                    if (levelNumber == 0) {
                        Console.WriteLine(level.ChangeLevel("north")); //Variable
                        levelNumber = 1;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 3)
                    {
                        Console.WriteLine(level.ChangeLevel("north")); //Variable
                        levelNumber = 4;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 1)
                    {
                        Console.WriteLine(level.ChangeLevel("north")); //Variable
                        levelNumber = 6;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 6 && hasTorch)
                    {
                        Console.WriteLine(level.ChangeLevel("north")); //Variable
                        levelNumber = 7;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 9)
                    {
                        Console.WriteLine(level.ChangeLevel("north")); //Variable
                        levelNumber = 8;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else { InvalidSelection(); }
                    break;
                case "south":

                    if (levelNumber == 1)
                    {
                        Console.WriteLine(level.ChangeLevel("south")); //Variable
                        levelNumber = 0;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 4)
                    {
                        Console.WriteLine(level.ChangeLevel("south")); //Variable
                        levelNumber = 3;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 6)
                    {
                        Console.WriteLine(level.ChangeLevel("south")); //Variable
                        levelNumber = 1;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 7)
                    {
                        Console.WriteLine(level.ChangeLevel("south")); //Variable
                        levelNumber = 6;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 8)
                    {
                        Console.WriteLine(level.ChangeLevel("south")); //Variable
                        levelNumber = 9;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else { InvalidSelection(); }
                    break;
                case "west":
                    if (levelNumber == 1)
                    {
                        Console.WriteLine(level.ChangeLevel("west")); //Variable
                        levelNumber = 2;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 2)
                    {
                        Console.WriteLine(level.ChangeLevel("west")); //Variable
                        levelNumber = 3;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 5)
                    {
                        Console.WriteLine(level.ChangeLevel("west")); //Variable
                        levelNumber = 1;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 3)
                    {
                        if (!bridgeBroken)
                        {
                            Console.WriteLine("The floor boards of the bridge splinter and crack beneath your feet. Just as you arrive on the other side, the ropes snap and the bridge falls into the raging waters.");
                            Console.WriteLine("");
                            bridgeBroken = true;
                            levelNumber = 8;
                            level.LevelDesc(levelNumber.ToString());
                        } else { InvalidSelection(); }
                    }
                    else { InvalidSelection(); }
                    break;
                case "east":
                    if (levelNumber == 2)
                    {
                        Console.WriteLine(level.ChangeLevel("east")); //Variable
                        levelNumber = 1;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 3)
                    {
                        Console.WriteLine(level.ChangeLevel("east")); //Variable
                        levelNumber = 2;
                        level.LevelDesc(levelNumber.ToString());
                    }
                    else if (levelNumber == 1)
                    {
                        Console.WriteLine(level.ChangeLevel("east")); //Variable
                        levelNumber = 5;
                        level.LevelDesc(levelNumber.ToString());

                    }
                    else { InvalidSelection(); }
                    break;
                case "take gem":
                    {
                        if (levelNumber == 5 && !hasGem)
                        {
                            if (!hasGlass) {
                                Console.WriteLine("The room around you begins to shake as rocks tumble from the ceiling. You replace the gem onto the altar before the ceiling can cave in.");
                            } else {
                                Console.WriteLine("You take the gem from the altar, quickly putting the glass sphere in its place.");
                                hasGlass = false;
                                hasGem = true;
                            }
                        } else { InvalidSelection(); }
                    }
                    break;
                case "take hilt":
                    {
                        if (levelNumber == 4)
                        {
                            Console.WriteLine("The skeletal claws of the dragon tighten their grip upon the sword hilt when you attempt to remove it.");
                        } else { InvalidSelection(); }
                    }
                    break;
                case "open coffins":
                    {
                        if (levelNumber == 5)
                        {
                            coffinsOpen = true;
                            Console.WriteLine("You drag the heavy stone lids of the coffins aside, revealing mummified remains.  In the arms of one you see a wooden torch and a rolled up parchment.");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "inspect grue":
                    {
                        if (levelNumber == 1)
                        {
                            Console.WriteLine("A writhing mass of shadowy tendrils and shifting midnight vapors, the blood red eyes of the Grue silently challenge you as you explore its castle.");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "speak to grue":
                    {
                        if (levelNumber == 1)
                        {
                            Console.WriteLine("The Grue says to you: 'Inside my domain are traps and creatures of my design. " + playerName + ", your bones shall soon add to the walls of this fortress.'");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "kill grue":
                    {
                        if (levelNumber == 1)
                        {
                            if (!hasSword)
                            {
                                Console.WriteLine("The Grue laughs at your pitiful attack. Only a fearsome weapon capable of Grue Smiting cover ever hope to smite a Grue as powerful as this.");
                            } else
                            {
                                Console.WriteLine("You brandish the Sword of Grue Smiting high and charge headlong at the Grue, hellbent on destroying the beast once and for all!");
                                Console.WriteLine("...");
                                EndGame();
                            }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "inspect troll":
                    {
                        if (levelNumber == 7)
                        {
                            Console.WriteLine("The squat troll has wrinkled, leathery skin of green and is carrying a warped blade of rusted iron. It watches your every move with great suspicion.");
                            if (!gaveCoin) { Console.WriteLine("It looks as though one wrong move might cause it to attack."); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "speak to troll":
                    {
                        if (levelNumber == 7)
                        {
                            if (!gaveCoin)
                            {
                                Console.WriteLine("The troll either doesn't understand you, or doesn't care to speak. It holds out an empty hand palm upward, as if expecting something, while waving its rusted sword around impatiently.");
                            } else { Console.WriteLine("The troll either doesn't understand you, or doesn't care to speak. It slinks in the shadows, waiting impatiently for you to leave."); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "kill troll":
                    {
                        if (levelNumber == 7)
                        {
                            Console.WriteLine("You have nothing by which to kill the troll, and the troll's blade looks surprisingly sharp from this distance, despite its age.");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "take glass":
                    {
                        if (levelNumber == 7)
                        {
                            if (!gaveCoin)
                            {
                                Console.WriteLine("The troll stands in your way, barring you from taking the sphere of glass.");
                            }
                            else if (!hasGlass)
                            {
                                hasGlass = true;
                                Console.WriteLine("You take the small sphere of clear glass. It's the size of a large gem stone.");
                            } else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "take torch":
                    {
                        if (levelNumber == 5)
                        {
                            if (!hasTorch)
                            {
                                hasTorch = true;
                                Console.WriteLine("You take the torch from the hands of the mummified corpse. You strike a flame upon the torch to light your way.");
                            } else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "read parchment":
                    {
                        if (levelNumber == 5)
                        {
                            Console.WriteLine("You unroll the parchment. It reads: 'Here, in the domain of the Grue, there is but one way to slay the monster. The Sword of Grue Smiting must be constructed, forging together a hilt, a gem, and a blade. Only then can you hope to succeed on your quest.'");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "take coin":
                    {
                        if (levelNumber == 4)
                        {
                            if (!hasCoin) { Console.WriteLine("You take one of the coins from the ground."); } else { Console.WriteLine("The skeletal dragon begins to shift as you reach for another coin, stopping you."); }
                            hasCoin = true;
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "take coins":
                    {
                        if (levelNumber == 4)
                        {
                            if (!hasCoin) { Console.WriteLine("You take one of the coins from the rubble on the ground."); } else { Console.WriteLine("The skeletal dragon begins to shift as you reach for another coin, stopping you."); }
                            hasCoin = true;
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "place gem":
                    {
                        if (levelNumber == 4 && hasGem)
                        {
                            Console.WriteLine("The gem fits perfectly into the hilt.");
                            swordPieces++;
                            hasGem = false;
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "place blade":
                    {
                        if (levelNumber == 4 && hasBlade)
                        {
                            Console.WriteLine("The blade fits perfectly onto the hilt.");
                            swordPieces++;
                            hasBlade = false;
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "kill turtle":
                    {
                        if (levelNumber == 9)
                        {
                            Console.WriteLine("The turtle deftly ducks away into the water when you attempt to strike it, only to come back out after you give up.");
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "speak to turtle":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 0)
                            {
                                Console.WriteLine("The turtle says to you: 'Name each of my animal companions and I will ferry you back to the other side of the stream.'");
                                Console.WriteLine("'I am a King of the Greens and the skies above. What am I?'");
                            }
                            if (puzzlesAnswered == 1)
                            {
                                Console.WriteLine("The turtle says to you: 'Answer correctly now my second riddle to proceed.'");
                                Console.WriteLine("The turtle says to you: 'I am the spirit of the fiercest warrior, but my younger brother is the best of your friends. What am I?'");
                            }
                            if (puzzlesAnswered == 2)
                            {
                                Console.WriteLine("The turtle says to you: 'Answer this final riddle and I will deliver you across the rapids.'");
                                Console.WriteLine("'Often an embodiment of evil, I can be either a fatal foe or a gardener's friend. What am I?'");
                            }
                            if (puzzlesAnswered == 3)
                            {
                                Console.WriteLine("The turtle says to you: 'Climb on my back and I will take you across.'");
                            }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "ride turtle":
                    {
                        if (levelNumber == 9)
                        {
                            Console.WriteLine("You climb onto the shell of the giant turtoise and allow it to ferry you across the swiftly moving waters of the underground stream. Once across, you scramble up the rock surface and walk back onto the path. ");
                            Console.WriteLine("");
                            levelNumber = 3;
                            level.LevelDesc(levelNumber.ToString());
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "lion":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 0)
                            {
                                Console.WriteLine("'That is the correct answer to my first riddle.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "a lion":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 0)
                            {
                                Console.WriteLine("'That is the correct answer to my first riddle.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "wolf":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 1)
                            {
                                Console.WriteLine("'That is the correct answer to my second riddle.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "a wolf":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 1)
                            {
                                Console.WriteLine("'That is the correct answer to my second riddle.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "snake":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 2)
                            {
                                Console.WriteLine("'That is the correct answer to my final riddle. You have earned the right to cross this stream.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "a snake":
                    {
                        if (levelNumber == 9)
                        {
                            if (puzzlesAnswered == 2)
                            {
                                Console.WriteLine("'That is the correct answer to my final riddle. You have earned the right to cross this stream.'");
                                puzzlesAnswered++;
                            }
                            else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "give coin":
                    {
                        if (levelNumber == 7)
                        {
                            if (hasCoin) {
                                Console.WriteLine("You place the coin into the outstretched hand of the troll, who steps aside and slinks into shadow, content to keep watching your every step.");
                                hasCoin = false;
                                gaveCoin = true;
                            } else { InvalidSelection(); }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "climb rope":
                    {
                        if (levelNumber == 10)
                        {
                            Console.WriteLine("You climb up the rope onto the rock path.");
                            levelNumber = 3;
                            level.LevelDesc(levelNumber.ToString());
                        }
                        else if (levelNumber == 3)
                        {
                            Console.WriteLine("You climb down the rope to the water's edge.");
                            levelNumber = 10;
                            level.LevelDesc(levelNumber.ToString());
                        }
                        else { InvalidSelection(); }

                    }
                    break;
                case "take sword":
                    {
                        if (levelNumber == 4)
                        {
                            if (swordPieces == 2) {
                                Console.WriteLine("Grasping tightly the completed sword, the skeletal claws of the dragon release their grip.");
                                Console.WriteLine("You now possess the Sword of Grue Smiting!");
                                swordPieces = 0;
                                hasSword = true;
                            }
                        }
                        else { InvalidSelection(); }
                    }
                    break;
                case "look":
                    if (levelNumber == 4)
                    {
                        if (!hasSword) { Console.WriteLine("The skeletal dragon remains wrap around the scattered remnants of charred skeletons and discarded goods, its claws holding the hilt of a sword. Searching among the rubble you find a small pile of coins."); }
                        else { Console.WriteLine("You see the skeletal remains of a dragon among long deceased adventurers."); }
                    }
                    else if (levelNumber == 8)
                    {
                        Console.WriteLine("The ledge overlooks the underground stream. Water-slick sections of rope hang useless from rotted planks of wood. Beside you, carved into the rock face, are crude images of the following animals:");
                        for (int i = 0; i < puzzle.Length; i++)
                        {
                            Console.WriteLine(puzzle[i] + " ");
                        }
                    }
                    else if (levelNumber == 10)
                    {
                        if (!hasBlade) { Console.WriteLine("Searching the water-logged remains, you scour the crates on the fragmented canoe, finding and taking the intact blade of a sword."); }
                        else { Console.WriteLine("You stand amongst the water-logged remains of an old canoe and its cargo, wedged into the alcove beside an underground stream."); }
                        hasBlade = true;
                    }
                    else { level.LevelDesc(levelNumber.ToString()); }
                    break;
                default:
                    InvalidSelection();
                    break;
            }
        }
        static void InvalidSelection()
        {
            Console.WriteLine("Invalid direction or answer.");
            LevelLoop();
        }
        static void LevelLoop()
        {
            string direction = "";
            string exits = "";

            //Possible commands per room
            if (levelNumber == 0) { exits = "north, look"; }
            else if (levelNumber == 1) { exits = "north, south, east, west, look, inspect grue, speak to grue, kill grue"; }
            else if (levelNumber == 2) { exits = "east, west, look"; }
            else if (levelNumber == 3 && !bridgeBroken) { exits = "north, east, west, look"; }
            else if (levelNumber == 3 && bridgeBroken) { exits = "north, east, look, climb rope"; }
            else if (levelNumber == 4 && hasGem) { exits = "south, look, take hilt, place gem"; }
            else if (levelNumber == 4 && hasBlade) { exits = "south, look, take hilt, place blade"; }
            else if (levelNumber == 4 && swordPieces == 2) { exits = "south, look, take sword"; }
            else if (levelNumber == 4 && hasSword) { exits = "south, look"; }
            else if (levelNumber == 4) { exits = "south, look, take hilt"; }
            else if (levelNumber == 5 && hasGem) { exits = "west, look, read parchment"; }
            else if (levelNumber == 5 && hasTorch) { exits = "west, look, take gem, read parchment"; }
            else if (levelNumber == 5 && !coffinsOpen) { exits = "west, look, take gem, open coffins"; }
            else if (levelNumber == 5 && coffinsOpen) { exits = "west, look, take gem, take torch, read parchment"; }
            else if (levelNumber == 6 && !hasTorch) { exits = "south, look"; }
            else if (levelNumber == 6 && hasTorch) { exits = "south, north, look"; }
            else if (levelNumber == 7 && !hasGlass && hasCoin) { exits = "south, look, take glass, inspect troll, speak to troll, kill troll, give coin"; }
            else if (levelNumber == 7 && !hasGlass && !hasCoin) { exits = "south, look, take glass, inspect troll, speak to troll, kill troll"; }
            else if (levelNumber == 7 && hasGlass && !hasCoin) { exits = "south, look, inspect troll, speak to troll, kill troll"; }
            else if (levelNumber == 8) { exits = "south, look"; }
            else if (levelNumber == 9 && puzzlesAnswered != 3) { exits = "north, look, speak to turtle, kill turtle"; }
            else if (levelNumber == 9 && puzzlesAnswered == 3) { exits = "north, look, speak to turtle, kill turtle, ride turtle"; }
            else if (levelNumber == 10) { exits = "climb rope, look"; }
            Console.WriteLine("Available commands are: " + exits);

            direction = Console.ReadLine();
            LevelChange(direction);
            Console.WriteLine("");
            LevelLoop();
        }
        static void EndGame()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your Sword of Grue Smiting bounces off the Grue harmlessly. It looks at you, laughing.");
            Console.ReadLine();
            Console.WriteLine("Impressed with your valor, the Grue acknowledges you with a curt nod. 'No one has ever come so close to smiting me as you have, " + playerName + ". I hope the village erects a statue in honor of how much further you got than anyone else.'");
            Console.ReadLine();
            Console.WriteLine("Then the Grue promptly eats you.");
            Console.ReadLine();
            Console.WriteLine("You have been eaten by a Grue.");
            Console.WriteLine("Congratulations! You win!");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
