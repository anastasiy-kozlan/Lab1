using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class Class1
    {
        // Завдання 1
        /// <summary>
        /// Sk (finding the number of full weeks)
        /// </summary>
        /// <param name="R">the number of days that have elapsed since</param>
        /// <returns>returns the value of result</returns>
        
        public static double Sk(int R)
        {
            double result = R/7;
            return Convert.ToInt32(result);
        }


        // Завдання 2
        /// <summary>
        /// S (sum)
        /// </summary>
        /// <param name="n">third argument of the S</param>
        /// <returns>returns the value of result</returns>
        
        public static double S(int n)
        {
            double result = 0;
            for (int i=0; i<n; i++)
            {
                result = result + Math.Pow((-1), i) * (1 / Math.Pow(2, i));         
            }
            return result;
        }


        // Завдання 3
        /// <summary>
        /// st (sum)
        /// </summary>
        /// <param name="eps">first argument of the st</param>
        /// <param name="n">second argument of the st</param>
        /// <param name="z">third argument of the st</param>
        /// <returns>returns the value of the st</returns>
        
        public static double st(double eps, int n, double z)
        {
            double st = 0;
            for (int i = 1; i <= n; i++)
            {
                st = st + (Math.Pow((-1), n)) / (fact(n) * z);
                if (Math.Abs(st) < eps)
                {
                    break;
                }
            }
            return st;
        }

        /// <summary>
        ///  F
        /// </summary>
        /// <param name="eps">first argument of the F</param>
        /// <param name="n">second argument of the F</param>
        /// <param name="z">third argument of the F</param>
        /// <returns>returns the value of the  F</returns>

        public static double F(double eps, int n, double z)
        {
            double F = 1 - z * Math.Log(2);
            return F;
        }

        /// <summary>
        /// T
        /// </summary>
        /// <param name="n">third argument of the fact</param>
        /// <returns>returns the value of the  tmp</returns>

        static double fact(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="st">first argument of the T</param>
        /// <param name="F">second argument of the T</param>
        /// <returns>returns the value of the T</returns>

        public static double T(double st, double F)
        {
            double T = Math.Abs(st - F) / F * 1;
            return T;
        }
    }
}
