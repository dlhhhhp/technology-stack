using System;

namespace a0101_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var systemOut = true;
            while (systemOut)
            {
                Console.WriteLine("请选择队列：1.定长环形数组队列 2.**** 3.***** 0.退出");
                switch (Console.ReadLine())
                {
                    case "1":
                        var arrayOne = new QueueFixedLengthArray<string>();
                        var outOne = true;
                        var counter = 0;
                        while (outOne)
                        {
                            Console.WriteLine("定长环形数组：" + arrayOne.PrintQueue());
                            Console.WriteLine("请选择操作：1.入队 2.出队 0.退出");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    arrayOne.Enqueue("数据" + (counter++));
                                    break;
                                case "2":
                                    arrayOne.Dequeue();
                                    break;
                                case "0":
                                    outOne = false;
                                    break;
                                default: break;
                            }
                        }
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        systemOut = false;
                        break;
                    default: break;
                }

            }
        }
    }
}
