// var result = new Solution().IsPalindrome(1221);
// Console.WriteLine(result);

public partial class Solution 
{
    public bool IsPalindrome(int x)
    {
        if(x < 0) return false;
        if(x < 10) return true;
        if(x % 10 == 0) return false;

        var arr = x.ToString().ToCharArray();
        Array.Reverse(arr);
        return x.ToString() == new string(arr);
    }
}