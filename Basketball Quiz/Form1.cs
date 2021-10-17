using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           


        }
        /*Button btnAnswerOne = new Button();
        Button btnAnswerTwo = new Button();
        Button btnAnswerThree = new Button();
        Button btnAnswerFour = new Button();*/
        Label lblQuestion = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            }
        }
        private void CreateButtons()
        {
            Button[] btnAnswer = new Button[4];
            int xPos = 0;
            int yPos = 0;
            // Create Buttons:
            for (int i = 0; i < 4; i++)
            {
                // Initialize one variable
                btnAnswer[i] = new Button();
            }
            int n = 0;
            while (n < 26)
            {
                btnAnswer[n].Tag = n + 1; // Tag of button
                btnAnswer[n].Width = 24; // Width of button
                btnAnswer[n].Height = 20; // Height of button
                if (n == 13) // Location of second line of buttons:
                {
                    xPos = 0;
                    yPos = 20;
                }
                // Location of button:
                btnAnswer[n].Left = xPos;
                btnAnswer[n].Top = yPos;
                // Add buttons to a Panel:
                panel1.Controls.Add(btnAnswer[n]); // Let panel hold the Buttons
                xPos = xPos + btnAnswer[n].Width; // Left of next button
                                                 // Write English Characters:
                btnAnswer[n].Text = ((char)(n + 65)).ToString();
                // the Event of click Button:
                btnAnswer[n].Click += new System.EventHandler(ClickButton);
                n++;
        }
    }
}
