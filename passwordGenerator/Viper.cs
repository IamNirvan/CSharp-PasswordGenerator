using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordGenerator
{
    class Viper
    {
        char[] characters = {'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't' ,'u', 'v', 'w', 'x',
            'y', 'z'};

        char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        char[] specialChars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '=', '+', '{', '}', '[', ']' };
        char[][] masterArray;

        private int passwordLength;
        private bool includeEnglishChars, includeNumbers, includeSpecialChars;
        private char[] password;
        private Random random = new Random();

        public Viper(bool includeEnglishChars, bool includeNumbers, int passwordLength = 20)
        {
            this.includeEnglishChars = includeEnglishChars;
            this.includeNumbers = includeNumbers;
            this.passwordLength = passwordLength;
            password = new char[passwordLength];
        }

        public Viper(bool includeEnglishChars, bool includeNumbers, bool includeSpecialChars, int passwordLength = 20)
        {
            this.includeEnglishChars = includeEnglishChars;
            this.includeNumbers = includeNumbers;
            this.includeSpecialChars = includeSpecialChars;
            this.passwordLength = passwordLength;
            password = new char[passwordLength];
        }

        // TODO: Figure out a better way to do this ASAP!
        public void IdentifyComposition()
        {
            if(includeEnglishChars && !includeNumbers && !includeSpecialChars)
            {
                masterArray = new char[][] {characters};
            }
            else if (includeEnglishChars && includeNumbers && !includeSpecialChars)
            {
                masterArray = new char[][] {characters, numbers};
            }
            else if (includeEnglishChars && !includeNumbers && includeSpecialChars)
            {
                masterArray = new char[][] { characters, specialChars };
            }
            else if (includeEnglishChars && includeNumbers && includeSpecialChars)
            {
                masterArray = new char[][] {characters, numbers, specialChars};
            }
            else if(!includeEnglishChars && includeNumbers && !includeSpecialChars)
            {
                masterArray = new char[][] {numbers};
            }
            else if (!includeEnglishChars && includeNumbers && includeSpecialChars)
            {
                masterArray = new char[][] { numbers, specialChars };
            }
            else if(!includeEnglishChars && !includeNumbers && includeSpecialChars)
            {
                masterArray = new char[][] {specialChars};
            }
        }

        public void GenerateBase()
        {
            for(int i = 0; i < passwordLength; i++)
            {
                password[i] = masterArray[0][random.Next(masterArray[0].Length)];
            }
        }

        // TODO: Refactor this process
        public char[] EnhanceBase()
        {
            int index = 1;
            while(index < masterArray.Length)
            {
                for (int i = 0; i < passwordLength / 2; i++)
                {
                    password[random.Next(passwordLength)] = masterArray[index][random.Next(masterArray[index].Length)];
                }
                index++;
            }
            return password;
        }

        public char[] GeneratePassword()
        {
            IdentifyComposition();
            GenerateBase();
            return EnhanceBase();
        }
    } 
}
