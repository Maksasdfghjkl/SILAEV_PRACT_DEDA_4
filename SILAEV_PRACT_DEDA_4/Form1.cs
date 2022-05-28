using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SILAEV_PRACT_DEDA_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button[] arr_Button = new Button[0];
        private TextBox[] arr_TextBox = new TextBox[0];
        private Label[] arr_Label = new Label[0];
        private Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref arr_Label, arr_Label.Length + 1);
            arr_Label[arr_Label.Length - 1] = new Label();
            arr_Label[arr_Label.Length - 1].AutoSize = true;
            arr_Label[arr_Label.Length - 1].Location = new System.Drawing.Point(rnd.Next(0, panel1.Width - 20), rnd.Next(0, panel1.Height - 20));
            arr_Label[arr_Label.Length - 1].Name = "label" + arr_Label.Length.ToString();
            arr_Label[arr_Label.Length - 1].Size = new System.Drawing.Size(rnd.Next(20, panel1.Width - arr_Label[arr_Label.Length - 1].Location.X), rnd.Next(20, panel1.Height - arr_Label[arr_Label.Length - 1].Location.Y));
            arr_Label[arr_Label.Length - 1].TabIndex = 0;
            arr_Label[arr_Label.Length - 1].Text = "label" + arr_Label.Length.ToString();
            panel1.Controls.Add(arr_Label[arr_Label.Length - 1]);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref arr_TextBox, arr_TextBox.Length + 1);
            arr_TextBox[arr_TextBox.Length - 1] = new TextBox();
            arr_TextBox[arr_TextBox.Length - 1].Name = "TextBox" + arr_TextBox.Length.ToString();
            arr_TextBox[arr_TextBox.Length - 1].TabIndex = 0;
            arr_TextBox[arr_TextBox.Length - 1].Text = "TextBox" + arr_TextBox.Length.ToString();
            arr_TextBox[arr_TextBox.Length - 1].Location = new Point(rnd.Next(0, panel3.Width - 20), rnd.Next(0, panel3.Height - 20));
            arr_TextBox[arr_TextBox.Length - 1].Size = new Size(rnd.Next(20, panel3.Width - arr_TextBox[arr_TextBox.Length - 1].Location.X), rnd.Next(20, panel3.Height - arr_TextBox[arr_TextBox.Length - 1].Location.Y));
            panel3.Controls.Add(arr_TextBox[arr_TextBox.Length - 1]);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Array.Resize(ref arr_Button, arr_Button.Length + 1);
            arr_Button[arr_Button.Length - 1] = new Button();
            arr_Button[arr_Button.Length - 1].Name = "button" + arr_Button.Length.ToString();
            arr_Button[arr_Button.Length - 1].TabIndex = 0;
            arr_Button[arr_Button.Length - 1].Text = "button" + arr_Button.Length.ToString();
            arr_Button[arr_Button.Length - 1].UseVisualStyleBackColor = true;
            arr_Button[arr_Button.Length - 1].Location = new Point(rnd.Next(0, panel2.Width - 20), rnd.Next(0, panel2.Height - 20));
            arr_Button[arr_Button.Length - 1].Size = new Size(rnd.Next(20, panel2.Width - arr_Button[arr_Button.Length - 1].Location.X), rnd.Next(20, panel2.Height - arr_Button[arr_Button.Length - 1].Location.Y));
            panel2.Controls.Add(arr_Button[arr_Button.Length - 1]);
        }
    }
}
