using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        /*
         1. Convert the following from decimal to binary
            • 1                 =   0001
            • 42                =   0010 1010
            • 256               =   0001 0000 0000
            • 4,294,967,296     =   0001 0000 0000 0000 0000 0000 0000 0000 0000
         
         2. Convert the following from binary to decimal
            • 1000 0000          =  128 
            • 1010 1010          =  170
            • 1111 0000          =  240
            • 1100 1100          =  204

         3. Solve these binary arithmetic problems
            • 111 + 111          =  1110
            • 1010 + 1010        =  0001 0100
            • 11101 + 1010       =  0010 0111
            • 1101 - 11          =  1010
            • 10001 - 100        =  1101
            • 101 x 10           =  1010
            • 1011 x 11          =  0010 0001
            • 1101 / 11          =  1000 r1
         4. In many places, numbers stored in computers are displayed as hexadecimal (base 16). What
            advantages do hex numbers have over decimal and binary numbers respectively when
            displaying numbers stored in a computer?

                - Store a larger number as a smaller bit

         5. Using Two's complement convert the following between decimal and binary (for binary use 1
            signed byte)
            • 1000 0000           =   1000 0000 = -128
            • 1010 1010           =   0101 0110 = -86                                           
            • 1111 0000           =   0001 0000 = -16
            • 1100 1100           =   0011 0100 = -52
            • -16                 =   1001 0000 = 1111 0000
            • 128                 =   1000 0000 = 0000 1000 0000
            • -128                =   1000 1000 0000 = 1111 1000 0000
            • -123                =   1000 0111 1011 = 1111 1000 0101

        6. What do each of these evaluate to?
            • 11111 | 11111      =  11111
            • 11111 ^ 11111      =  0
            • 10101 & 11111      =  10101
            • 10101 | 11111      =  11111
            • 00000 ^ 11111      =  11111
            • 1 << 3             =  1000
            • 100 >> 2           =  0001 1001
            • ~10101             =  1010
            • 100 << 1           =  0110 0100
            • 1010 >> 1          =  0101
            • ~11111             =  0

        7. A true/false value can be stored in a single bit – zero for false, one for true. However, the
            Boolean type in C is a full byte big – 8 bits. This means it is possible to store 8 bits in a single
            byte. Using bitwise operators, how might you
                • Set an single bit to 0 - ~ 
                • Set an single bit to 1 - |
                • Check the value of a single bit
        */

        //8. Implement the following functions in C#
        // bool IsLeftMostBitSet(uint value)
        // • Returns true if the left most(the most significant) bit of value is set and
        //   false otherwise
        static class BitUtils
        {
            public static bool IsLeftMostBitSet(uint value)
            {
                Console.WriteLine("INPUT DEBUG: " + Convert.ToString(value, toBase: 2).PadLeft(32, '0'));
                return (value >> 31) == 1;
            }

            //public static bool IsRightMostBitSet(uint value)
            //{
            //    Console.WriteLine("INPUT DEBUG: " + Convert.ToString(value, toBase: 2).PadLeft(32, '0'));
            //    return (value << 31) == 1;
            //}
        }



        // bool IsRightMostBitSet(uint value)
        // • Returns true if the right most(the least significant) bit of value is set and
        //   false otherwise


        // bool IsBitSet(uint value, unsigned char bit_to_check)
        // • Returns true if the asked for bit is set, and false otherwise.bit_to_check is
        //   zero indexed from the right most bit.i.e 0 is the right most bit and 31 is the
        //   left most.


        // int GetRightMostSetBit(uint value)
        // • This function returns the index of the right most bit set to 1 in value
        // • If no bits are set, it returns -1
        // • For example
        //      o 00000001 would return 0
        //      o 10011100 would return 2
        //      o 01010000 would return 4
        //      o 00000000 would return -1


        // void PrintBinary(unsigned byte value)
        // • Prints value to the console as a binary number



        static void Main(string[] args)
        {

            Debug.Assert(BitUtils.IsLeftMostBitSet(uint.MaxValue));
            Debug.Assert(!BitUtils.IsLeftMostBitSet(uint.MinValue));
            Debug.Assert(BitUtils.IsLeftMostBitSet(0b10000000000000000000000000000000));
            Debug.Assert(!BitUtils.IsLeftMostBitSet(0b00000000000000000000000000000000));
            Debug.Assert(!BitUtils.IsLeftMostBitSet(0b00000000000000010000000000000000));

            //Debug.Assert(BitUtils.IsRightMostBitSet(uint.MaxValue));
            //Debug.Assert(!BitUtils.IsRightMostBitSet(uint.MinValue));
            //Debug.Assert(BitUtils.IsRightMostBitSet(0b0000000000000000000000000000001));
            //Debug.Assert(!BitUtils.IsRightMostBitSet(0b00000000000000000000000000000000));
            //Debug.Assert(!BitUtils.IsRightMostBitSet(0b00000000000000010000000000000000));



            Console.Write("\n");
            Console.ReadLine();


        }


    }


    
}
