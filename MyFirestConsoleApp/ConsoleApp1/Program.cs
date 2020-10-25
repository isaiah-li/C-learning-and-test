using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("wo shi chubujin");

            byte[] testbuffer = new byte[] { 0xa, 0x02, 0x03, 0x11, 0x05, 0x12, 0x03 };
            //int[] test1 = new int[] { 1, 2, 5, 3, 6, 4 };
            int size = testbuffer.Length;
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(testbuffer, 0, buffer, size);
                //return buffer;
            }
            catch (Exception e)

            {

                Console.WriteLine("{0} Second exception.", e.Message);

            }
            //IntPtr buffer;

            string s = Marshal.PtrToStringAnsi(buffer);

            Console.WriteLine("string is {0}", s);

            //IntPtr buffer1 = Marshal.AllocHGlobal(size);
            
            //Marshal.StructureToPtr(structObj, buffer1, false);
            byte[] bytes = new byte[size];
            Marshal.Copy(buffer, bytes, 0, size);
                
            

            int myi = (int)buffer;
            //MessageBox.Show(myi.ToString());

            //buffer = BytesToIntptr(testbuffer);

            //IntPtr buffer = new IntPtr[50];
        }
        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

        public static IntPtr BytesToIntptr(byte[] bytes)
        {
            int size = bytes.Length;
            IntPtr buffer = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(bytes, 0, buffer, size);
                return buffer;
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

    }


}
