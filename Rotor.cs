using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaApp
{
    internal class Rotor
    {
        public int[] wires = new int[26];
        public int rotation = 0;

        public Rotor(params int[] input)
        {
            wires = input;
        }

        public void Rotate()
        {
            int first = wires[0];
            for (int i = 0; i < wires.Length - 1; i++)
                wires[i] = wires[i + 1];
            wires[wires.Length - 1] = first;

            if (rotation == 25)
                rotation = 0;
            else
                rotation++;
        }

        public void SetRotation(int n)
        {
            while (rotation != n)
                Rotate();
        }

        public int Straight(int n)
        {
            return wires[n];
        }

        public int Back(int n)
        {
            return Array.IndexOf(wires, n);
        }
    }
}
