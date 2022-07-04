using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGenerator
{
    public partial class Form1 : Form
    {
        private bool includeAlphabeticChars, includeNumbers, includeSpecialChars;
        private char[] password;

        private void numbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(numbersCheckBox.Checked)
            {
                includeNumbers = true;
            }
            else
            {
                includeNumbers = false;
            }
        }

        private void specialCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(specialCharsCheckBox.Checked)
            {
                includeSpecialChars = true;
            }
            else
            {
                includeSpecialChars = false;
            }
        }
        
        private void alphabeticCharsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (alphabeticCharsCheckBox.Checked)
            {
                includeAlphabeticChars = true;
            }
            else
            {
                includeAlphabeticChars = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            generatedPasswordTextBox.Text = "";
            passwordLengthTextBox.Text = "";
            alphabeticCharsCheckBox.Checked = false;
            numbersCheckBox.Checked = false;
            specialCharsCheckBox.Checked = false;
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if(generatedPasswordTextBox.Text != "")
            {
                Clipboard.SetText(generatedPasswordTextBox.Text = string.Join("", password));
                MessageBox.Show("Password was successfully copied to the clipboard", "Password copied",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please generate a password before attempting to copy", "Password required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if(!alphabeticCharsCheckBox.Checked && !numbersCheckBox.Checked && !specialCharsCheckBox.Checked)
            {
                MessageBox.Show("Please select a character type option.", "Selection required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);                
            } 
            else
            {
                try
                {
                    int passwordLength = Convert.ToInt32(passwordLengthTextBox.Text);

                    if (passwordLength <= 7)
                    {
                        MessageBox.Show("The minimum password length must be greater than 7", "Enter a vaid password length",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Create an instance of the password generation engine
                        Viper viper = new Viper(includeAlphabeticChars, includeNumbers, includeSpecialChars, passwordLength);
                        password = viper.GeneratePassword();

                        generatedPasswordTextBox.Text = string.Join("", password);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a valid password length.", "Enter a valid password length",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    passwordLengthTextBox.Text = "";
                    passwordLengthTextBox.Focus();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            generatedPasswordTextBox.AutoSize = false;
        }
    }
}
