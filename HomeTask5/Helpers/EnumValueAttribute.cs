using System;

namespace HomeTask5.Helpers
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EnumValueAttribute : Attribute
    {
        public EnumValueAttribute(int value)
        {
            EnumValue = value;
        }

        public int EnumValue { get; }
    }
}
