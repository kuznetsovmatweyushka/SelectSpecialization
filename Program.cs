string[] array = new string[5] { "hello", "world", "im", "a", "programmer" };
int count = 0;
string[] SelectStringsLessThen3(string[] array)
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3) count++;
        i++;
    }