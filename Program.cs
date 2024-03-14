using System.Globalization;

class VasyaPage
{
    public int day;
    public string month;

    public int GetDaysCount()
    {
        int count = -1;
        var months = new string[] { "августа", "апреля", "декабря", "июля", "июня", "мая", "марта", "ноября", "октября", "сентября", "декабря" };
        foreach (string mm in months)
            for (int dd = 2; dd < 31; dd += 2)
            {
                count++;
                if (dd == day && mm == month)
                    return count;
            }
        return count;
    }

    public void ShowRealDate()
    {
        var nextDateTime = new DateTime().AddDays(GetDaysCount());
        Console.WriteLine(nextDateTime.ToString("M", CultureInfo.GetCultureInfo("ru-RU")));
    }
}