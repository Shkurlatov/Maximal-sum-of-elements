using System;
using System.Reflection;

namespace SumProject
{
    public enum Messages
    {
        [StringValue("\nFile path does not exist!")]
        WrongArgsPath,
        [StringValue("\nPlease, enter file path or enter 0 for using example content file.")]
        PathInputRequest,
        [StringValue("\nExample content file not found!")]
        ExampleNotFound,
        [StringValue("\nFile does not exist! Please, enter correct file path or enter 0 for using example content file.")]
        WrongInputPath,
        [StringValue("\nString number {0} has a maximum sum of elements.\n")]
        MaxLineNumber,
        [StringValue("String number {0} is incorrect!")]
        FalseLinesNumbers,
        [StringValue("Content does not exist.")]
        FileEmpty,
    }

    public class StringValue : Attribute
    {
        public string Value { get; private set; }

        public StringValue(string value)
        {
            Value = value;
        }
    }

    public static class ExtensionMethods
    {
        public static string GetString(this Enum value)
        {
            string stringValue = value.ToString();
            Type type = value.GetType();
            FieldInfo fieldInfo = type.GetField(value.ToString());
            StringValue[] attrs = fieldInfo.
                GetCustomAttributes(typeof(StringValue), false) as StringValue[];
            if (attrs.Length > 0)
            {
                stringValue = attrs[0].Value;
            }
            return stringValue;
        }
    }
}
