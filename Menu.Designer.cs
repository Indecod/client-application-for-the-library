namespace КлиенткаПрактика
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.AccessoryB = new System.Windows.Forms.Button();
            this.AccToBoatsB = new System.Windows.Forms.Button();
            this.BoatB = new System.Windows.Forms.Button();
            this.ContractB = new System.Windows.Forms.Button();
            this.CustomerB = new System.Windows.Forms.Button();
            this.InvoiceB = new System.Windows.Forms.Button();
            this.OrderB = new System.Windows.Forms.Button();
            this.OrderDetailsB = new System.Windows.Forms.Button();
            this.PartnerB = new System.Windows.Forms.Button();
            this.SalesPersonB = new System.Windows.Forms.Button();
            this.bD50DataSet = new КлиенткаПрактика.BD50DataSet();
            this.authBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authTableAdapter = new КлиенткаПрактика.BD50DataSetTableAdapters.AuthTableAdapter();
            this.tableAdapterManager = new КлиенткаПрактика.BD50DataSetTableAdapters.TableAdapterManager();
            this.authTableAdapter1 = new КлиенткаПрактика.AuthDataSetTableAdapters.AuthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bD50DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccessoryB
            // 
            this.AccessoryB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.AccessoryB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccessoryB.Location = new System.Drawing.Point(12, 26);
            this.AccessoryB.Name = "AccessoryB";
            this.AccessoryB.Size = new System.Drawing.Size(249, 125);
            this.AccessoryB.TabIndex = 0;
            this.AccessoryB.Text = "Аксессуары";
            this.AccessoryB.UseVisualStyleBackColor = false;
            this.AccessoryB.Click += new System.EventHandler(this.Accessory_Click);
            // 
            // AccToBoatsB
            // 
            this.AccToBoatsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.AccToBoatsB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccToBoatsB.Location = new System.Drawing.Point(267, 28);
            this.AccToBoatsB.Name = "AccToBoatsB";
            this.AccToBoatsB.Size = new System.Drawing.Size(249, 125);
            this.AccToBoatsB.TabIndex = 1;
            this.AccToBoatsB.Text = "Лодочные аксессуары";
            this.AccToBoatsB.UseVisualStyleBackColor = false;
            this.AccToBoatsB.Click += new System.EventHandler(this.AccToBoatsB_Click);
            // 
            // BoatB
            // 
            this.BoatB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.BoatB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BoatB.Location = new System.Drawing.Point(533, 29);
            this.BoatB.Name = "BoatB";
            this.BoatB.Size = new System.Drawing.Size(249, 124);
            this.BoatB.TabIndex = 2;
            this.BoatB.Text = "Лодки";
            this.BoatB.UseVisualStyleBackColor = false;
            this.BoatB.Click += new System.EventHandler(this.BoatB_Click);
            // 
            // ContractB
            // 
            this.ContractB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.ContractB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContractB.Location = new System.Drawing.Point(800, 28);
            this.ContractB.Name = "ContractB";
            this.ContractB.Size = new System.Drawing.Size(249, 125);
            this.ContractB.TabIndex = 3;
            this.ContractB.Text = "Заказы";
            this.ContractB.UseVisualStyleBackColor = false;
            this.ContractB.Click += new System.EventHandler(this.ContractB_Click);
            // 
            // CustomerB
            // 
            this.CustomerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.CustomerB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerB.Location = new System.Drawing.Point(1070, 29);
            this.CustomerB.Name = "CustomerB";
            this.CustomerB.Size = new System.Drawing.Size(249, 125);
            this.CustomerB.TabIndex = 4;
            this.CustomerB.Text = "Клиенты";
            this.CustomerB.UseVisualStyleBackColor = false;
            this.CustomerB.Click += new System.EventHandler(this.CustomerB_Click);
            // 
            // InvoiceB
            // 
            this.InvoiceB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.InvoiceB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvoiceB.Location = new System.Drawing.Point(533, 174);
            this.InvoiceB.Name = "InvoiceB";
            this.InvoiceB.Size = new System.Drawing.Size(249, 125);
            this.InvoiceB.TabIndex = 5;
            this.InvoiceB.Text = "Счёт";
            this.InvoiceB.UseVisualStyleBackColor = false;
            this.InvoiceB.Click += new System.EventHandler(this.InvoiceB_Click);
            // 
            // OrderB
            // 
            this.OrderB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.OrderB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderB.Location = new System.Drawing.Point(800, 177);
            this.OrderB.Name = "OrderB";
            this.OrderB.Size = new System.Drawing.Size(249, 123);
            this.OrderB.TabIndex = 6;
            this.OrderB.Text = "Доставка";
            this.OrderB.UseVisualStyleBackColor = false;
            this.OrderB.Click += new System.EventHandler(this.OrderB_Click);
            // 
            // OrderDetailsB
            // 
            this.OrderDetailsB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.OrderDetailsB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDetailsB.Location = new System.Drawing.Point(1070, 177);
            this.OrderDetailsB.Name = "OrderDetailsB";
            this.OrderDetailsB.Size = new System.Drawing.Size(249, 123);
            this.OrderDetailsB.TabIndex = 7;
            this.OrderDetailsB.Text = "Критерии Доставки";
            this.OrderDetailsB.UseVisualStyleBackColor = false;
            this.OrderDetailsB.Click += new System.EventHandler(this.OrderDetailsB_Click);
            // 
            // PartnerB
            // 
            this.PartnerB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.PartnerB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PartnerB.Location = new System.Drawing.Point(12, 174);
            this.PartnerB.Name = "PartnerB";
            this.PartnerB.Size = new System.Drawing.Size(249, 123);
            this.PartnerB.TabIndex = 8;
            this.PartnerB.Text = "Партнёры";
            this.PartnerB.UseVisualStyleBackColor = false;
            this.PartnerB.Click += new System.EventHandler(this.PartnerB_Click);
            // 
            // SalesPersonB
            // 
            this.SalesPersonB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(218)))));
            this.SalesPersonB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalesPersonB.Location = new System.Drawing.Point(267, 175);
            this.SalesPersonB.Name = "SalesPersonB";
            this.SalesPersonB.Size = new System.Drawing.Size(248, 122);
            this.SalesPersonB.TabIndex = 9;
            this.SalesPersonB.Text = "Менеджеры";
            this.SalesPersonB.UseVisualStyleBackColor = false;
            this.SalesPersonB.Click += new System.EventHandler(this.SalesPersonB_Click);
            // 
            // bD50DataSet
            // 
            this.bD50DataSet.DataSetName = "BD50DataSet";
            this.bD50DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authBindingSource
            // 
            this.authBindingSource.DataMember = "Auth";
            this.authBindingSource.DataSource = this.bD50DataSet;
            // 
            // authTableAdapter
            // 
            this.authTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.AccToBoatsTableAdapter = null;
            this.tableAdapterManager.AuthTableAdapter = this.authTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BoatTableAdapter = null;
            this.tableAdapterManager.ContractTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoiceTableAdapter = null;
            this.tableAdapterManager.OrderDetailsTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PartnerTableAdapter = null;
            this.tableAdapterManager.SalesPersonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = КлиенткаПрактика.BD50DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // authTableAdapter1
            // 
            this.authTableAdapter1.ClearBeforeFill = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1331, 331);
            this.Controls.Add(this.SalesPersonB);
            this.Controls.Add(this.PartnerB);
            this.Controls.Add(this.OrderDetailsB);
            this.Controls.Add(this.OrderB);
            this.Controls.Add(this.InvoiceB);
            this.Controls.Add(this.CustomerB);
            this.Controls.Add(this.ContractB);
            this.Controls.Add(this.BoatB);
            this.Controls.Add(this.AccToBoatsB);
            this.Controls.Add(this.AccessoryB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD50DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button AccessoryB;
        public System.Windows.Forms.Button AccToBoatsB;
        public System.Windows.Forms.Button BoatB;
        public System.Windows.Forms.Button ContractB;
        public System.Windows.Forms.Button CustomerB;
        public System.Windows.Forms.Button InvoiceB;
        public System.Windows.Forms.Button OrderB;
        public System.Windows.Forms.Button OrderDetailsB;
        public System.Windows.Forms.Button PartnerB;
        public System.Windows.Forms.Button SalesPersonB;
        private BD50DataSet bD50DataSet;
        private System.Windows.Forms.BindingSource authBindingSource;
        private BD50DataSetTableAdapters.AuthTableAdapter authTableAdapter;
        private BD50DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AuthDataSetTableAdapters.AuthTableAdapter authTableAdapter1;
    }
}

