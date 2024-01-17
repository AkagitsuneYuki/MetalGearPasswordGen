using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGPG
{
    internal class Password
    {
        //Snake's rank, must be 1, 2, 3, or 4, else the code is invalid
        private int rank;
        public int Rank { 
            get { return rank; }
        }


#region Character Conversion
        /// <summary>
        /// Converts a number to the character it represents in the password.
        /// </summary>
        /// <param name="num">The number to convert</param>
        /// <returns>The character that the number represents</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the number isn't within the valid range</exception>
        public char BitsToDigit(int num)
        {
            //it's probably better to use an enum for this, but I couldn't figure out how to get it working with the right names
            switch (num)
            {
                //if the number isn't in the list, throw an exception
                default:
                    throw new ArgumentOutOfRangeException("Invalid number! Must be between 0 and 31, inclusive");
                //the actual numbers we need
                case 0:
                    return '1';
                case 1:
                    return '2';
                case 2:
                    return '3';
                case 3:
                    return '4';
                case 4:
                    return '5';
                case 5:
                    return '6';
                case 6:
                    return 'A';
                case 7:
                    return 'B';
                case 8:
                    return 'C';
                case 9:
                    return 'D';
                case 10:
                    return 'E';
                case 11:
                    return 'F';
                case 12:
                    return 'G';
                case 13:
                    return 'H';
                case 14:
                    return 'I';
                case 15:
                    return 'J';
                case 16:
                    return 'K';
                case 17:
                    return 'L';
                case 18:
                    return 'M';
                case 19:
                    return 'N';
                case 20:
                    return 'O';
                case 21:
                    return 'P';
                case 22:
                    return 'Q';
                case 23:
                    return 'R';
                case 24:
                    return 'S';
                case 25:
                    return 'T';
                case 26:
                    return 'U';
                case 27:
                    return 'V';
                case 28:
                    return 'W';
                case 29:
                    return 'X';
                case 30:
                    return 'Y';
                case 31:
                    return 'Z';
            }
        }

        /// <summary>
        /// Converts a character to the number it represents in the password.
        /// </summary>
        /// <param name="digit">The character to convert.</param>
        /// <returns>The number the character encodes.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If the character is invalid</exception>
        public int DigitToBits(char digit)
        {
            //if the digit is a letter and lowercase, convert it to uppercase
            if (char.IsLetter(digit) && char.IsLower(digit))
            {
                digit = char.ToUpper(digit);
            }

            //again, probably better to use enums, but whatever.
            switch (digit)
            {
                //if the digit isn't between 1 and 6, or a letter from a to z, throw exception
                default:
                    throw new ArgumentOutOfRangeException("Invalid digit! Must be a number between 1 and 6, inclusive, or a letter from A to Z!");
                //the actual chars we need
                case '1':
                    return 0;
                case '2':
                    return 1;
                case '3':
                    return 2;
                case '4':
                    return 3;
                case '5':
                    return 4;
                case '6':
                    return 5;
                case 'A':
                    return 6;
                case 'B':
                    return 7;
                case 'C':
                    return 8;
                case 'D':
                    return 9;
                case 'E':
                    return 10;
                case 'F':
                    return 11;
                case 'G':
                    return 12;
                case 'H':
                    return 13;
                case 'I':
                    return 14;
                case 'J':
                    return 15;
                case 'K':
                    return 16;
                case 'L':
                    return 17;
                case 'M':
                    return 18;
                case 'N':
                    return 19;
                case 'O':
                    return 20;
                case 'P':
                    return 21;
                case 'Q':
                    return 22;
                case 'R':
                    return 23;
                case 'S':
                    return 24;
                case 'T':
                    return 25;
                case 'U':
                    return 26;
                case 'V':
                    return 27;
                case 'W':
                    return 28;
                case 'X':
                    return 29;
                case 'Y':
                    return 30;
                case 'Z':
                    return 31;
            }
        }
#endregion

    }
}
