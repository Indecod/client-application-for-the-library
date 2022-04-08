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
    public partial class Menu : Form
    {
        string role;
        public Menu(string _role)
        {
            InitializeComponent();
            role = _role;
        }

        public Menu()
        {
            InitializeComponent();
           
        }
        

        private void Accessory_Click(object sender, EventArgs e)
        {
            Accessory s = new Accessory();
            s.Show();
            s.Owner = this;
            AccessoryB.Visible = false;
        }

        private void AccToBoatsB_Click(object sender, EventArgs e)
        {
            AccToBoats s = new AccToBoats();
            s.Show();
            s.Owner = this;
            AccToBoatsB.Visible = false;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "authDataSet.Auth". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD50DataSet.Auth". При необходимости она может быть перемещена или удалена.
            this.authTableAdapter.Fill(this.bD50DataSet.Auth);

        }

        private void BoatB_Click(object sender, EventArgs e)
        {
            Boat s = new Boat();
            s.Show();
            s.Owner = this;
            BoatB.Visible = false;
        }

        private void ContractB_Click(object sender, EventArgs e)
        {
            Contract s = new Contract();
            s.Show();
            s.Owner = this;
            ContractB.Visible = false;
        }

        private void CustomerB_Click(object sender, EventArgs e)
        {
            Customer s = new Customer();
            s.Show();
            s.Owner = this;
            CustomerB.Visible = false;
        }

        private void InvoiceB_Click(object sender, EventArgs e)
        {
            Invoice s = new Invoice();
            s.Show();
            s.Owner = this;
            InvoiceB.Visible = false;
        }

        private void OrderB_Click(object sender, EventArgs e)
        {
            Order s = new Order();
            s.Show();
            s.Owner = this;
            OrderB.Visible = false;
        }

        private void OrderDetailsB_Click(object sender, EventArgs e)
        {
            OrderDetails s = new OrderDetails();
            s.Show();
            s.Owner = this;
            OrderDetailsB.Visible = false;
        }

        private void PartnerB_Click(object sender, EventArgs e)
        {
            Partner s = new Partner();
            s.Show();
            s.Owner = this;
            PartnerB.Visible = false;
        }

        private void SalesPersonB_Click(object sender, EventArgs e)
        {
            SalesPerson s = new SalesPerson();
            s.Show();
            s.Owner = this;
            SalesPersonB.Visible = false;
        }

        private void authBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD50DataSet);

        }

       
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Auth a = new Auth();
          //  a.Show();
        }
    }
}
