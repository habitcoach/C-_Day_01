using System;

namespace day_1_conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Implicit casting from int to double
            //int intValue = 42;
            //double doubleValue = intValue; // The compiler automatically converts int to double

            //// Implicit casting from char to int
            //char charValue = 'A';
            //int intValue01 = charValue; // The ASCII value of 'A' is 65, which is implicitly converted to int

            //// Explicit casting from double to int
            //double doubleValue02 = 3.14;
            //int intValue02 = (int)doubleValue; // The fractional part will be truncated, and intValue will be 3

            //// Explicit casting from int to byte
            //int intValue03 = 300;
            //byte byteValue = (byte)intValue; // The value will be truncated to fit in a byte, and byteValue will be 44


            //// Convert class for converting string to int

            char strValue = 'a';
            int intValue04 = Convert.ToInt32(strValue);
            Console.WriteLine(intValue04);


            //// Convert class for converting int to string
            //int intValue05 = 42;
            //string strValue01 = Convert.ToString(intValue);


            //// Parse
            //string strValue02 = "42";
            //int intValue06 = int.Parse(strValue);

            #region method
            //// TryParse (safer method to handle conversion errors)
            //string strValue03 = "42";
            //if (int.TryParse(strValue03, out int intValue07))
            //{
            //    // Conversion successful, and intValue contains the converted value
            //}
            //else
            //{
            //    // Conversion failed, handle the error accordingly
            //}

            #endregion

            //// Boxing
            //int intValue_ = 42;
            //object boxedValue = intValue; // Implicit boxing

            //// Unboxing
            //object boxedValue_ = 42;
            //int _intValue = (int)boxedValue; // Explicit unboxing


        }
    }
}

