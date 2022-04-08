namespace КлиенткаПрактика
{
    partial class AccToBoats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccToBoats));
            this.bD50DataSet = new КлиенткаПрактика.BD50DataSet();
            this.accToBoatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accToBoatsTableAdapter = new КлиенткаПрактика.BD50DataSetTableAdapters.AccToBoatsTableAdapter();
            this.tableAdapterManager = new КлиенткаПрактика.BD50DataSetTableAdapters.TableAdapterManager();
            this.accToBoatsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.accToBoatsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accToBoatsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bD50DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsBindingNavigator)).BeginInit();
            this.accToBoatsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD50DataSet
            // 
            this.bD50DataSet.DataSetName = "BD50DataSet";
            this.bD50DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accToBoatsBindingSource
            // 
            this.accToBoatsBindingSource.DataMember = "AccToBoats";
            this.accToBoatsBindingSource.DataSource = this.bD50DataSet;
            // 
            // accToBoatsTableAdapter
            // 
            this.accToBoatsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessoryTableAdapter = null;
            this.tableAdapterManager.AccToBoatsTableAdapter = this.accToBoatsTableAdapter;
            this.tableAdapterManager.AuthTableAdapter = null;
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
            // accToBoatsBindingNavigator
            // 
            this.accToBoatsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accToBoatsBindingNavigator.BindingSource = this.accToBoatsBindingSource;
            this.accToBoatsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accToBoatsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accToBoatsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accToBoatsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.accToBoatsBindingNavigatorSaveItem});
            this.accToBoatsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accToBoatsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accToBoatsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accToBoatsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accToBoatsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accToBoatsBindingNavigator.Name = "accToBoatsBindingNavigator";
            this.accToBoatsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accToBoatsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.accToBoatsBindingNavigator.TabIndex = 0;
            this.accToBoatsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // accToBoatsBindingNavigatorSaveItem
            // 
            this.accToBoatsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accToBoatsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accToBoatsBindingNavigatorSaveItem.Image")));
            this.accToBoatsBindingNavigatorSaveItem.Name = "accToBoatsBindingNavigatorSaveItem";
            this.accToBoatsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.accToBoatsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.accToBoatsBindingNavigatorSaveItem.Click += new System.EventHandler(this.accToBoatsBindingNavigatorSaveItem_Click);
            // 
            // accToBoatsDataGridView
            // 
            this.accToBoatsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accToBoatsDataGridView.AutoGenerateColumns = false;
            this.accToBoatsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accToBoatsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accToBoatsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.accToBoatsDataGridView.DataSource = this.accToBoatsBindingSource;
            this.accToBoatsDataGridView.Location = new System.Drawing.Point(0, 32);
            this.accToBoatsDataGridView.Name = "accToBoatsDataGridView";
            this.accToBoatsDataGridView.RowHeadersWidth = 51;
            this.accToBoatsDataGridView.RowTemplate.Height = 24;
            this.accToBoatsDataGridView.Size = new System.Drawing.Size(800, 420);
            this.accToBoatsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fit_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fit_ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Accessory_ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Accessory_ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Boat_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Boat_ID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // AccToBoats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accToBoatsDataGridView);
            this.Controls.Add(this.accToBoatsBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccToBoats";
            this.Text = "AccToBoats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccToBoats_FormClosing);
            this.Load += new System.EventHandler(this.AccToBoats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD50DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsBindingNavigator)).EndInit();
            this.accToBoatsBindingNavigator.ResumeLayout(false);
            this.accToBoatsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accToBoatsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD50DataSet bD50DataSet;
        private System.Windows.Forms.BindingSource accToBoatsBindingSource;
        private BD50DataSetTableAdapters.AccToBoatsTableAdapter accToBoatsTableAdapter;
        private BD50DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accToBoatsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton accToBoatsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView accToBoatsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}