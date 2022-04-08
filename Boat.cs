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
    public partial class Boat : Form
    {
        public Boat()
        {
            InitializeComponent();
        }

        private void boatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.boatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void Boat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.Boat". При необходимости она может быть перемещена или удалена.
            this.boatTableAdapter.Fill(this.bD50DataSet.Boat);

        }

        private void Boat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.BoatB.Visible = true;
        }
    }
}
