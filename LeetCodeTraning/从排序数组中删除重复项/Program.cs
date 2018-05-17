using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 从排序数组中删除重复项 {
    class Program {
        static void Main(string[] args) {
            //给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。

            //不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
            //给定 nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4],

            #region 方法一
            {
                //var nums = new int[] {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
                //var noRepeatNums = new List<int>();
                ////数组去重复
                //for (var i = nums.Length - 1; i >= 0; i--)
                //{
                //    if (!noRepeatNums.Contains(nums[i]))
                //    {
                //        noRepeatNums.Add(nums[i]);
                //    }
                //}
                //Console.WriteLine(noRepeatNums.Count);
            }

            #endregion

            #region 方法二
            {
                Stopwatch sw=new Stopwatch();
                sw.Start();
                var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
                var a = 0;
                for (var i = 1; i < nums.Length; i++) {
                    if (nums[i] != nums[a]) {
                        nums[++a] = nums[i]; //这里++a和a++是不一样的。切记这种有赋值操作的。
                    }
                }
                sw.Stop();
                Console.WriteLine(sw.Elapsed.TotalMilliseconds);
                Console.WriteLine(a + 1);
            }
            //double t1 = GetRuningTime(Method1);
            //double t2 = GetRuningTime(Method2);
            //数组去重复，先排序，排好序之后，再用快慢指针。
            //Console.WriteLine(GetRuningTime(Method1));
            //Console.WriteLine(GetRuningTime(Method1));
            #endregion
            //这个会占用额外的空间，并且还不是O(1)
            Console.ReadKey();
        }

        static int Method1(){
            var nums = GetNums1();
            var noRepeatNums = new List<int>();
           
            for (var i = nums.Length - 1; i >= 0; i--) {
                if (!noRepeatNums.Contains(nums[i])) {
                    noRepeatNums.Add(nums[i]);
                }
            }
            return noRepeatNums.Count;
        }

        static int Method2(){
            var nums = GetNums2();
            var a = 0;
            for (var i = 1; i < nums.Length; i++) {
                if (nums[i] != nums[a]) {
                    nums[++a] = nums[i]; //这里++a和a++是不一样的。切记这种有赋值操作的。
                }
            }
            return a + 1;
        }

        static double GetRuningTime(NoParaReturnInt func){
            Stopwatch sw=new Stopwatch();
            sw.Start();
            int i=func();
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        static int[] GetNums1(){
            var nums = new int[100000];
            for (var i = 0; i < nums.Length; i++){
                nums[i] = i/2;
            }
            return nums;
        }

        static int[] GetNums2(){
            var nums = new int[100000];
            for (var i = nums.Length-1; i >=0; i--) {
                nums[i] = i / 2;
            }
            return nums;
        }
        public delegate int NoParaReturnInt();

    }


}
