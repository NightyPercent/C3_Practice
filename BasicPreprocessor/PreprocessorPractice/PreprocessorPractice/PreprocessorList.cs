/*
 * 预处理执行（有且不限于（不确定是否还有其他预处理指令））
 * 
 * #define identifier  //定义编译符(编译符可以是除true和false以外的任何编译符，包括c#关键字
 * #undef identifier    //取消定义的编译符
 * #if expresion        //如果表达式是true，变异下面的一段
 * #elif expression     //如果表达式是true，编译下面一段（if的分支
 * #else                //如果之前的#if和#elif表达式是false，编译下面的片段
 * #endif               //标记一个#if结构的结束
 * #region name         //标记一个代码段的开始，没有编译效果（常用
 * #endregion name      //标记一个代码段的结束，跟#region配对，没有编译效果（常用
 * #warning message     //显示编译时的警告消息
 * #error message       //显示编译时的错误消息
 * #line indicate       //修改在编译器消息中显示的行数（indicate:表明）
 * #pargma text         //指定有关程序上下文的信息
 */

/* 基本规则：
 * 1、不能和c#代码同行
 * 2、不需要以分号结尾
 * 3、必须以“#”开始
 * 4、允许行尾注释，但不能有分隔符注释（/ * a & b * /错误）
 */

/* #define,#undef
 * 1、#define 和#undef指令只能用在源文件的第一行，也就是任何c#代码之前（包括using之前）
 * 2、编译符号的范围被限制在单个源文件
 */

/* #line
 * 
 * #line integer //设置下一行值为整数的行号
 * #line "filename"     //设置文件名
 * #line integer "fileName"     //设置行号和文件名
 * #line default        //重新保存实际的行号和文件名
 * 
 * #line hidden         //在断点调试器中隐藏代码
 * #line                //停止在断点调试器中隐藏代码
 */

/* pragma warning（关闭或重新开启警告消息）
 * 
 * #pragma warning disable 618,414（关闭618，414两个错误消息）
 * #pragma warning restore 414（重新打开414消息）
 * #pragma warning disable （关闭所有错误消息）
 * #pragma warning restore （打开所有错误消息）
 * 
 */




#define HelloWorld

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreprocessorPractice
{
    class PreprocessorList
    {
    }
}
