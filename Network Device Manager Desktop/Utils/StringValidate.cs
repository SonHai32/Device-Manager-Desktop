using System;
using System.Text.RegularExpressions;

namespace Network_Device_Manager_Desktop.Utils
{
    public class StringValidate
    {
        public bool IsInteger(string val)
        {
            Regex regex = new Regex("[0-9]");
            return regex.IsMatch(val);
        }

        public bool IsFloat(string val)
        {
            Regex regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            return regex.IsMatch(val);
        }

        public bool GreaterThan(double value, double greaterThan)
        {
            return value > greaterThan; 
        }
    }
}
