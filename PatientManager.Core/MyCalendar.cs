using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManager.Core
{
    public class MyCalendar
    {
        private List<string> months = new List<string>() { "Styczeń", "Luty", "Marzec", "Kwiecien", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesien", "Październik", "Listopad", "Grudzień" };
        private List<int> years;

        public List<string> Months
        {
            get { return months; }
        }
        public List<int> Years
        {
            get { return years; }
        }

        public MyCalendar() : this(DateTime.Now.Year)
        {
        }

        public MyCalendar(int year)
        {
            years = new List<int>();
            int i = 2022;
            while (i < year + 5)
            {
                years.Add(i);
                i++;
            }
        }

        public int GetCurrentMonth()
        {
            return DateTime.Now.Month - 1;
        }

        public string GetMonth(int month)
        {
            return months[month-1];
        }

        public int GetCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }
}
