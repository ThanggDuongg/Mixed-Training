string ReverseWords(string s)
{
    var arr = s.Split(" ").Where(x => !string.IsNullOrEmpty(x)).ToArray();
    Array.Reverse(arr);
    return string.Join(" ", arr);
}


var result = ReverseWords("the sky is blue");
    result = ReverseWords("  hello world  ");    
    result = ReverseWords("a good   examples");