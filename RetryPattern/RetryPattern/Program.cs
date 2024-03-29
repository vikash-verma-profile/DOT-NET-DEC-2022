﻿using System;

namespace RetryPattern
{
    //Retry Pattern in c#
    internal class Program
    {
        static async Task Main1(string[] args)
        {
            /*
             * RetryTimes=3
             * WaitTime=500
             * for()
             * {
             * }
             */
            Console.WriteLine("Main Method started");
            await RetryMethod();
            Console.WriteLine("Main Method End");
        }
        // Retry(Fun<Task>,int RetryTimes,int WaitTime)

        public static async Task Retry(Func<Task> fun, int RetryTimes, int WaitTime)
        {
            for (int i = 0; i < RetryTimes; i++)
            {
                try
                {
                    await fun();
                    Console.WriteLine("Operation Successful");
                    break;
                }catch(Exception ex)
                {

                    Console.WriteLine($"Retry {i + 1}: Geting Exception : {ex.Message}");
                    await Task.Delay(WaitTime);
                }
               
            }
            //final try ro execute the operation
            await fun();
        }
        public static async Task RetryMethod()
        {
            var RetryTimes = 3;
            var WaitTime = 500;
            for (int i = 0; i < RetryTimes; i++)
            {
                try
                {
                    await DoSomeOperation();
                    Console.WriteLine("Operation Successful");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Retry {i+1}: Geting Exception : {ex.Message}");
                    await Task.Delay(WaitTime);
                }
            }
        }
        public static async Task DoSomeOperation()
        {
            //Doing Some Processing
            await Task.Delay(500);
            throw new Exception("Exception Occured while Processing/operation");
        }
    }
}