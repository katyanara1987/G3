using System;

namespace HomeTask8.Enums
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