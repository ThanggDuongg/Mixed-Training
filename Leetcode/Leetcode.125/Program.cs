using System.Text.RegularExpressions;

bool IsPalindrome(string s)
{
    var handled = (new Regex("[^a-zA-Z0-9]+")).Replace(s, "");
    return handled.ToLower() == new string(handled.ToCharArray().Reverse().ToArray()).ToLower();
}

var test = IsPalindrome("A man, a plan, a canal: Panama");