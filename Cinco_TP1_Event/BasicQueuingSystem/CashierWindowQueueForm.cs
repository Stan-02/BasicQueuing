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
    public partial class CashierWindowQueueForm : Form
    {
        
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }
        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            ServingForm servingForm = new ServingForm();
            servingForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Dequeue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(btnRefresh_Click);
            timer.Start();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}