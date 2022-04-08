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
    public partial class SalesPerson : Form
    {
        public SalesPerson()
        {
            InitializeComponent();
        }

        private void salesPersonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesPersonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void SalesPerson_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.SalesPerson". При необходимости она может быть перемещена или удалена.
            this.salesPersonTableAdapter.Fill(this.bD50DataSet.SalesPerson);

        }

        private void SalesPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.SalesPersonB.Visible = true;
        }
    }
}
