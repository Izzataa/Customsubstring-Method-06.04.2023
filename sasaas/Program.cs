


string surname = "Abdullayev";
string result = CustomSubstring(surname, 0,10);
Console.WriteLine(result); 

static string CustomSubstring(string data, int startIndex, int endIndex)
{
    try
    {
        string substring = "";
        for (int i = startIndex; i < endIndex; i++)
        {
            substring += data[i];
        }
        return substring;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Xəta baş verdi: " + ex.Message);
        return "";
    }
}