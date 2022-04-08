using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;


namespace КлиенткаПрактика
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(ShowPassword.Checked == true))
            {
                PasswordT.PasswordChar = '*';
                PasswordT.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordT.PasswordChar = '\0';
                PasswordT.UseSystemPasswordChar = false;
            }
        }


        private void disablePasswordField() // 3 попытки//
        {
            EnterB.Enabled = false;
            PasswordT.ReadOnly = true;
            passwordErrorMessage.Visible = true;
            Task.Run(async () => {
                var secondsLeft = 15;

                while (--secondsLeft > 0)
                {
                    Invoke(new Action(() => {
                        passwordErrorMessage.Text = $"Вы ввели неверный логин или пароль. Поле с паролем разблокируется через {secondsLeft}";
                    }));
                    Thread.Sleep(1000);
                }
                Invoke(new Action(() => {
                    EnterB.Enabled = true;
                    passwordErrorMessage.Visible = false;
                    passwordErrorMessage.Text = "";
                    PasswordT.ReadOnly = false;
                }));
            });
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
            new SqlConnectionStringBuilder()
            {
                DataSource = @"DESKTOP-VMOHA53\SQLEXPRESS08",
                InitialCatalog = "Auth",
                IntegratedSecurity = true
            }.ConnectionString
            );
            
            {
                using (var sqlDataAdapter = new SqlDataAdapter())
                {
                    sqlDataAdapter.SelectCommand = new SqlCommand(@"SELECT TOP (1000) [role]
                                                                                                FROM [Auth].[dbo].[Auth]
                                                                                                WHERE [login] = @login
                                                                                                AND [password] = @password", conn);

                    sqlDataAdapter.SelectCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = LoginT.Text;
                    sqlDataAdapter.SelectCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = PasswordT.Text;

                    var dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        string role = Convert.ToString(dataTable.Rows[0][0]);
                        
                        switch (role)
                        {
                            case "1":
                                Registration r = new Registration();
                                 r.Show();
                                Hide();
                                break;
                            case "2":
                                Hide();
                                new Menu(role).ShowDialog();
                                Show();
                                break;
                        }
                    }
                    else
                    {
                        
                        disablePasswordField();

                    }
                }
            }

        }
        
        private void Auth_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "authDataSet.Auth". При необходимости она может быть перемещена или удалена.
           

        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
