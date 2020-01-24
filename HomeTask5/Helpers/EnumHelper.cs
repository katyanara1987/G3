using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace HomeTask5.Helpers
{
    public class EnumHelper
    {
        public static string PrintEnumDefinition<TEnum>() where TEnum : struct
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Select {typeof(TEnum).Name} from list: ");
            for (int index = 1; index < Enum.GetValues(typeof(TEnum)).Length + 1; index++)
            {
                sb.AppendLine($"{index}. {Enum.GetName(typeof(TEnum), index)}");
            }
            return sb.ToString();
        }

        public static int GetEnumValueAttribute(Enum value)
        {
            // Get the EnumValue attribute value for the enum value
            FieldInfo fi = value.GetType().GetField(value.ToString());
            EnumValueAttribute attribute = (EnumValueAttribute)fi.GetCustomAttribute(typeof(EnumValueAttribute), false);
            return attribute.EnumValue;
        }

        public static TEnum RequestForEnumValue<TEnum>() where TEnum : struct
        {
            TEnum result;
            bool parseResult;
            do
            {
                Console.WriteLine(PrintEnumDefinition<TEnum>());

                string _pr = Console.ReadLine();
                parseResult = Enum.TryParse(_pr, ignoreCase: true, result: out result)
                    & Enum.IsDefined(typeof(TEnum), result);
            } while (!parseResult);
            return result;
        }
    }
}
