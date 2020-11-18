using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GetBuffer
{
    class Program
    {
        [DllImport("CDynamicLibGetbuffer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe byte* GetImgBuffer(string p_imgName, ref int i_Size, ref int i_Width, ref int i_Height, byte* p_buffer);
        [DllImport("CDynamicLibGetbuffer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern unsafe byte* FreeImgBuffer(byte* p_buffer);

        static void Main(string[] args)
        {
            unsafe
            {
                byte* imgBuffer = null;
                string imgName = "F:/DL/data/test.jpg";
                Console.WriteLine(imgName);
                int i_Size = 0;
                int i_Width = 0;
                int i_Height = 0;

                imgBuffer = GetImgBuffer(imgName, ref i_Size, ref i_Width, ref i_Height, imgBuffer);

                Console.WriteLine("Read Buffer Over!!");
                Console.WriteLine(imgBuffer[0]);
            }

        }
    }
}
