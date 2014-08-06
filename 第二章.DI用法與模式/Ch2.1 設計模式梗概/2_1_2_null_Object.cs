using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch2._1_設計模式梗概
{
    class _2_1_2_null_Object
    {
    }


    class 沒有使用nullObject的情況
    {
        public void normorNullObjectCheck()
        {
            String anObject = string.Empty;

            if (anObject != null)
            {
                // Do SomeThing 
                anObject.Substring(0);
            }
            else
            {
                // Do SomeThing Else.
                //anObject.Substring();
            }

        }
    }

    //    用 Logger 來示範 null Object 機制


    public interface ILogger
    {
        void Log(string msg);
    }


    public class NullLogger : ILogger
    {
        public void Log(string msg)
        {
            // 不做任何事情
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }


    public class TheClientApp
    {
        void DoSomething(ILogger logger)
        {
            logger.Log("開始執行 DoSomething 函式。");


        }

    }


}
