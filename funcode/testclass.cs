using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcode
{
    public class Solution
    {

        //Given nums = [2, 7, 11, 15], target = 9,

        //Because nums[0] + nums[1] = 2 + 7 = 9,
        //return [0, 1].
        public int TwoSum(int[] nums, int target)
        {
            int[] a = new int[2];
            
            for (int i = 0; i <=nums.Length-1; i++)
             {                                              
                for (int b = 0; b <= nums.Length-1; b++)
                {
                                            
                    if (nums[i] + nums[b] == target)
                    {
                        a[0] = nums[i];
                        a[1] = nums[b];
                        return 9;

                    }
                }
            }

            return 0;
        }


        public string REST(string INPO)
        {


            INPO = "A";
            return INPO;

        }



    }
}       