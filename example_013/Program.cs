string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = count - 1; i >= 0; i--)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
