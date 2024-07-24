public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int n = nums.Length;
        int i = 0;

        foreach(var item in nums) {
            
            bool c = i>=2 &&  item == nums[i-2];
            if (!c) {
                nums[i++] = item;
            }
        }
        return i;
    }
}