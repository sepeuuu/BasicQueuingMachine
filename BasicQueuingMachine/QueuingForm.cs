using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingMachine
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private ServingForm servingForm;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            CashierWindowQueueForm obj = new CashierWindowQueueForm();
            obj.Show();
            servingForm = new ServingForm();
            servingForm.Show();
        }
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInqueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInqueue);
        }
        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();   
        }
    }
}
