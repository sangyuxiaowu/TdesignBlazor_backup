using System;
using System.ComponentModel;

namespace RazorTdesign.Components
{
    //Source: https://stackoverflow.com/questions/630803/associating-enums-with-strings-in-c-sharp
    /*
     * usage EnumType myLocal = EnumType.V1;
     * print(myLocal.ToDescriptionString()); 
     */
    public static class EnumExtensions
    {

        public static string ToDescriptionString<TEnum>(this TEnum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
