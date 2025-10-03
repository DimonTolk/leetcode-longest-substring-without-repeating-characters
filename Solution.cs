public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        ushort left = 0;
        int max = 0;
        var lastIndex = new ushort[96]; 

        for (ushort right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];
            left = Math.Max(left, lastIndex[currentChar-32]);
			      lastIndex[currentChar-32] = (ushort)(right + 1);
			      max = Math.Max(max, right - left + 1);
		    }  

		    return max;
	  }
}
