using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 只出现一次的数字 {
    class Program {
        static void Main(string[] args)
        {
            //只出现一次的数字。
            var arr = new int[9] {1, 2, 3, 3, 1, 4, 5, 4, 5};
            //找出只出现一次的数字。
            //想法一:利用另外一个数组来记录出现的次数。从而实现。
            //var intList = new List<BaseIntInfo>();
            //for (var i = 0; i < arr.Length; i++){
            //    var temp=new BaseIntInfo(){Times =1,Value =arr[i]};
            //}

            //我怎么搞都是要两层循环才能搞出来。
            {
             var oneTimesNum = arr[0];
            for (var i = 0; i < arr.Length; i++)
            {
                var flag = false;
                var num = 0;
                for (var j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        num++;
                    }
                    if (num >= 2)
                    {
                        break;
                    }
                }
                if (num == 1)
                {
                    oneTimesNum = arr[i];
                }
            }
                Console.WriteLine("没有出现重复数字为:" + oneTimesNum);
            }

            //上面的算法，循环次数太多了，想办法减少循环。
            //上面这个不叫算法哈，普通人都可以搞清楚的，接下来的想法是先给数组排一下顺序。
            //第二种做法是先排序嘛。
            //{
            //    var oneTimesNum = arr[0];
            //    Array.Sort(arr);
            //    for (int i = 0; i < arr.Length; i=i+2){
            //        if (i + 1 > arr.Length){ //这里要以步数为二的进行遍历。
            //            oneTimesNum=arr[i];
            //            break;
            //        }
            //        if (arr[i] != arr[i + 1]){
            //            oneTimesNum = arr[i];
            //            break;
            //        }
            //    }
            //    Console.WriteLine("没有出现重复数字为:" + oneTimesNum);
            //}
            //第三种做法是利用异或运算。
            //&两者为真的时候，才同时为真。
            //0010 0100
            //& 
            //0010 0100
            //=
            //0010 0100 
            //相同数字做&运算，会得到相同的数字。
            //| 运算两者一真就为真
            //0010 0100
            //|
            //0010 0100
            //=
            //0010 0100
            //由上可知，两个数字做|运算会得到相同数字
            //^相同为假，不同为真
            //0010 0100
            //^
            //0010 0100
            //=
            //0000 0000
            //相同数字做异或运算，会得到零。
            //由此可以知道，若存在一个数字，只出现一次，那么该数组所有元素的异或结果大于0.
            //一个整数和它本身异或后得到的值是零，零与其他整数异或得到是这个数的本身。
            {

                var oneTimesNum =0;
                //for(int i:arr)
                //{
                //    oneTimesNum ^= i;
                //}
                for (var i = 0; i < arr.Length; i++) {
                    oneTimesNum = oneTimesNum ^ arr[i];
                    Console.WriteLine(oneTimesNum);
                }
                Console.WriteLine("没有出现重复数字为:" + oneTimesNum);
            }


          
            Console.ReadKey();

        }
    }

    public class BaseIntInfo
    {
        public int Times { get; set; }

        public int Value { get; set; }
    }
}
