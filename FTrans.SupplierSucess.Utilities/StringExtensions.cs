using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTrans.SupplierSuccess.Utilities
{
    public static class StringExtensions
    {
        public static int ToInterger(this string Value, int DefaultValue = 0)
        {
            return ConvertToInt(Value, DefaultValue);
        }
        public static string ToDateTimeFormat(this string Value)
        {
            //2015/07/16
            string[] splitDate = Value.Split('/');
            string formattedDate = splitDate[1] + "/" + splitDate[2] + "/" + splitDate[0];
            return formattedDate;
        }
        public static decimal ToDecimal(this string Value, decimal DefaultValue = 0)
        {
            decimal i = 0;
            var result = decimal.TryParse(Value, out i);

            if (result)
                return i;
            else
                return DefaultValue;
        }

        public static DateTime ToDateTime(this string Value)
        {
            DateTime i = DateTime.MinValue;
            var result = DateTime.TryParse(Value, out i);

            if (result)
                return i;
            else
                return i;
        }

        public static int ConvertToInt(string Value, int DefaultValue = 0)
        {
            int i = 0;
            var result = int.TryParse(Value, out i);

            if (result)
                return i;
            else
                return DefaultValue;
        }

        public static Guid ToGuid(this string Value, Guid DefaultValue = default(Guid))
        {
            return ConvertToGuid(Value, DefaultValue);
        }

        public static Guid ConvertToGuid(string Value, Guid DefaultValue = default(Guid))
        {
            Guid item = DefaultValue;
            var result = Guid.TryParse(Value, out item);

            if (result)
                return item;
            else
                return DefaultValue;
        }

        public static byte[] ToByteArray(this string Value)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Value);
            return bytes;
        }

        public static string Mask(this string Value, int index, char Maskcharacter = '*')
        {
            if (Value == null)
            {
                return "";
            }
            if (Value.Length < index)
            {
                return "".PadLeft(index, Maskcharacter);
            }
            else
            {
                var len = Value.Length;
                string str = Value.Substring(len - index, index);

                return str.PadLeft(len, Maskcharacter);
            }
        }

        /// <summary>
        /// Formats the phone number us.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static string FormatPhoneNumberUS(this string value)
        {
            if (value != null)
                value = value.Substring(0, 3) + "-" + value.Substring(3, 3) + "-" + value.Substring(6);
            return value;
        }
    }
}
