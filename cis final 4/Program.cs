using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis_final_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int max = 2;
            string[] name = new string[max];
            double[] exam = new double[max];
            double[] quiz = new double[max];
            double[] lab = new double[max];

            Console.WriteLine("This is a grade calculator");

            for(int index =0; index<max;index++)
            {
                Console.WriteLine("Please enter students name: "+(index+1) );
                name[index] = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine();
            for (int index =0;index<max;index++)
            {
                Console.WriteLine("Please enter the exam averages for each student: "+(index+1) );
                exam[index] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            for (int index=0; index<max;index++)
            {
                Console.WriteLine("Please enter the quiz averages for each student: "+(index+1) );
                quiz[index] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            for (int index=0; index<max;index++)
            {
                Console.WriteLine("Please enter the lab averages for each student: "+(index+1) );
                lab[index] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            for(int index=0; index<max;index++)
            {
                if(exam[index]<=100&&exam[index]>=90)
                {
                    Console.WriteLine("The exam grade is an A");
                }
                if (exam[index]<=80 && exam[index]>=89)
                {
                    Console.WriteLine("The exam grade is a B");
                }
                if (exam[index] <= 70 && exam[index] >= 79)
                {
                    Console.WriteLine("The exam grade is a C");
                }
                if (exam[index] <= 60 && exam[index] >= 69)
                {
                    Console.WriteLine("The exam grade is a D");
                }
                else
                {
                    Console.WriteLine("The exam grade is an F");
                }
            }
            for (int index=0; index<max; index++)
            {
                if(lab[index]<=100 && lab[index]>=90)
                {
                    Console.WriteLine("The lab grade is an A");
                }
                if (lab[index] <= 80 && lab[index] >= 89)
                {
                    Console.WriteLine("The lab grade is a B");
                }
                if (lab[index] <= 70 && lab[index] >= 79)
                {
                    Console.WriteLine("The lab grade is a C");
                }
                if (lab[index] <= 60 && lab[index] >= 69)
                {
                    Console.WriteLine("The lab grade is a D");
                }
                else
                {
                    Console.WriteLine("The lab grade is an F");
                }
            }
            for (int index=0; index<max; index++)
            {
                if (quiz[index]<=100 && quiz[index]>=90)
                {
                    Console.WriteLine("The quiz grade is an A");
                }
                if (quiz[index] <= 80 && quiz[index] >= 89)
                {
                    Console.WriteLine("The quiz grade is a B");
                }
                if (quiz[index] <= 70 && quiz[index] >= 79)
                {
                    Console.WriteLine("The quiz grade is a C");
                }
                if (quiz[index] <= 60 && quiz[index] >= 69)
                {
                    Console.WriteLine("The quiz grade is a D");
                }
                else
                {
                    Console.WriteLine("The quiz grade is an F");
                }

            }
            Console.ReadLine();

        }
    }
}
