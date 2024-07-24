public class Solution {
    public String[] Split(String s, Char delemiter) {
        List<String> lst = new List<string>();
    
        int left= 0;
        int right = -1;
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == delemiter ){
                if ( right >= left) {
                    lst.Add(s.Substring(left, right-left+1));
                }
                left = i+1;
            }
            else if (i == n-1) {
                lst.Add(s.Substring(left, n-left));
            }
            else {
                right = i;
            }
        }
        
        return lst.ToArray();
    }

    public  String ReverseWords(String s) {
        String[] splitted_string = this.Split(s, ' ');
        // two pointers 
        int left=0;
        int right = splitted_string.Length-1;
        String tmp;
        while (left < right) {
            tmp = splitted_string[left];
            splitted_string[left] = splitted_string[right];
            splitted_string[right] = tmp;
            left++;
            right--;
        }
        return String.Join(' ', splitted_string);
    }
}