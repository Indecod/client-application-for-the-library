using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КлиенткаПрактика
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.Invoice". При необходимости она может быть перемещена или удалена.
            this.invoiceTableAdapter.Fill(this.bD50DataSet.Invoice);

        }

        private void Invoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.InvoiceB.Visible = true;
        }
    }
}
