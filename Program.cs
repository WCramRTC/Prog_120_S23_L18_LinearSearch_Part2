namespace Prog_120_S23_L18_LinearSearch_Part2
{
    internal class Program
    {


        static int numberOfStudents = 15; // You can change this, has to be 5 or higher. Code should work no matter what size

        // Data
        static string[] studentFirstName = new string[numberOfStudents];
        static string[] studentLastName = new string[numberOfStudents];
        static double[] csiGrades = new double[numberOfStudents];
        static double[] genEdGrades = new double[numberOfStudents];


        static void Main(string[] args)
        {
            CodeForTest_DontChange(); // !! Needs to first method in main, don't delete
                                      //----------------------------------------------
                                      // Place code below here

            //DisplayMethod();

            // What studenst have a csi grade BETWEEN 42 AND 100
            // number > 42 && number <= 100

            for (int i = 0; i < studentFirstName.Length; i++)
            {
                double csiGrade = csiGrades[i];
                if(csiGrade > 42 && csiGrade <= 100)
                {
                    FormatString(i);
                }

            }

        } // Main

        

        public static void DisplayMethod()
        {
            for (int i = 0; i < studentFirstName.Length; i++)
            {
                FormatString(i);
            }
        }

        public static void FormatString(int i)
        {
            Console.WriteLine($"{studentFirstName[i]} {studentLastName[i]} {csiGrades[i]} {genEdGrades[i]}");
        }


        // -------------------------------------------------------------
        // Code used to populate the arrays. Feel to look at them. But don't change them for the Final. 
        // Make a copy of this project and break that code as much as you want

        #region GenerateArrayCode
        public static void CodeForTest_DontChange()
        {
            PopulateArrays(numberOfStudents);
            CustomData();
        }

        public static void PopulateArrays(int count)
        {
            Random rand = new Random();

            string[] lastNames = {
                "Smith",
                "Johnson",
                "Williams",
                "Brown",
                "Jones",
                "Miller",
                "Davis",
                "Garcia",
                "Rodriguez",
                "Wilson",
                "Martinez",
                "Anderson",
                "Taylor",
                "Thomas",
                "Hernandez",
                "Moore",
                "Martin",
                "Jackson",
                "Thompson",
                "White"
            };

            string[] firstNames = {
                "James",
                "Mary",
                "Robert",
                "Patricia",
                "John",
                "Jennifer",
                "Michael",
                "Linda",
                "David",
                "Elizabeth",
                "William",
                "Elizabeth",
                "Barbara",
                "Richard",
                "Susan",
                "Joseph",
                "Jessica",
                "Thomas",
                "Sarah",
                "Charles",
                "Karen",
                "Christopher",
                "Lisa",
                "Daniel",
                "Nancy",
                "Matthew",
                "Betty",
                "Anthony",
                "Margaret",
                "Mark",
                "Sandra"
            };

            for (int i = 0; i < count; i++)
            {

                int fNameIndex = rand.Next(firstNames.Length);
                int lNameIndex = rand.Next(lastNames.Length);
                // System.Console.WriteLine("This ran");

                studentFirstName[i] = firstNames[fNameIndex];
                studentLastName[i] = lastNames[lNameIndex];
                csiGrades[i] = rand.Next(0, 101);
                genEdGrades[i] = rand.Next(0, 101);
            }


        } // PopulateArrays()

        public static void CustomData()
        {
            string[] stuFirst = { "Samuel", "Havelock", "Ford", "Authur" };
            string[] stuLast = { "Vimes", "Vetinari", "Prefect", "Dent" };
            int[] stuCSI = { 100, 102, 42, 20 };
            int[] stuGenEd = { 45, 102, 75, 56 };

            int[] indexes = new int[stuFirst.Length];

            Random rand = new Random();

            for (int i = 0; i < indexes.Length; i++)
            {

                int newIndex = rand.Next(studentFirstName.Length);

                while (MyContains(newIndex, indexes))
                {
                    newIndex = rand.Next(studentFirstName.Length);
                }

                indexes[i] = newIndex;

                studentFirstName[newIndex] = stuFirst[i];
                studentLastName[newIndex] = stuLast[i];
                csiGrades[newIndex] = stuCSI[i];
                genEdGrades[newIndex] = stuGenEd[i];
            }
        }
        // 45
        // 45 17 21 0

        public static bool MyContains(int search, int[] arr)
        {
            foreach (int value in arr)
            {
                if (search == value) return true;
            }
            return false;
        } // MyContains

        #endregion GenerateArrayCode

        public static void ExampleCode()
        {
            // Linear Search Part 2

            // Purpose : Linear search is used to look for a specific value in a collection
            // 5, 12, 5,1 3, 6, 18 , 0 , 9



            // Random
            // Create a random object

            int[] randomNumbers = RandomNumberArray(20, 1, 100);

            // Linear Search - Part 2

            // Modulus - Mod 
            // 10 / 3 = 3
            // 10 % 3 = 1

            // 10 % 2 = 0 <---- It equals even
            // 11 % 2 = 1 < ---- 1 Equals odd

            foreach (int number in randomNumbers)
            {
                if (number % 2 != 0)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(number);

            }

            // Loop through the collection ( collection of the same type : arrays, lists, linked list, binary trees, queues, stacks ) 
            // We compare a single value to our search criteria
            // We respond

            int numberOfOdd = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                if (randomNumbers[i] % 2 != 0)
                {
                    numberOfOdd++;
                }
            }

            Console.WriteLine("Number of Odd Numbers: " + numberOfOdd);


            // 0 Benel - Prog 120 - 101 
            // 1 David - Prog 120 - 101 
            // 2 Will - Prog 124 - 51 
            // 3 Josh - Prog 230 - 120 


        }

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