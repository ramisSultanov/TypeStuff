using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeStuff
{
    public partial class Form1 : Form
    {
        public static string TEXT = "Typing is one of the most fundamental skills in this digital age. Whether you're writing emails, " +
                "coding software, or simply chatting with friends, fast and accurate typing can greatly enhance your productivity. " +
                "To improve, practice regularly and concentrate on precision before speed.";
        public int position = 0;
        public char[] correctInputArray = new char[TEXT.Length];
        public int correctInputs = 0;
        public Timer myTimer = new Timer();
        public int time = 10;

        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;

            textBoxDisplay.Text = TEXT;
            
            myTimer.Interval = time * 1000; // *time* seconds
            myTimer.Tick += new EventHandler(myTimer_Tick);
            myTimer.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            Form frm = new Form2(time, correctInputArray);
            this.Hide();
            System.Threading.Thread.Sleep(500); // Suspend 0.5 sec
            frm.Show();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string input = textBox.Text;
            if (input.Length > 0)
            {
                // Get the expected substring from the display text, starting at the current position.
                string expectedSubstring = TEXT.Substring(position, Math.Min(input.Length, TEXT.Length - position));

                // Check if the input matches the expected substring.
                if (input.Equals(expectedSubstring))
                {
                    // If the last character typed is a space, clear the textbox and update the position.
                    if (input.Last() == ' ')
                    {
                        textBox.Text = ""; // This will re-trigger textBox_TextChanged, but with an empty string.
                        position += input.Length;
                        textBox.SelectionStart = 0; // Reset cursor position
                        UpdateTextBoxDisplay(false); // Update formatting
                    }
                    else
                    {
                        UpdateTextBoxDisplay(true); // Update formatting even without space if input is correct
                    }
                    correctInputArray[correctInputs++] = input.Last();
                }
                else
                {
                    UpdateTextBoxDisplay(false);
                    // Optional: Provide visual feedback for error
                }
            }
            else
            {
                UpdateTextBoxDisplay(true); // Reset formatting when textbox is cleared
            }
        }

        private void UpdateTextBoxDisplay(bool correctSymbol)
        {
            
            textBoxDisplay.Select(textBox.Text.Length + position, TEXT.Length - textBox.Text.Length - position);
            textBoxDisplay.SelectionBackColor = Color.White;
            textBoxDisplay.SelectionFont = new Font(textBoxDisplay.Font, FontStyle.Regular);

            textBoxDisplay.Select(position + textBox.Text.Length, 1);
            textBoxDisplay.SelectionBackColor = Color.LightSkyBlue;
            /*
            textBoxDisplay.Select(textBox.Text.Length + position, TEXT.Length - position);
            textBoxDisplay.SelectionBackColor = Color.White;
            textBoxDisplay.SelectionFont = new Font(textBoxDisplay.Font, FontStyle.Regular);
            */
            if (correctSymbol)
            {
                // Set the correct text in orange
                if (position < TEXT.Length)
                {
                    textBoxDisplay.Select(position, textBox.Text.Length);
                    textBoxDisplay.SelectionBackColor = Color.LightGray;

                    textBoxDisplay.Select(position + textBox.Text.Length, 1);
                    textBoxDisplay.SelectionBackColor = Color.LightSkyBlue;

                    textBoxDisplay.Select(0, position);
                    textBoxDisplay.SelectionColor = Color.Gray;
                }
                
            }
            
            if (!correctSymbol)
            {
                textBoxDisplay.Select(position + textBox.Text.Length - 1, 1);
                textBoxDisplay.SelectionBackColor = Color.Tomato;
            }
            
            // Underline the next expected character
            if (position + textBox.Text.Length < TEXT.Length)
            {
                //textBoxDisplay.SelectAll();
                //textBoxDisplay.SelectionFont = new Font(textBoxDisplay.Font, FontStyle.Regular);
                textBoxDisplay.Select(0, position);
                textBoxDisplay.SelectionBackColor = Color.White;
                
                //textBoxDisplay.SelectionFont = new Font(textBoxDisplay.Font, FontStyle.Underline);

                textBoxDisplay.Select(0, position);
                textBoxDisplay.SelectionColor = Color.Gray;
            }

            textBoxDisplay.DeselectAll();
        }
    }
}
