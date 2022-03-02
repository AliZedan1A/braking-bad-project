using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace braking_bad_project
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(prs.Value<100)
            {
                prs.Value++;
                label1.Text =prs.Value.ToString() +"%" ;

            }
            else
            {
                timer1.Stop();
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
            }
        }

        private void loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
