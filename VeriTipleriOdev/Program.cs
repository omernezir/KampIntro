using System;

namespace VeriTipleriOdev
{
    class Program
    {
       

        static void Main(string[] args)
        {   //byte 0  ve 255 arası tamsayı
            byte byte1 = 255;
            //sbyte -128  ve 127 arası tamsayı
            sbyte sbyte1 = 125;
            short short1 = 23155;
            ushort ushort1 = 65100;
            int int1 = -999999999;
            uint uint1 = 999999;
            long long1 = -99999999999999999;
            ulong ulong1 = 99999999999999999;
            float float1 = (float)1.5;

            //double double1 = 52866555.46;
            decimal decimal1 = (decimal)-154.9999;
            char char1 = 'O';
            string string1 = "string boyutu sınırsız";
            bool bool1 = false;
            var var1 = "ömer";
            object object1 = 34345.4343434353535;

            DateTime dateTime1 = DateTime.Today;
            DateTimeOffset dateTimeOffset1 = DateTimeOffset.Now;

            Console.WriteLine("byte 0  ve 255 arası tamsayıları tutar.\n" +"byte1: " +byte1);
            Console.WriteLine("sbyte -128  ve 127 arası tamsayıları tutar.\n" + "sbyte1: " + sbyte1);
            Console.WriteLine("short -32768  ve 32767 arası tamsayıları tutar.\n" + "short1: " + short1);
            Console.WriteLine("ushort -32768  ve 32767 arası tamsayıları tutar.\n" + "ushort1: " + ushort1);
            //Console.WriteLine(float1);??
            Console.WriteLine(float1);
            Console.WriteLine(decimal1);
            Console.WriteLine(char1);
            Console.WriteLine(string1);
            Console.WriteLine(var1);
            Console.WriteLine(dateTime1);








        }
    }
}
