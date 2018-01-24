using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fullName = "Benjamin Gibson Klein";
            //string favoriteCar = "Aston Martin DBS V12";
            //string favoriteComicCharacter = "Harvey Pekar";
            //Console.WriteLine("My full name is " + fullName);
            //Console.WriteLine("My favorite car is " + favoriteCar);
            //Console.WriteLine("My favorite comic character is " + favoriteComicCharacter);

            ////Lisa's muffins. unitOne represents total cups of sugar in recipe. unitTwo represents cups of sugar already added.
            //int unitOne = 7;
            //int unitTwo = 2;
            //Console.WriteLine(unitOne - unitTwo);

            ////Mike and Friends Tab.  unitOne represents number of payees. unitTwo represents amount each paid.
            //unitOne = 4;
            //unitTwo = 13;
            //Console.WriteLine(unitOne * unitTwo);

            ////Diapers. unitOne represents total money have to spend. unitTwo represents price per package.
            //unitOne = 40;
            //unitTwo = 8;
            //Console.WriteLine(unitOne / unitTwo);

            ////Trevon's wages. unitOne represents money he started with. unitTwo represents total money he ended up with.
            //unitOne = 29;
            //unitTwo = 41;
            //Console.WriteLine(unitTwo - unitOne);

            ////Pranav's running. unitOne represents Julie's miles. unitTwo represents the delta.
            //unitOne = 47;
            //unitTwo = 30;
            //Console.WriteLine(unitOne - unitTwo);

            ////Envelopes. unitOne represents total money have to spend. unitTwo represents price per envelope.
            //unitOne = 12;
            //unitTwo = 3;
            //Console.WriteLine(unitOne / unitTwo);

            ////Norachai's salad. unitOne represents cost of salad. unitTwo represents cash after purchase.
            //float unitThree = 5.12f;
            //float unitFour = 27.10f;
            //Console.WriteLine(unitThree + unitFour);


            //double valueOne = 7;
            //double valueTwo = 2;
            //Console.WriteLine(valueOne - valueTwo);
            //valueOne = 13;
            //valueTwo = 4;
            //Console.WriteLine(valueOne * valueTwo);
            //valueOne = 40;
            //valueTwo = 8;
            //Console.WriteLine(valueOne / valueTwo);
            //valueOne = 41;
            //valueTwo = 29;
            //Console.WriteLine(valueOne - valueTwo);
            //valueOne = 47;
            //valueTwo = 30;
            //Console.WriteLine(valueOne - valueTwo);
            //valueOne = 12;
            //valueTwo = 3;
            //Console.WriteLine(valueOne / valueTwo);
            //valueOne = 27.10;
            //valueTwo = 5.12;
            //Console.WriteLine(valueOne + valueTwo);

            //int[] numLPs = new int[25];

            //string[] genreLPs = new string[25];
            //genreLPs[0] = "Rock";
            //genreLPs[1] = "Alternative Rock";
            //genreLPs[2] = "Indie Rock";
            //genreLPs[3] = "Blues Rock";
            //genreLPs[4] = "Oldies";
            //genreLPs[5] = "Rockabilly";
            //genreLPs[6] = "Psychobilly";
            //genreLPs[7] = "Bluegrass";
            //genreLPs[8] = "Metal";
            //genreLPs[9] = "Soul";
            //genreLPs[10] = "Folk";
            //genreLPs[11] = "Bebop";
            //genreLPs[12] = "Swing";
            //genreLPs[13] = "Hip Hop";
            //genreLPs[14] = "Rap";
            //genreLPs[15] = "Classical";
            //genreLPs[16] = "Smooth Jazz";
            //genreLPs[17] = "Alt Country";
            //genreLPs[18] = "Roots Rock";
            //genreLPs[19] = "Art House";
            //genreLPs[20] = "House";
            //genreLPs[21] = "Electro";
            //genreLPs[22] = "Drum and Bass";
            //genreLPs[23] = "Soundtracks";
            //genreLPs[24] = "Christmas";

            //for (int i = 0; i < numLPs.Length; i++)
            //{
            //    Console.WriteLine("Please enter number of albums under " + genreLPs[i]);
            //    numLPs[i] = int.Parse(Console.ReadLine());
            //}

            ////numLPs[0] = 123;
            ////numLPs[1] = 256;
            ////numLPs[2] = 237;
            ////numLPs[3] = 65;
            ////numLPs[4] = 24;
            ////numLPs[5] = 143;
            ////numLPs[6] = 237;
            ////numLPs[7] = 24;
            ////numLPs[8] = 54;
            ////numLPs[9] = 234;
            ////numLPs[10] = 12;
            ////numLPs[11] = 209;
            ////numLPs[12] = 32;
            ////numLPs[13] = 67;
            ////numLPs[14] = 45;
            ////numLPs[15] = 165;
            ////numLPs[16] = 39;
            ////numLPs[17] = 78;
            ////numLPs[18] = 230;
            ////numLPs[19] = 32;
            ////numLPs[20] = 345;
            ////numLPs[21] = 31;
            ////numLPs[22] = 89;
            ////numLPs[23] = 101;
            ////numLPs[24] = 25;

            //Console.WriteLine("Vinyl Inventory");

            //for (int i = 0; i < numLPs.Length; i++)
            //{
            //    Console.WriteLine(genreLPs[i] + ": " + numLPs[i]);
            //}

            //for (int i = 0; i < numLPs.Length; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(numLPs[i]);
            //    }
            //}

            int[] userNum = new int[10];

            int sum = 0; //for second solution to problem, ie not needed in first solution

            for (int i = 0; i < userNum.Length; i++)
            {
                Console.WriteLine("Please enter a whole number " + i);
                userNum[i] = int.Parse(Console.ReadLine());

            
            //int sum = userNum[1] + userNum[2]+ userNum[3]+ userNum[4] + userNum[5] + userNum[6] + userNum[7] + userNum[8] + userNum[9] + userNum[10];
            sum += userNum[i];
            }
            Console.WriteLine(sum);

            if (sum % 2 == 0)
            {
                Console.WriteLine("even");
            }

            else
            {
                Console.WriteLine("odd");
            }

            
        }
    }
}
