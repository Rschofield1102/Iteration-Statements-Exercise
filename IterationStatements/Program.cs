namespace IterationStatements
{
    public class Program
    {

        static void Main(string[] args)
        {
            Thousand();
            ByThree();
            //Equal2();
            Equal(5, 5);
            EvenOrOdd();
            PosOrNeg();
            Vote();
            Check();
            Math();
        }



        ////Exercise1 ---------//Write code from 1000 to -1000
        public static void Thousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        ////Exercise2 ---------//Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int a = 3; a <= 999; a += 3)//<-- a+=3 is adding by 3 each time
                                             //---a<=999 is less than or equal to 999
            {
                Console.WriteLine(a);
            }
        }

        //Exercise3 --------//Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Equal(int a, int b)
        {


            if (a == b)
            {
                Console.WriteLine(true);

            }
            else if (a < b)
            {
                Console.WriteLine(false);
            }


        }




        // void this one out, I did it without parameters for extra practice :)
        //public static void Equal2()
        //    {

        //        for (int a = 2; a <= 2; a++)
        //    {
        //        Console.WriteLine($"{a} is equal to {a}");
        //    }
        //}




        //Exercise4--------Write a method to check whether a given number is even or odd
        // This one was challenging, but it was really fun!
        public static void EvenOrOdd()
        {

            int number = Convert.ToInt32(Console.ReadLine()); //had to Convert.ToInt32 for it to read. 

            if (number % 2 == 0)
            {
                Console.WriteLine("even");

            }
            else
            {
                Console.WriteLine("odd");
            }
        }


        //Exercise5------//Write a method to check whether a given number is positive or negative

        public static void PosOrNeg()
        {
            Console.WriteLine("input number + or -");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("is a postive number");
            }
            else if (num1 > 0)
            {
                Console.WriteLine("is a negative number");
            }

        }




        //Exercise6-------//Write a method to read the age of a candidate and determine whether they can vote.
        public static void Vote()
        {
            Console.WriteLine("Input your age");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("can vote");
            }
            else if (age < 18)
            {
                Console.WriteLine("Can not vote");
            }


        }






        //Exercise 7-----//Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Check()
        {
            Console.WriteLine("Input your number to check range");
            int range = Convert.ToInt32(Console.ReadLine());

            if (range >= -10 && range <= 10)
            {
                Console.WriteLine("in range");

            }
            else if (range >= -11 && range <= 11)
            {
                Console.WriteLine("not in range");
            }


        }





        //Exercise 8-----//Write a method to display the multiplication table(from 1 to 12) of a given integer
        // Having trouble with this one. It adds but does not multiply??
        public static void Math()     ///Disregard. Fixed it this morning, had to review a bit and also used google a lot :)
        {
            //int a = 1;
            //int b = 1;


            //while (a <= 12 && b <= 12)
            //{

            //    Console.WriteLine(a * b);
            //    a++;
            //}


            Console.WriteLine("Enter number");
            int num, i, res;
            num = int.Parse(Console.ReadLine());
            for ( i = 1; i<= 12; i++)
            {
                res = num * i;
                Console.WriteLine("{0} x {1} = {2} ", num, i, res);
                
            }

            Console.ReadLine();

            //Call the methods to test them in the Main method below














        }



    }
} 