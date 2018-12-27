using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //double[] scores = new double[5];
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine("请录入{0}名学员的成绩:", i + 1);
            //    scores[i] = double.Parse(Console.ReadLine());
            //}
            //PrintScore(scores);
            //Console.WriteLine("提升5分之后学员的成绩是:");
            //ChangeScore(scores);
            //反射
            //Singleton singleton = Singleton.GetInstance();
            //MessageBox.Show(singleton.GetHashCode().ToString());
            //Singleton singleton1 = Singleton.GetInstance();
            //MessageBox.Show(singleton1.GetHashCode().ToString());
            //var c = typeof(Singleton);//使用反射打破封装
            // //c.GetMethods();
            //MessageBox.Show(c.ReflectedType.GetHashCode().ToString());

        }
        public static void PrintScore(double[] scores)
        {
            foreach (double score in scores)
            {
                Console.WriteLine(score);
            }
        }
        public static void ChangeScore(double[] scores)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] += 5;
                if(scores[i] > 100)
                {
                    scores[i] = 100;
                }
            }
        }
    }
}
