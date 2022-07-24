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
    string[] selectedarr = new string[count];
    int k = 0;
    int n = 0;
    while (k < array.Length)
    {
        if (array[k].Length <= 3)
        {
            selectedarr[n] = array[k];
            n++;
        }
        k++;
    }
    return selectedarr;
}