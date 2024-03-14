using System.Globalization;

var date = new VasyaPage();
date.ShowRealDate();

class VasyaPage
{
    public int day;
    public string month;

    public VasyaPage()
    {
        string input = Console.ReadLine();
        if (!String.IsNullOrEmpty(input))
        {
            var date = input.Split();
            day = int.Parse(date[0]);
            month = date[1];
        }
    }

    public void ShowRealDate()
    {
        int count = 0;
        bool isEqual = false;
        var months = new string[] { "августа", "апреля", "декабря", "июля", "июня", "мая", "марта", "ноября", "октября", "сентября", "декабря" };
        foreach (string mm in months)
        {
            if (isEqual == true) { break; }
            for (int dd = 2; dd < 31; dd += 2)
            {
                count++;
                if (dd == day && mm == month)
                {
                    isEqual = true;
                    break;
                }  
            }
        }
        var nextDateTime = new DateTime().AddDays(count);
        Console.WriteLine(nextDateTime.ToString("M", CultureInfo.GetCultureInfo("ru-RU")));
    }
}