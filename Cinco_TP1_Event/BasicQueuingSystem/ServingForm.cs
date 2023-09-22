using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystem
{
    public partial class ServingForm : Form
    {
        public ServingForm()
        {
            InitializeComponent();
        }

        private void ServingForm_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count != 0)
            {
                lblNumber.Text = CashierClass.CashierQueue.Peek();
            }
        }
    }
}
