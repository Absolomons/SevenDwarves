using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenDwarves
{
    public interface IDwarves
    {

        void ReactLastOnList();

        void ReactCallDwarf();

        void ReactRemoveDwarf(IDwarves dwarf);

    }

    public class Sleepy:IDwarves
    {
        public void ReactLastOnList()
        {
            Console.WriteLine("Sleepy goes to bed, cuz he sleepy");
        }

        public void ReactCallDwarf()
        {
            Console.WriteLine("Sleepy yawns so loudly that another dwarf joins");
        }

        public void ReactRemoveDwarf(IDwarves dwarf)
        {
            switch (dwarf)
            {
                case Sneezy:
                    Console.WriteLine("Sleepy forces Sneezy to go to sleep (chloroform)");
                    break;
                case Happy:
                    Console.WriteLine("Sleepy always makes Happy happy, happy goes for a run outside");
                    break;
                case Grumpy:
                    Console.WriteLine("Sleepy annoys Grumpy so much that he leaves");
                    break;
            }
        }
    }
    public class Sneezy : IDwarves
    {
        public void ReactLastOnList()
        {
            Console.WriteLine("Sneezy sneezes so hard he blows himself unconscious");
        }
        public void ReactCallDwarf()
        {
            Console.WriteLine("Sneezy sneezes so loudly that another dwarf wakes up and joins the party");
        }

        public void ReactRemoveDwarf(IDwarves dwarf)
        {
            switch (dwarf)
            {
                case Sleepy:
                    Console.WriteLine("Sneezy sneezes on Sleepy which makes him fall asleep");
                    break;
                case Happy:
                    Console.WriteLine("Sneezy makes funny noises so Happy leaves, funnily");
                    break;
                case Grumpy:
                    Console.WriteLine("Sneezys huge amount of snot makes Grumpy leave in anger");
                    break;
            }
        }
    }
    public class Happy : IDwarves
    {
        public void ReactLastOnList()
        {
            Console.WriteLine("Happy is happy, so he goes to bed");
        }
        public void ReactCallDwarf()
        {
            Console.WriteLine("Happy starts singing which attracts his good friend and lover");
        }

        public void ReactRemoveDwarf(IDwarves dwarf)
        {
            switch (dwarf)
                {
                    case Sleepy:
                        Console.WriteLine("Happy is hella boring which makes Sleepy fall asleep");
                        break;
                    case Sneezy:
                        Console.WriteLine("Happy makes Sneezy laugh too hard so he has to go sneeze outside");
                        break;
                    case Grumpy:
                        Console.WriteLine("Happy slaughters Grumpy, leaving his entrails lying on the floorboards of the small wooden hut. The last shred of humanity has left the soul of the otherwise jolly dwarf.");
                        break;
                }
        }
    }
    public class Grumpy : IDwarves
    {
        public void ReactLastOnList()
        {
            Console.WriteLine("Grumpy is angry at the other dwarves so he goes to bed.");
        }
        public void ReactRemoveDwarf(IDwarves dwarf)
        {
            switch (dwarf)
            {
                case Sneezy:
                    Console.WriteLine("Grumpy hates Sneezy since he is so noisy and angrily mumbles demonic speech under his breath");
                    break;
                case Happy:
                    Console.WriteLine("Grumpy and Happy are arch nemesis, 2 wolves chasing the moon and sun, awwoo (Happy runs away)");
                    break;
                case Sleepy:
                    Console.WriteLine("Grumpy sits by the bed of Sleepy and sings him a lullaby");
                    break;
            }
        }

        public void ReactCallDwarf()
        {
            Console.WriteLine("Grumpy shouts so loudly that he attracts another of the dwarves");
        }
    }

    public class Randomizer
    {
        public int Randomize(Random random)
        {
            return random.Next(1,5);
        }
    }
}
