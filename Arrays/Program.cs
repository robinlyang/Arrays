using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    enum days { sun, mon, tue, wed, thu, fri, sat }
    enum months { jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec }
    enum ratings { good = 22, average = 33, poor = 44 }
    class worker
    {
        public string name;
        public int[] hours = new int[7];

    }
    class Program
    {
        static void Main(string[] args)
        {
            worker w = new worker();
            w.name = "bob";
            w.hours[3] = 6;
            //when dealing with array of classes the array must be initialized.
            //START
            worker[] people = new worker[100];  //Step 1: declare array
            for(int w2=0; w2<people.Length; w2++)
            {
                people[w2] = new worker();      //initialize with NEW command inside of a loop
            }
            //END

            people[1].name = "bob";
            people[1].hours[3] = 6;

            double[] sales = new double[12];
            int size = 24;
            double[] sales2 = new double[size];
            sales[1] = 100.00;
            int[] hours = { 5, 6, 7, 8, 9 }; //initializes 'hours' array to have 5 elements
            int[] hours2 = { size, 6, 7, 8, 9 };
            int[] hours3 = { 5, 6, 7, 8, 9 };
            //problem with arrays
            Console.WriteLine(hours);                   // cannot print arrays; you need a loop
            // to print
            for(int x = 0; x < hours.Length; x++)
                Console.WriteLine(hours[x]);
            
            foreach(int x2 in hours) Console.WriteLine(x2);

            if (hours == hours3)                         // looks at the memory location; must use loop
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("different");
            }

            //to compare
            bool same = true;
            for (int x3 = 0; x3 < hours.Length; x3++)
            {
                if (hours[x3] != hours3[x3])
                    same = false;
            }
            if(same)
            {
                Console.WriteLine("loop is same");
            }
            else
            {
                Console.WriteLine("loop is different");
            }

            hours2 = hours;
            hours[1] = 10;                              // updates memory location for hours2 as well; need a loop
            Console.WriteLine(hours2[1]);

            //to copy data
            int[] hours4 = new int[hours.Length];
            for(int x4 = 0; x4 < hours.Length; x4++)
            {
                hours4[x4] = hours[x4];
            }

            hours[(int)days.wed] = 4;
            for (int x5 = (int)days.mon; x5 <= (int)days.wed; x5++)
                Console.WriteLine(hours[x5]);

            //2 dimensional arrays
            //rectagular 2 dimensional array
            int[,] data = new int[2, 3]; // 2 rows and 3 columns
            data[0, 2] = 10; //row 0, column 2 (the last column)
            //can also be initialized with data
            int[,] data2 = { { 1, 2, 3 }, { 4, 5, 6 } };
            //foreach loop is perfect for adding up all the numbers, but not great for printing
            int total = 0;
            foreach (int x6 in data2)
            {
                total += x6;
            }
            Console.WriteLine("TOTAL: " + total);
            //you need 2 for loops to print rows and columns
            for(int r = 0; r<data2.GetLength(0);r++) //0 gets first column
            {
                for(int c=0; c<data.GetLength(1);c++)//1 gets next column
                {
                    Console.Write(data2[r, c] + " ");
                    Console.WriteLine();
                }
            }

            //jagged 2 dimensional array
            int[][] data3 = new int[12][];  //no size on columns
            //for every row; you have to tell it how big it is
            data3[0] = new int[31];         //January has 31 days
            data3[1] = new int[28];
            data3[2] = new int[31];
            data3[3] = new int[30];
            data3[2][4] = 8;                //this puts data into February 4th
            //rectangular 2 dimensional array for a calendar
            double[,] cal_sales = new double[12, 31];
            cal_sales[3, 15] = 100.00;      //this goes into April 16th
            //a better way
            double[,] calendar = new double[13, 32];
            calendar[3, 15] = 100.00;       //treat as March 15 (ignore 0 row, o column)



            Console.Read();

        }
    }
}
