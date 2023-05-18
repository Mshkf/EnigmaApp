using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaApp
{
    public partial class Form1 : Form
    {
        Rotor rotor1 = new Rotor(17, 25, 10, 9, 2, 13, 21, 6, 20, 15, 14, 18,
            12, 19, 11, 1, 4, 3, 16, 23, 0, 8, 24, 5, 7, 22);

        Rotor rotor2 = new Rotor(21, 19, 17, 0, 15, 6, 24, 2, 4, 9, 8, 7, 23,
            25, 10, 3, 20, 11, 1, 13, 18, 16, 12, 5, 22, 14);

        Rotor rotor3 = new Rotor(1, 20, 4, 7, 21, 16, 3, 5, 2, 19, 15, 10, 25,
            22, 14, 12, 23, 18, 11, 24, 9, 13, 0, 6, 8, 17);

        Rotor rotor4 = new Rotor(18, 0, 7, 15, 22, 20, 16, 21, 19, 2, 6, 5, 24,
            3, 11, 25, 23, 1, 17, 12, 10, 8, 13, 9, 14, 4);

        Rotor rotor5 = new Rotor(20, 22, 6, 8, 15, 21, 25, 24, 10, 13, 3, 5, 1,
            9, 19, 11, 7, 4, 18, 14, 16, 12, 2, 0, 17, 23);

        Enigma enigma;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enigma = new Enigma(rotor1, rotor5, rotor3);//выбираем любые роторы
            UpdateRotors();
        }

        private void UpdateRotors()
        {
            rotorFirstTextBox.Text = enigma.rotorFirst.rotation.ToString();
            rotorSecondTextBox.Text = enigma.rotorSecond.rotation.ToString();
            rotorThirdTextBox.Text = enigma.rotorThird.rotation.ToString();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = enigma.Encrypt(richTextBox1.Text);
            UpdateRotors();
        }

        private void rotorFirstTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(rotorFirstTextBox.Text, out int index))
                enigma.rotorFirst.SetRotation(index);
        }

        private void rotorSecondTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(rotorSecondTextBox.Text, out int index))
                enigma.rotorSecond.SetRotation(index);
        }

        private void rotorThirdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(rotorThirdTextBox.Text, out int index))
                enigma.rotorThird.SetRotation(index);
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text.ToUpper();
        }

        private void plug1TextBox_Leave(object sender, EventArgs e)
        {
            plug1TextBox.Text = plug1TextBox.Text.ToUpper();
        }

        private void plug2TextBox_Leave(object sender, EventArgs e)
        {
            plug2TextBox.Text = plug2TextBox.Text.ToUpper();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            char letter1 = plug1TextBox.Text[0];
            char letter2 = plug2TextBox.Text[0];
            enigma.AddPlug(letter1, letter2);
            UpdatePlugListLabel();
        }

        private void UpdatePlugListLabel()
        {
            plugListLabel.Text = "";
            foreach (char key in enigma.plugboard.Keys)
            {
                plugListLabel.Text += key.ToString() + " = " + enigma.plugboard[key].ToString() + "\n";
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            char letter1 = plug1TextBox.Text[0];
            char letter2 = plug2TextBox.Text[0];
            enigma.RemovePlug(letter1, letter2);
            UpdatePlugListLabel();
        }
    }
}
