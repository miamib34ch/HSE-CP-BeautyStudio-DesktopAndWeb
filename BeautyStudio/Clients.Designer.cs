namespace BeautyStudio
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.клиентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.contextMenuStripClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.посмотретьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПосещениеКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.изменитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            this.contextMenuStripClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // клиентDataGridView
            // 
            this.клиентDataGridView.AllowUserToAddRows = false;
            this.клиентDataGridView.AllowUserToDeleteRows = false;
            this.клиентDataGridView.AutoGenerateColumns = false;
            this.клиентDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.клиентDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.клиентDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.клиентDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.клиентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.клиентDataGridView.DataSource = this.клиентBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.клиентDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.клиентDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.клиентDataGridView.Name = "клиентDataGridView";
            this.клиентDataGridView.ReadOnly = true;
            this.клиентDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.клиентDataGridView.Size = new System.Drawing.Size(1080, 549);
            this.клиентDataGridView.TabIndex = 1;
            this.клиентDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.клиентDataGridView_CellEnter);
            this.клиентDataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.клиентDataGridView_RowContextMenuStripNeeded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id клиента";
            this.dataGridViewTextBoxColumn1.DividerWidth = 2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id клиента";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 52;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер телефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 132;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id типа кожи";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id типа кожи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Противопоказания";
            this.dataGridViewTextBoxColumn8.HeaderText = "Противопоказания";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Примечание о клиенте";
            this.dataGridViewTextBoxColumn9.HeaderText = "Примечание о клиенте";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Соглашение";
            this.dataGridViewTextBoxColumn10.HeaderText = "Соглашение";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Как узнал о салоне";
            this.dataGridViewTextBoxColumn11.HeaderText = "Как узнал о салоне";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // beautyStudioDataSet
            // 
            this.beautyStudioDataSet.DataSetName = "BeautyStudioDataSet";
            this.beautyStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStripClient
            // 
            this.contextMenuStripClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьИнформациюToolStripMenuItem,
            this.добавитьПосещениеКлиентуToolStripMenuItem,
            this.toolStripSeparator1,
            this.изменитьИнформациюToolStripMenuItem,
            this.удалитьКлиентаToolStripMenuItem});
            this.contextMenuStripClient.Name = "contextMenuStripClient";
            this.contextMenuStripClient.ShowImageMargin = false;
            this.contextMenuStripClient.Size = new System.Drawing.Size(402, 136);
            this.contextMenuStripClient.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripClient_Opening);
            // 
            // посмотретьИнформациюToolStripMenuItem
            // 
            this.посмотретьИнформациюToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.посмотретьИнформациюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.посмотретьИнформациюToolStripMenuItem.Name = "посмотретьИнформациюToolStripMenuItem";
            this.посмотретьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.посмотретьИнформациюToolStripMenuItem.Text = "Посмотреть информацию о клиенте";
            // 
            // добавитьПосещениеКлиентуToolStripMenuItem
            // 
            this.добавитьПосещениеКлиентуToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.добавитьПосещениеКлиентуToolStripMenuItem.Name = "добавитьПосещениеКлиентуToolStripMenuItem";
            this.добавитьПосещениеКлиентуToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.добавитьПосещениеКлиентуToolStripMenuItem.Text = "Добавить посещение клиенту";
            this.добавитьПосещениеКлиентуToolStripMenuItem.Click += new System.EventHandler(this.добавитьПосещениеКлиентуToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(398, 6);
            // 
            // изменитьИнформациюToolStripMenuItem
            // 
            this.изменитьИнформациюToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.изменитьИнформациюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.изменитьИнформациюToolStripMenuItem.Name = "изменитьИнформациюToolStripMenuItem";
            this.изменитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.изменитьИнформациюToolStripMenuItem.Text = "Изменить информацию информацию о клиенте";
            this.изменитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.изменитьИнформациюToolStripMenuItem_Click);
            // 
            // удалитьКлиентаToolStripMenuItem
            // 
            this.удалитьКлиентаToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.удалитьКлиентаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьКлиентаToolStripMenuItem.Name = "удалитьКлиентаToolStripMenuItem";
            this.удалитьКлиентаToolStripMenuItem.Size = new System.Drawing.Size(401, 26);
            this.удалитьКлиентаToolStripMenuItem.Text = "Удалить клиента";
            this.удалитьКлиентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьКлиентаToolStripMenuItem_Click);
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.ПигментыTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Процедуры_в_посещенииTableAdapter = null;
            this.tableAdapterManager.Процедуры_клиентаTableAdapter = null;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Тип_иглыTableAdapter = null;
            this.tableAdapterManager.Тип_кожиTableAdapter = null;
            this.tableAdapterManager.Тип_процедурыTableAdapter = null;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 549);
            this.Controls.Add(this.клиентDataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учёт клиентов перманентного макияжа";
            this.Activated += new System.EventHandler(this.Clients_Activated);
            this.Deactivate += new System.EventHandler(this.Clients_Deactivate);
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            this.contextMenuStripClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView клиентDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripClient;
        private System.Windows.Forms.ToolStripMenuItem посмотретьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьКлиентаToolStripMenuItem;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private BeautyStudioDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripMenuItem добавитьПосещениеКлиентуToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

