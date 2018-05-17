using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 旋转数组 {
    class Program {
        static void Main(string[] args) {
            //给定一个数组，将数组中的元素向右移动 k 个位置，其中 k 是非负数。
            //尽可能想出更多的解决方案，至少有三种不同的方法可以解决这个问题。
            //要求使用空间复杂度为 O(1) 的原地算法。
            //旋转数组的解法有很多。
            //解法一:求余法。
            var nums =new int[]{1,3,4,6,7,9};
            var k = 3;
            //{
            //    var newNums = new int[nums.Length];
            //    for (var i = 0; i < nums.Length; i++)
            //    {
            //        var index = (i + k) % nums.Length;
            //        newNums[index] = nums[i];
            //    }
            //    foreach (var tNewNum in newNums)
            //    {
            //        Console.WriteLine(tNewNum);
            //    }
            //}
            //解法二:反转法
            {
                var nums1 = new int[nums.Length - k];
                var nums2 = new int[k];
                for (var f = 0; f < nums.Length; f++){
                    if (f +k < nums.Length){
                        nums1[f] = nums[f];
                    }
                    else{
                       nums2[Math.Abs(nums.Length-k-f)]=nums[f];
                    }
                }
                var newNums = nums2.Concat(nums1);
                foreach (var tNewNum in newNums)
                {
                    Console.WriteLine(tNewNum);
                }
            }
            //解法三:在解法一的基础上，增加一个temp变量来搞。
            //{
            //    //提高效率的方法，看看怎么提高先。
            //            //var newNums = new int[nums.Length];
            //            for (var i = 0; i < nums.Length; i++){
            //               var index = (i + k) % nums.Length;
            //               int temp = nums[index];
            //               nums[index] = nums[i];
            //               //这个要怎么减少呢。
            //            }
                
            //}
            //做完这些题目之后，以后向右偏移，或者旋转了多少的题目，可以通过元素位置+偏移或旋转步数模与数组长度就可以得到偏移或者旋转之后的元素位置。
            Console.ReadKey();

        }
    }

 
}
