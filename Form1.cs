using System;
using System.Windows.Forms;

namespace Exam_1___Madison_Dorse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Wire up all character buttons
            btnA.Click += (s, e) => AppendChar("A");
            btnB.Click += (s, e) => AppendChar("B");
            btnC.Click += (s, e) => AppendChar("C");
            btnD.Click += (s, e) => AppendChar("D");
            btnE.Click += (s, e) => AppendChar("E");
            btnF.Click += (s, e) => AppendChar("F");
            btnG.Click += (s, e) => AppendChar("G");
            btnH.Click += (s, e) => AppendChar("H");
            btnI.Click += (s, e) => AppendChar("I");
            btnJ.Click += (s, e) => AppendChar("J");
            btnK.Click += (s, e) => AppendChar("K");
            btnL.Click += (s, e) => AppendChar("L");
            btnM.Click += (s, e) => AppendChar("M");
            btnN.Click += (s, e) => AppendChar("N");
            btnO.Click += (s, e) => AppendChar("O");
            btnP.Click += (s, e) => AppendChar("P");
            btnQ.Click += (s, e) => AppendChar("Q");
            btnR.Click += (s, e) => AppendChar("R");
            btnS.Click += (s, e) => AppendChar("S");
            btnT.Click += (s, e) => AppendChar("T");
            btnU.Click += (s, e) => AppendChar("U");
            btnV.Click += (s, e) => AppendChar("V");
            btnW.Click += (s, e) => AppendChar("W");
            btnX.Click += (s, e) => AppendChar("X");
            btnY.Click += (s, e) => AppendChar("Y");
            btnZ.Click += (s, e) => AppendChar("Z");
            btn0.Click += (s, e) => AppendChar("0");
            btn1.Click += (s, e) => AppendChar("1");
            btn2.Click += (s, e) => AppendChar("2");
            btn3.Click += (s, e) => AppendChar("3");
            btn4.Click += (s, e) => AppendChar("4");
            btn5.Click += (s, e) => AppendChar("5");
            btn6.Click += (s, e) => AppendChar("6");
            btn7.Click += (s, e) => AppendChar("7");
            btn8.Click += (s, e) => AppendChar("8");
            btn9.Click += (s, e) => AppendChar("9");
            btnPeriod.Click += (s, e) => AppendChar(".");
            btnBlank.Click += (s, e) => AppendChar(" ");

            // Wire up control buttons
            btnClear.Click += (s, e) => txtMessage.Text = "";
            btnSend.Click += (s, e) =>
            {
                lblLastSent.Text = txtMessage.Text;
                txtMessage.Text = "";
            };
            btnExit.Click += (s, e) => Close();
        }

        private void AppendChar(string c)
        {
            txtMessage.Text += c;
        }
    }
}
