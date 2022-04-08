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
    public partial class Partner : Form
    {
        public Partner()
        {
            InitializeComponent();
        }

        private void partnerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partnerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

        private void Partner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.Partner". При необходимости она может быть перемещена или удалена.
            this.partnerTableAdapter.Fill(this.bD50DataSet.Partner);

        }

        private void Partner_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            Menu f1 = this.Owner as Menu;
            f1.PartnerB.Visible = true;
        }
    }
}
