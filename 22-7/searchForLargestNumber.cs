class Solution{
    public static  void SortForLargestNumber(int[] nums) {
        int n = nums.Length;
        int tmp;
        String x1;
        String x2;
        for(int j=0;j<n-1;j++) {
            for (int i = j+1; i <n; i++)
            {   
                tmp = nums[j];
                x1 = nums[j].ToString()+nums[i].ToString();
                x2 = nums[i].ToString()+nums[j].ToString();
                if (BigInteger.Parse(x2) > BigInteger.Parse(x1)) {
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }
    }
}