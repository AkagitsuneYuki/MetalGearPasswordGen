using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGPG
{
    internal class Password
    {

        public Password()
        {
            rank = 1;
        }

        #region Equipment
        public struct Equipment
        {
            public bool card1;
            public bool card2;
            public bool card3;
            public bool card4;
            public bool card5;
            public bool card6;
            public bool card7;
            public bool card8;
            public bool cigarettes;
            public bool gasmask;
            public bool binoculars;
            public bool cardboard;
            public bool bbSuit;
            public bool uniform;
            public bool googles;
            public bool glove;
            public bool detector;
            public bool armor;
            public bool antenna;
            public bool antidote;
            public bool light;
            public bool compass;
            public bool oxygen;
            public bool transmitter;
            public bool ration;
            public int rations;
        }
        
        public Equipment equipment = new Equipment();
        #endregion

        #region Weapons
        public enum WeaponID
        {
            HandGun,
            Mines,
            Explosives,
            Missiles,
            MachineGun,
            Grenades,
            Rockets,
            Silencer
        }

        public struct Weapon
        {
            public bool obtained;
            public int ammoCount;
        }

        public Weapon[] weapons = new Weapon[8];

        public void SetWeaponAmmoCount(int id, int count)
        {
            try
            {
                weapons[id].ammoCount = count;
            }
            catch
            {

            }
        }

        public void SetWeaponObtained(int id, bool obtained)
        {
            try
            {
                weapons[id].obtained = obtained;
            }
            catch
            {

            }
        }
        #endregion

        #region Rank
        //Snake's rank, must be 1, 2, 3, or 4, else the code is invalid
        private int rank;
        public int Rank
        {
            get { return rank; }
        }

        public void SetRank(int newRank)
        {
            if (newRank < 1 || newRank > 4)
            {
                throw new ArgumentException("Invalid rank! Must be 1, 2, 3, or 4!");
            }
            rank = newRank;
        }
        #endregion

        #region Bosses
        public enum BossID
        {
            Shotgunner,
            MachineGunKid,
            TwinShot,
            Tank,
            BullTank,
            Arnold,
            CowardDuck,
            FireTrooper,
            Supercomputer,
            VermonCaTaffy
        }

        public bool[] bosses = new bool[10];
        #endregion

        #region Prisoners

        public bool[] prisoners = new bool[22];

        #endregion

        public struct Events
        {
            public bool captured;
            public bool recovered;
        }

        public Events events = new Events();

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

        public string GeneratePassword()
        {
            string output = "";

            int[] table = new int[24];
            int word = 0;

            //word 1
            //character 1
            table[word * 5 + 0] += bosses[(int)BossID.VermonCaTaffy] == true ? 16 : 0;
            table[word * 5 + 0] += bosses[(int)BossID.Supercomputer] == true ? 8 : 0;
            table[word * 5 + 0] += rank;
            //character 2
            table[word * 5 + 1] += bosses[(int)BossID.Tank] == true ? 16 : 0;
            table[word * 5 + 1] += bosses[(int)BossID.BullTank] == true ? 8 : 0;
            table[word * 5 + 1] += bosses[(int)BossID.Shotgunner] == true ? 4 : 0;
            table[word * 5 + 1] += bosses[(int)BossID.TwinShot] == true ? 2 : 0;
            table[word * 5 + 1] += bosses[(int)BossID.MachineGunKid] == true ? 1 : 0;
            //character 3
            table[word * 5 + 2] += weapons[(int)WeaponID.MachineGun].obtained == true ? 16 : 0;
            table[word * 5 + 2] += weapons[(int)WeaponID.Missiles].obtained == true ? 8 : 0;
            table[word * 5 + 2] += weapons[(int)WeaponID.Explosives].obtained == true ? 4 : 0;
            table[word * 5 + 2] += weapons[(int)WeaponID.Mines].obtained == true ? 2 : 0;
            table[word * 5 + 2] += weapons[(int)WeaponID.HandGun].obtained == true ? 1 : 0;
            //character 4
            table[word * 5 + 3] += prisoners[0] == true ? 16 : 0;
            table[word * 5 + 3] += prisoners[1] == true ? 8 : 0;
            table[word * 5 + 3] += prisoners[2] == true ? 4 : 0;
            table[word * 5 + 3] += prisoners[3] == true ? 2 : 0;
            table[word * 5 + 3] += prisoners[4] == true ? 1 : 0;
            //character 5
            table[word * 5 + 4] += prisoners[5] == true ? 16 : 0;
            table[word * 5 + 4] += prisoners[6] == true ? 8 : 0;
            table[word * 5 + 4] += prisoners[7] == true ? 4 : 0;
            table[word * 5 + 4] += prisoners[8] == true ? 2 : 0;
            table[word * 5 + 4] += prisoners[9] == true ? 1 : 0;
            word++;

            //word 2
            //character 1
            table[word * 5 + 0] += prisoners[10] == true ? 16 : 0;
            table[word * 5 + 0] += prisoners[11] == true ? 8 : 0;
            table[word * 5 + 0] += prisoners[12] == true ? 4 : 0;
            table[word * 5 + 0] += prisoners[13] == true ? 2 : 0;
            //character 2
            table[word * 5 + 1] += equipment.card5 == true ? 16 : 0;
            table[word * 5 + 1] += equipment.card4 == true ? 8 : 0;
            table[word * 5 + 1] += equipment.card3 == true ? 4 : 0;
            table[word * 5 + 1] += equipment.card2 == true ? 2 : 0;
            table[word * 5 + 1] += equipment.card1 == true ? 1 : 0;
            //character 3
            table[word * 5 + 2] += equipment.bbSuit == true ? 16 : 0;
            table[word * 5 + 2] += equipment.cardboard == true ? 8 : 0;
            table[word * 5 + 2] += equipment.binoculars == true ? 4 : 0;
            table[word * 5 + 2] += equipment.gasmask == true ? 2 : 0;
            table[word * 5 + 2] += equipment.cigarettes == true ? 1 : 0;
            //character 4
            table[word * 5 + 3] += equipment.light == true ? 16 : 0;
            table[word * 5 + 3] += equipment.antidote == true ? 8 : 0;
            table[word * 5 + 3] += equipment.antenna == true ? 4 : 0;
            table[word * 5 + 3] += equipment.armor == true ? 2 : 0;
            table[word * 5 + 3] += equipment.detector == true ? 1 : 0;
            //character 5
            table[word * 5 + 4] += equipment.rations;
            word++;

            //word 3
            //character 1
            table[word * 5 + 0] += weapons[(int)WeaponID.HandGun].ammoCount & 0b11111;
            //character 2
            table[word * 5 + 1] += weapons[(int)WeaponID.Missiles].ammoCount;
            //character 3
            table[word * 5 + 2] += weapons[(int)WeaponID.Explosives].ammoCount;
            //character 4
            table[word * 5 + 3] += weapons[(int)WeaponID.Mines].ammoCount;
            //character 5
            table[word * 5 + 4] += weapons[(int)WeaponID.MachineGun].ammoCount & 0b11111;
            word++;

            //word 4
            //character 1
            table[word * 5 + 0] += weapons[(int)WeaponID.Grenades].ammoCount & 0b11111;
            //character 2
            table[word * 5 + 1] += weapons[(int)WeaponID.Rockets].ammoCount;
            //character 3
            table[word * 5 + 2] += (weapons[(int)WeaponID.Grenades].ammoCount & 0b1100000) >> 2;
            table[word * 5 + 2] += (weapons[((int)WeaponID.MachineGun)].ammoCount & 0b11100000) >> 4;
            //character 4
            table[word * 5 + 3] += equipment.googles == true ? 16 : 0;
            table[word * 5 + 3] += equipment.uniform == true ? 8 : 0;
            table[word * 5 + 3] += bosses[(int)BossID.CowardDuck] == true ? 4 : 0;
            table[word * 5 + 3] += bosses[(int)BossID.FireTrooper] == true ? 2 : 0;
            table[word * 5 + 3] += bosses[(int)BossID.Arnold] == true ? 1 : 0;
            //character 5
            table[word * 5 + 4] += equipment.oxygen == true ? 16 : 0;
            table[word * 5 + 4] += equipment.compass == true ? 8 : 0;
            table[word * 5 + 4] += weapons[(int)WeaponID.Silencer].obtained == true ? 4 : 0;
            table[word * 5 + 4] += weapons[(int)WeaponID.Rockets].obtained == true ? 2 : 0;
            table[word * 5 + 4] += weapons[(int)WeaponID.Grenades].obtained == true ? 1 : 0;
            word++;

            //word 5
            //character 1
            table[word * 5 + 0] += events.captured == true ? 16 : 0;
            table[word * 5 + 0] += prisoners[14] == true ? 2 : 0;
            table[word * 5 + 0] += prisoners[15] == true ? 1 : 0;
            //character 2
            table[word * 5 + 1] += (weapons[(int)WeaponID.HandGun].ammoCount & 0b1100000) >> 2;
            table[word * 5 + 1] += prisoners[16] == true ? 4 : 0;
            table[word * 5 + 1] += prisoners[17] == true ? 2 : 0;
            table[word * 5 + 1] += prisoners[18] == true ? 1 : 0;
            //character 3
            table[word * 5 + 2] += equipment.glove == true ? 16 : 0;
            table[word * 5 + 2] += equipment.transmitter == true ? 8 : 0;
            table[word * 5 + 2] += prisoners[19] == true ? 4 : 0;
            table[word * 5 + 2] += prisoners[20] == true ? 2 : 0;
            table[word * 5 + 2] += prisoners[21] == true ? 1 : 0;
            //character 4
            table[word * 5 + 3] += events.recovered == true ? 16 : 0;
            table[word * 5 + 3] += (weapons[(int)WeaponID.HandGun].ammoCount & 128) >> 4;
            table[word * 5 + 3] += equipment.card8 == true ? 4 : 0;
            table[word * 5 + 3] += equipment.card7 == true ? 2 : 0;
            table[word * 5 + 3] += equipment.card6 == true ? 1 : 0;

            return output;
        }

    }
}
