using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myRec
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int myNum = Convert.ToInt32(Console.ReadLine());
            reMeth(myNum);
            void reMeth(int num)
            {
                Console.WriteLine(num);
                //int maxNum = num;
                //if (num == maxNum)
                if(num == 0)
                {
                    return;
                }
                else
                {
                     reMeth(num-1);

                }
            }
           
            Console.ReadLine();
        }
    }
}
