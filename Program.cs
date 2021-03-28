using System;

namespace new_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            //define variables
            string charName = "Berk" ;
            char grade = 'A';
            int charAge = 35;
            double gpa = 4.2;
            float f_gpa= 4;
            decimal divisor = 3;
            bool isMale = true ;
            //Console.WriteLine(gpa + " - " +f_gpa +" - " + divisor);
            //Console.WriteLine(charName);
            //Console.WriteLine(charAge);

            //define variables


            //working with strings
            //\n means write to next row

            string phrase = "Giraffe Academy";

            Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine(phrase);

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            //return True False(True)
            Console.WriteLine(phrase.Contains("Academy"));
            //return first char(G)
            Console.WriteLine(phrase[0]);
            //return index position(8)
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf("a"));
            //return (-1) if there is no char in string
            Console.WriteLine(phrase.IndexOf("z"));
            //return substring when you give start index and end index
            Console.WriteLine(phrase.Substring(8));

            //Working with numbers

            int num = 6;
            //increase num by 1
            num++;
            Console.WriteLine(num);
            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Max(4,90));
            Console.WriteLine(Math.Round(3.7));

            //getting user input
            Console.Write("Enter your name: ");
            //string name =Console.ReadLine();
            string name="berk";
            Console.WriteLine("Hello "+ name);

            //Convert 
            int converted_num = Convert.ToInt32("56");
            Console.WriteLine(converted_num);

            //you can define more than one variable with same type
            string color, noun;

            //arrays
            int [] luckynumbers = {4,5,6,7};
            Console.WriteLine(luckynumbers[0]);
            luckynumbers[3]=1000;

            string[] friends = new string[7];
            friends[0]= "arda";

            //methods
            SayHi("Berk",27);

            //return statement
            Console.WriteLine(cube(5));

            //if statements

            int degree = 5;

            if (degree>50){
                Console.WriteLine("bigger than 50");

            }
            else if (degree>25)
            {
                Console.WriteLine("smaller than 50 bigger than 25");

            }else{
                Console.WriteLine("smaller than 25");
            }

            //switch statement

            string weektype;
            int day=0;
            switch(day)
            {

                case 0:
                    weektype="weekday";
                    
                    break;
                case 1:
                    weektype="weekend";
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }

            //while loop
            int index=1;
            while(index<10)
            {
            Console.WriteLine(index);
            index++;
            }


            //do while loop
            //before check while condition,firstly execute inside do statement
            index=1;
            do
            {
            index++;
            Console.WriteLine(index);
            }while(index<10);

            //for loop
            Console.WriteLine("FOR LOOP");
            for(int i =1; i<5;i++)
            {
                Console.WriteLine(i); 
            }

            //2d arrays
            //you can define empty 2d array
            int [,] my2darray=new int[2,3];
            int [,] numberGrid =
            {
                {1,2},
                {3,4},
                {5,6}    
            };
            Console.WriteLine(numberGrid[1,1]);


            //Comments

            /*
            Multiply Comments
            com
            com com
            */


            //try except block
            try{
                int zero,five,result;
                zero=0;
                five=5;
                result = five/zero;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }

            //more except block

                        try{
                int zero,five,result;
                zero=0;
                five=5;
                result = five/zero;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }catch(FormatException e)
            {
                Console.WriteLine(e);
            }










        }


        static void SayHi(string name,int age){
            Console.WriteLine("Hi Everyone and "+ name + " your age is " + age);
        }
        static int cube(int num){
            
            int result = num * num * num;

            return result;

        }
    }
}
