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
    public partial class QuestionOne : Form
    {
        public QuestionOne()
        {
            InitializeComponent();
        }
        Button btnStartOne = new Button();
        Button[] btnAnswer = new Button[4];
        //Button btnAnswerOne = new Button();
        //Button btnAnswerTwo = new Button();
        //Button btnAnswerThree = new Button();
        //Button btnAnswerFour = new Button();
        public void QuestionOne_Load(object sender, EventArgs e)
        {
            //i have got the height of the form and taken away the size of the button and divided by 2 to get the difference and center the button, 
            //and then adjusted to get measurements better because it seems the measurements are not entirely accurate unfortately
            btnStartOne.SetBounds((this.Width - 670) / 2, (this.Height - 403) / 2, 655, 365);
            Console.WriteLine(this.Width);
            Console.WriteLine(this.Height);
            this.Controls.Add(btnStartOne);
            btnStartOne.Text = "";
            //btnStartOne.BackgroundImage = Image.FromFile("duo logo.png");
            btnStartOne.Click += new EventHandler(this.btnStartOne_Click);
            //this.btnStartOneFake.Visible = false;
        }

        void btnStartOne_Click(object sender, EventArgs e)
        {
            //Hide the button clicked
            btnStartOne.Hide();
        }
    }
}
