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
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.OrderDetails". При необходимости она может быть перемещена или удалена.
            this.orderDetailsTableAdapter.Fill(this.bD50DataSet.OrderDetails);

        }

        private void OrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.OrderDetailsB.Visible = true;
        }
    }
}
