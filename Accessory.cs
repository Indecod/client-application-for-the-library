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
    public partial class Accessory : Form
    {
        public Accessory()
        {
            InitializeComponent();
        }

        private void accessoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accessoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void Accessory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.Accessory". При необходимости она может быть перемещена или удалена.
            this.accessoryTableAdapter.Fill(this.bD50DataSet.Accessory);

        }

        private void Accessory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.AccessoryB.Visible = true;
        }
    }
}
