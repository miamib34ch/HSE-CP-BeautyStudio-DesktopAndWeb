namespace BeautyStudio
{
    partial class test
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
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
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
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.посещениеTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter();
            this.посещениеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процедуры_в_посещенииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_в_посещенииTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter();
            this.процедуры_в_посещенииDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процедуры_клиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_клиентаTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter();
            this.процедуры_клиентаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // beautyStudioDataSet
            // 
            this.beautyStudioDataSet.DataSetName = "BeautyStudioDataSet";
            this.beautyStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.beautyStudioDataSet;
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
            this.tableAdapterManager.ПосещениеTableAdapter = this.посещениеTableAdapter;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Процедуры_в_посещенииTableAdapter = this.процедуры_в_посещенииTableAdapter;
            this.tableAdapterManager.Процедуры_клиентаTableAdapter = this.процедуры_клиентаTableAdapter;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Тип_иглыTableAdapter = null;
            this.tableAdapterManager.Тип_кожиTableAdapter = null;
            this.tableAdapterManager.Тип_процедурыTableAdapter = null;
            // 
            // клиентDataGridView
            // 
            this.клиентDataGridView.AutoGenerateColumns = false;
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
            this.клиентDataGridView.Location = new System.Drawing.Point(3, 2);
            this.клиентDataGridView.Name = "клиентDataGridView";
            this.клиентDataGridView.Size = new System.Drawing.Size(1165, 118);
            this.клиентDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id клиента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id клиента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Номер телефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер телефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id типа кожи";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id типа кожи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Противопоказания";
            this.dataGridViewTextBoxColumn8.HeaderText = "Противопоказания";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Примечание о клиенте";
            this.dataGridViewTextBoxColumn9.HeaderText = "Примечание о клиенте";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Соглашение";
            this.dataGridViewTextBoxColumn10.HeaderText = "Соглашение";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Как узнал о салоне";
            this.dataGridViewTextBoxColumn11.HeaderText = "Как узнал о салоне";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // посещениеBindingSource
            // 
            this.посещениеBindingSource.DataMember = "Посещение";
            this.посещениеBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // посещениеTableAdapter
            // 
            this.посещениеTableAdapter.ClearBeforeFill = true;
            // 
            // посещениеDataGridView
            // 
            this.посещениеDataGridView.AutoGenerateColumns = false;
            this.посещениеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.посещениеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.посещениеDataGridView.DataSource = this.посещениеBindingSource;
            this.посещениеDataGridView.Location = new System.Drawing.Point(3, 126);
            this.посещениеDataGridView.Name = "посещениеDataGridView";
            this.посещениеDataGridView.Size = new System.Drawing.Size(754, 142);
            this.посещениеDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Id посещения";
            this.dataGridViewTextBoxColumn12.HeaderText = "Id посещения";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id клиента";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id клиента";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Дата и время посещения";
            this.dataGridViewTextBoxColumn14.HeaderText = "Дата и время посещения";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Итоговая цена";
            this.dataGridViewTextBoxColumn15.HeaderText = "Итоговая цена";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Id типа иглы";
            this.dataGridViewTextBoxColumn16.HeaderText = "Id типа иглы";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Примечание о посещении";
            this.dataGridViewTextBoxColumn17.HeaderText = "Примечание о посещении";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Id скидки";
            this.dataGridViewTextBoxColumn18.HeaderText = "Id скидки";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // процедуры_в_посещенииBindingSource
            // 
            this.процедуры_в_посещенииBindingSource.DataMember = "Процедуры в посещении";
            this.процедуры_в_посещенииBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // процедуры_в_посещенииTableAdapter
            // 
            this.процедуры_в_посещенииTableAdapter.ClearBeforeFill = true;
            // 
            // процедуры_в_посещенииDataGridView
            // 
            this.процедуры_в_посещенииDataGridView.AutoGenerateColumns = false;
            this.процедуры_в_посещенииDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.процедуры_в_посещенииDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.процедуры_в_посещенииDataGridView.DataSource = this.процедуры_в_посещенииBindingSource;
            this.процедуры_в_посещенииDataGridView.Location = new System.Drawing.Point(3, 274);
            this.процедуры_в_посещенииDataGridView.Name = "процедуры_в_посещенииDataGridView";
            this.процедуры_в_посещенииDataGridView.Size = new System.Drawing.Size(251, 220);
            this.процедуры_в_посещенииDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Id посещения";
            this.dataGridViewTextBoxColumn19.HeaderText = "Id посещения";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn20.HeaderText = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // процедуры_клиентаBindingSource
            // 
            this.процедуры_клиентаBindingSource.DataMember = "Процедуры клиента";
            this.процедуры_клиентаBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // процедуры_клиентаTableAdapter
            // 
            this.процедуры_клиентаTableAdapter.ClearBeforeFill = true;
            // 
            // процедуры_клиентаDataGridView
            // 
            this.процедуры_клиентаDataGridView.AutoGenerateColumns = false;
            this.процедуры_клиентаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.процедуры_клиентаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.процедуры_клиентаDataGridView.DataSource = this.процедуры_клиентаBindingSource;
            this.процедуры_клиентаDataGridView.Location = new System.Drawing.Point(276, 274);
            this.процедуры_клиентаDataGridView.Name = "процедуры_клиентаDataGridView";
            this.процедуры_клиентаDataGridView.Size = new System.Drawing.Size(461, 220);
            this.процедуры_клиентаDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn21.HeaderText = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Id процедуры";
            this.dataGridViewTextBoxColumn22.HeaderText = "Id процедуры";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Id пигмента";
            this.dataGridViewTextBoxColumn23.HeaderText = "Id пигмента";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Примечание о процедуре клиента";
            this.dataGridViewTextBoxColumn24.HeaderText = "Примечание о процедуре клиента";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 718);
            this.Controls.Add(this.процедуры_клиентаDataGridView);
            this.Controls.Add(this.процедуры_в_посещенииDataGridView);
            this.Controls.Add(this.посещениеDataGridView);
            this.Controls.Add(this.клиентDataGridView);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private BeautyStudioDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private System.Windows.Forms.DataGridView клиентDataGridView;
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
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter процедуры_в_посещенииTableAdapter;
        private System.Windows.Forms.DataGridView посещениеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.BindingSource процедуры_в_посещенииBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter процедуры_клиентаTableAdapter;
        private System.Windows.Forms.DataGridView процедуры_в_посещенииDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.BindingSource процедуры_клиентаBindingSource;
        private System.Windows.Forms.DataGridView процедуры_клиентаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    }
}