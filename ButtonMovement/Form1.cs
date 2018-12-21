using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonMovement
{
    public partial class Form1 : Form
    {
        public int btnLeft_StartPos_Left { get; set; }
        public int btnRight_StartPos_Left { get; set; }

        public Form1()
        {
            InitializeComponent();

            btnLeft_StartPos_Left = btnLeft.Left;
            btnRight_StartPos_Left = btnRight.Left;

            btnStart.Click += btnLeft_Click;
            btnStart.Click += btnRight_Click;
            btnStart.Click += btnStart_Click;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnLeft.Left += 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnRight.Left -= 10;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(btnLeft.Right >= btnRight.Left)
            {
                if(MessageBox.Show("Die Buttons berühren sich.\nZurücksetzen?", "KOLLISION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    btnLeft.Left = btnLeft_StartPos_Left;
                    btnRight.Left = btnRight_StartPos_Left;
                }
            }
        }
    }
}
