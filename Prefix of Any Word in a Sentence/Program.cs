class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(IndexOfPerfix("i you eating burger", "burg")); //output=4
        Console.WriteLine(IndexOfPerfix("this problem is an easy problem","pro")); //output=2
        Console.WriteLine(IndexOfPerfix("i am tired", "you")); //output=-1
    }
    public static int IndexOfPerfix(string s, string t)
    {
        string[] words = s.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].StartsWith(t))
            {
                return i + 1;
            }
        }
        return -1;
    }
}