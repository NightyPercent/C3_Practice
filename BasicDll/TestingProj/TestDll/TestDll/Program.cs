/*
 *2016.9.25--NintyPercent
 *
 * 写过这么久程序，从没有自己搭过环境，连dll和lib都没有自己生成过，需要补一下了
 * 
 *1、把生成的Dll文件（实际操作发现.pdb文件可以忽略掉，所以还没有搞懂.pdb文件的具体用处）放在该项目的Bin文件夹下，
 *2、在该项目的Bin文件夹下在引
 *用里添加了HelloWorldDll程序集，
 *3、文件开始添加了Using HelloWorldDll
 *注：HelloWorldDll是引用的程序集的命名空间，HelloW是该命名空间的一个类， PrintHelloWorld方法是一个静态方法，功能是直接打印"HelloWorld~"
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorldDll;

namespace TestDll
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloW.PrintHelloWorld();
            Console.ReadKey();
        }
    }
}
