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
            string name =Console.ReadLine();
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
            







        }
    }
}
