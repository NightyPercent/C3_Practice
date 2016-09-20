/*
 * 捕获异常
 * 2016.9.20
 * NintyPercent
 * 该程序只是为了实际操作下，并不能正常执行
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.TryExceptionA();
            mc.TryExceptionB();
            Console.ReadKey();
        }
    }

    //系统检测异常抛出
    class MyClass
    {
        public void TryExceptionA()
        {
            int a = 10;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch(System.IndexOutOfRangeException e)//异常类型不对，不会执行
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("MyClass.TryExceptionA is done");
            }
        }
        /// <summary>
        /// 主动抛出异常
        /// </summary>
        public void TryExceptionB()
        {
            int numA = 0;
            try
            {
                if(numA == 0)
                {
                    SystemException e = new SystemException();//手动抛出异常，触发Catch
                    throw (e);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("MyClass.TryExceptionB is Done");
            }
        }
    }
}
