using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingMachine
{
    public partial class ServingForm : Form
    {
        private CashierClass cashier;
        private Timer timer;
        public ServingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(UpdatedQueue);
            timer.Start();
        }
        private void UpdatedQueue(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {                
                string nextInQueue = CashierClass.CashierQueue.Peek();           
                lblServing.Text = nextInQueue;
            }
        }
    }
}