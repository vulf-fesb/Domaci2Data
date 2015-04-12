using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNs
{
    public class Date
    {
        private uint day, month, year;

        public Date(uint day, uint month, uint year)
        {
            if (checkDateValidity(day, month, year))
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        private bool checkDateValidity(uint day, uint month, uint year)
        {
            switch(month)
            {
                case 1: 
                case 3:
                case 5: 
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day <= 31)
                        return true;
                    else
                        return false;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day <= 30)
                        return true;
                    else
                        return false;
                case 2:
                    if (isLeapYear(year))
                    {
                        if (day <= 29)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        if (day <= 28)
                            return true;
                        else
                            return false;
                    }
                default:
                    return false;
            }
        }

        private bool isLeapYear(uint year)
        {
            if (year % 400 == 0) return true;
            else if (year % 100 == 0) return false;
            else if (year % 4 == 0) return true;
            else return false;
        }

        public bool isLeapYear()
        {
            return isLeapYear(this.year);
        }
        
        public string getMonthName()
        {
            string monthName = "";

            switch(this.month)
            {
                case 1: 
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
            }

            return monthName;
        }

        public uint getNumberOfRemainingDaysInMonth()
        {
            switch(this.month)
            {
                case 1: 
                case 3:
                case 5: 
                case 7:
                case 8:
                case 10:
                case 12:
                    return (31 - this.day);
                case 4:
                case 6:
                case 9:
                case 11:
                    return (30 - this.day);
                case 2:
                    if (isLeapYear(year))
                    {
                        return (29 - this.day);
                    }
                    else
                    {
                        return (28 - this.day);
                    }
            }

            return 0;
        }
    }
}
