namespace Fandamentals
{
    public static class ParseStrings
    {
        public static (int, bool, double) ParseStringValues(string input)
        {
            // Assume the input is formatted as "integer,bool,decimal"
            // Example input: "42,true,3.14"

            var parts = input.Split(',');

            if (parts.Length != 3)
            {
                throw new ArgumentException("Input string must have exactly three parts separated by commas.");
            }

            if (!int.TryParse(parts[0], out int integerValue))
            {
                throw new FormatException("The first part of the string must be a valid integer.");
            }

            if (!bool.TryParse(parts[1], out bool boolValue))
            {
                throw new FormatException("The second part of the string must be a valid boolean.");
            }

            if (!double.TryParse(parts[2], out double doubleValue))
            {
                throw new FormatException("The third part of the string must be a valid double.");
            }

            return (integerValue, boolValue, doubleValue);
        }


        public static DateTime ParseStringToDate(string input)
        {
            // Example input: "2023-10-15"
            if (!DateTime.TryParse(input, out DateTime dateValue))
            {
                throw new FormatException("The input string must be a valid date.");
            }

            return dateValue;
        }


        public static T ConvertStringToEnum<T>(string input) where T : struct, Enum
        {
            if (!Enum.TryParse(input, true, out T result))
            {
                throw new ArgumentException($"The input string '{input}' is not a valid value for the enum {typeof(T).Name}.");
            }

            return result;
        }


        public static T ConvertStringToStruct<T>(string input) where T : struct
        {
            if (!typeof(T).IsValueType || (!typeof(T).IsPrimitive && !typeof(T).IsEnum))
            {
                throw new ArgumentException("The type must be a valid struct or value type.");
            }

            var result = Activator.CreateInstance<T>();

            int index = 0;
            foreach (var field in typeof(T).GetFields())
            {
                if (index >= input.Length)
                {
                    break;
                }

                object value;
                if (field.FieldType == typeof(int))
                {
                    value = int.Parse(input.Substring(index, sizeof(int)));
                }
                else if (field.FieldType == typeof(double))
                {
                    value = double.Parse(input.Substring(index, sizeof(double)));
                }
                else if (field.FieldType == typeof(bool))
                {
                    value = bool.Parse(input.Substring(index, sizeof(bool)));
                }
                else
                {
                    // Handle other field types as needed
                    throw new NotSupportedException("Field type not supported.");
                }

                field.SetValue(result, value);
                index += System.Runtime.InteropServices.Marshal.SizeOf(field.FieldType);
            }

            return result;
        }


        public static T ConvertStringToObject<T>(string input) where T : class, new()
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input string cannot be null or whitespace.");
            }

            var result = new T();
            var fields = typeof(T).GetFields();
            var properties = typeof(T).GetProperties();

            var parts = input.Split(',');

            if (fields.Length + properties.Length != parts.Length)
            {
                throw new ArgumentException("The input string does not match the number of fields/properties in the target type.");
            }

            int index = 0;

            foreach (var field in fields)
            {
                object value = ConvertToType(parts[index], field.FieldType);
                field.SetValue(result, value);
                index++;
            }

            foreach (var property in properties)
            {
                if (property.CanWrite)
                {
                    object value = ConvertToType(parts[index], property.PropertyType);
                    property.SetValue(result, value);
                    index++;
                }
            }

            return result;
        }

        private static object ConvertToType(string value, Type targetType)
        {
            if (targetType == typeof(int))
            {
                return int.Parse(value);
            }

            if (targetType == typeof(double))
            {
                return double.Parse(value);
            }

            if (targetType == typeof(bool))
            {
                return bool.Parse(value);
            }

            if (targetType == typeof(string))
            {
                return value;
            }

            throw new NotSupportedException($"Conversion to type {targetType.Name} is not supported.");
        }
    }
}