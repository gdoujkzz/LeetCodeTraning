using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AddTwoNumber {
    class Program {
        //static ConnectionMultiplexer redisClient = ConnectionMultiplexer.Connect("localhost");
        static void Main(string[] args) {
            //You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
            //You may assume the two numbers do
            //    not contain any leading zero, except the number 0 itself.
            //第一眼看到这个题目的时候，我想，是时候去补下链表的知识了。
            //链表：一个是数值域，一个是指针域
            //IDatabase db = redisClient.GetDatabase();
            // 测试 key value
            //string value = "abcdefg";
            //db.StringSet("mykey", value);
            //value = db.StringGet("mykey");
            //Console.WriteLine(value);
            // 测试消息队列
            //ISubscriber sub = redisClient.GetSubscriber();
            //sub.Subscribe("messages", (channel, message) => {
            //    Console.WriteLine((string)message);
            //});
            //Thread.Sleep(1000);
            ////sub.Publish("messages", "hello");
            //Thread.Sleep(1000);
            //sub.Subscribe("redisMessages", (channel, message) => {
            //    Console.WriteLine((string)message);
            //});
            //sub.Publish("redisMessages", "This message from C# program");


        }
        
    }
}
