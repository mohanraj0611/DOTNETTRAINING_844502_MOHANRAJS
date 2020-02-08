using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6] {83,56,78,58,38,73};
            result objr = new result();
            var avg = objr.getaveragemarks(marks); //acessing the result class functionality
            objr.displayaverage(avg);
            objr.showgrade(avg);
            Console.ReadKey();

        }
    }

    public interface IExam
    {
        double getaveragemarks(int[] marks);
        void displayaverage(double avg);
    }
    public interface Istudent
    {
        void showgrade(double avg);
    }
    public class result : IExam, Istudent
    {
        public void displayaverage(double avg)
        {
            Console.WriteLine("the average marks={0}", avg);
        }

        public double getaveragemarks(int[] marks)
        {
            int total;
            double avg;
            total = 0;
            for (int i = 0; i < marks.Length; i++)
                total += marks[i];
            avg = total / marks.Length;
            return avg;
        }

        public void showgrade(double avg)
        {
            if(avg>=70.00)
            {
                Console.WriteLine("passed in destinction");
            }
            else
            {
                Console.WriteLine("not passedin destinction");
            }
        }
    }

}
