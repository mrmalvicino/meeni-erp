using System;

namespace Utilities
{
    public static class Calculator
    {
        public static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Now;
            int age = today.Year - birthDate.Year;

            if (today.AddYears(-age) < birthDate.Date)
            {
                age--;
            }

            return age;
        }

        public static int CountFilledProperties(object obj)
        {
            if (obj == null)
            {
                return 0;
            }

            int count = 0;

            var props = obj.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.PropertyType == typeof(string))
                {
                    var value = (string)prop.GetValue(obj);

                    if (!string.IsNullOrEmpty(value))
                    {
                        count++;
                    }
                }
                else if (!prop.PropertyType.IsPrimitive
                    && !prop.PropertyType.IsEnum
                    && prop.PropertyType != typeof(string))
                {
                    var subObj = prop.GetValue(obj);
                    count += CountFilledProperties(subObj);
                }
            }

            return count;
        }
    }
}
