using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using CustomerFactory;

namespace DPCustomerProjectClient
{
    public partial class frmCustomer : Form
    {
        private CustomerBase cust = null;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Factory.Create(cbxCustomerType.Text);
        }

        private void SetCustomer()
        {
            cust.CustomerName = txtCustomerName.Text;
            cust.PhoneNumber = txtPhoneNumber.Text;
            cust.BillAmount = Convert.ToDecimal(txtBillAmount.Text);
            cust.BillDate = Convert.ToDateTime(txtBillDate.Text);
            cust.Address = txtAddress.Text;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
