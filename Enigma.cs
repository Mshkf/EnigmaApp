using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaApp
{
    internal class Enigma
    {
        char[] letters = new char[26] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A',
            'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

        int[] reflector = new int[26] { 19, 16, 17, 8, 15, 12, 20, 18, 3, 14, 13, 24,
            5, 10, 9, 4, 1, 2, 7, 0, 6, 22, 21, 25, 11, 23 };// reflector[reflector[i]] == i

        public Dictionary<char, char> plugboard = new Dictionary<char, char>();

        public Rotor rotorFirst;
        public Rotor rotorSecond;
        public Rotor rotorThird;

        public Enigma(Rotor r1, Rotor r2, Rotor r3)
        {
            rotorFirst = r1;
            rotorSecond = r2;
            rotorThird = r3;
        }

        char EncryptLetter(char letter)
        {
            if (plugboard.ContainsKey(letter))
                letter = plugboard[letter];

            int index = Array.IndexOf(letters, letter);

            //direct
            index = rotorThird.Straight(rotorSecond.Straight(rotorFirst.Straight(index)));

            //reflect
            index = reflector[index];

            //inverse
            index = rotorFirst.Back(rotorSecond.Back(rotorThird.Back(index)));

            letter = letters[index];

            if (plugboard.ContainsKey(letter))
                letter = plugboard[letter];

            MakeRotations();

            return letter;
        }

        public string Encrypt(string str)
        {
            string result = "";
            foreach (char letter in str)
            {
                result += EncryptLetter(letter);
            }
            return result;
        }

        void MakeRotations()
        {
            if (rotorFirst.rotation == 25)
            {
                if (rotorSecond.rotation == 25)
                    rotorThird.Rotate();
                rotorSecond.Rotate();
            }
            rotorFirst.Rotate();
        }

        public void AddPlug(char letter1, char letter2)
        {
            plugboard[letter1] = letter2;
            plugboard[letter2] = letter1;
        }

        public void RemovePlug(char letter1, char letter2)
        {
            plugboard.Remove(letter1);
            plugboard.Remove(letter2);
        }
    }
}
