namespace Prog_120_S23_L18_LinearSearch_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Linear Search Part 2

            // Purpose : Linear search is used to look for a specific value in a collection
            // 5, 12, 5,1 3, 6, 18 , 0 , 9

            // Loop through the collection ( collection of the same type : arrays, lists, linked list, binary trees, queues, stacks ) 
            // We compare a single value to our search criteria
            // We respond

            // Random
            // Create a random object

          

  

        } // Main

        public static int[] RandomNumberArray(int count, int min, int max)
        {
            int[] temp = new int[count];
            Random rand = new Random();


            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rand.Next(min, max + 1);
            }

            return temp;
        }



        public static void RandomExample()
        {
            //Random rand = new Random(); // This is how you create a new random object

            //int faceUp = 0;
            //int faceDown = 0;
            //int totalFlips = 0;
            //int count = 0;

            //while (count < 10000000)
            //{
            //    int flip = rand.Next(2);

            //    if(flip == 0)
            //    {
            //        faceUp++;
            //    }
            //    else
            //    {
            //        faceDown++;
            //    }


            //    totalFlips++;
            //    count++;
            //}

            //Console.WriteLine($"Coin Flip\n" +
            //    $"Face Up : {faceUp}\n" +
            //    $"Face Down : {faceDown}\n" +
            //    $"Total : {totalFlips}\n" +
            //    $"Percentage Face Up {(double)faceUp / totalFlips * 100}\n" +
            //    $"Percentage Face Down {(double)faceDown / totalFlips * 100}");


        }


    } // class

} // namespace