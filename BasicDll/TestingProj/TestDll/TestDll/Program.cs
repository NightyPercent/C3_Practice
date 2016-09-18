/*
 *2016.9.25--NintyPercent
 *
 * 写过这么久程序，从没有自己搭过环境，连dll和lib都没有自己生成过，需要补一下了
 * 
 *1、把生成的Dll文件（实际操作发现.pdb文件可以忽略掉，所以还没有搞懂.pdb文件的具体用处）放在该项目的Bin文件夹下(查过，不需要放在Bin文件夹下，可以在
 *项目里新建一个文件夹，把第三方程序集统一放进来，这样做可以在项目转移时不会出现找不到dll的问题（网上的说法是解决方案可以自己把路径改为相对路径~）)，
 *2、在引用里添加了HelloWorldDll程序集，
 *3、文件开始添加了Using HelloWorldDll
 *注：HelloWorldDll是引用的程序集的命名空间，HelloW是该命名空间的一个类， PrintHelloWorld方法是一个静态方法，功能是直接打印"HelloWorld~"
 *
 * 查了下，c#是基于.netFramework，是不能生成lib文件的，相对的，c++可以生成lib文件，等回顾c++时再实验吧
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
