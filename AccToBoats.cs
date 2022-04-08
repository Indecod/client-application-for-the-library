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
    public partial class AccToBoats : Form
    {
        public AccToBoats()
        {
            InitializeComponent();
        }

        private void accToBoatsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accToBoatsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void AccToBoats_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.AccToBoats". При необходимости она может быть перемещена или удалена.
            this.accToBoatsTableAdapter.Fill(this.bD50DataSet.AccToBoats);

        }

        private void AccToBoats_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.AccToBoatsB.Visible = true;
        }
    }
}
