public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int product=1;
        bool c = false;
        int[] res = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0 && !c) {
                c = !c;
                continue;
            }
            product*=nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = (nums[i] == 0)?product : (c)?0 : product/nums[i];
        }
        
        return res;
    }
}