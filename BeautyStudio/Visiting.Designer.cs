namespace BeautyStudio
{
    partial class Visiting
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
            System.Windows.Forms.Label id_посещенияLabel;
            System.Windows.Forms.Label id_клиентаLabel;
            System.Windows.Forms.Label дата_и_время_посещенияLabel;
            System.Windows.Forms.Label итоговая_ценаLabel;
            System.Windows.Forms.Label id_типа_иглыLabel;
            System.Windows.Forms.Label примечание_о_посещенииLabel;
            System.Windows.Forms.Label id_скидкиLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.посещениеTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
            this.id_посещенияTextBox = new System.Windows.Forms.TextBox();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.итоговая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.примечание_о_посещенииTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.типИглыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_иглыTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Тип_иглыTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.скидкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beautyStudioDataSet1 = new BeautyStudio.BeautyStudioDataSet();
            this.скидкаTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.СкидкаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.процедуры_в_посещенииTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter();
            this.процедуры_клиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_клиентаTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter();
            this.процедуры_клиентаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.процедураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.пигментыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процедураTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПроцедураTableAdapter();
            this.пигментыTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПигментыTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьПроцедуруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            id_посещенияLabel = new System.Windows.Forms.Label();
            id_клиентаLabel = new System.Windows.Forms.Label();
            дата_и_время_посещенияLabel = new System.Windows.Forms.Label();
            итоговая_ценаLabel = new System.Windows.Forms.Label();
            id_типа_иглыLabel = new System.Windows.Forms.Label();
            примечание_о_посещенииLabel = new System.Windows.Forms.Label();
            id_скидкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИглыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пигментыBindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_посещенияLabel
            // 
            id_посещенияLabel.AutoSize = true;
            id_посещенияLabel.Enabled = false;
            id_посещенияLabel.Location = new System.Drawing.Point(413, 80);
            id_посещенияLabel.Name = "id_посещенияLabel";
            id_посещенияLabel.Size = new System.Drawing.Size(79, 13);
            id_посещенияLabel.TabIndex = 1;
            id_посещенияLabel.Text = "Id посещения:";
            id_посещенияLabel.Visible = false;
            // 
            // id_клиентаLabel
            // 
            id_клиентаLabel.AutoSize = true;
            id_клиентаLabel.Enabled = false;
            id_клиентаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            id_клиентаLabel.Location = new System.Drawing.Point(413, 58);
            id_клиентаLabel.Name = "id_клиентаLabel";
            id_клиентаLabel.Size = new System.Drawing.Size(63, 13);
            id_клиентаLabel.TabIndex = 3;
            id_клиентаLabel.Text = "Id клиента:";
            id_клиентаLabel.Visible = false;
            // 
            // дата_и_время_посещенияLabel
            // 
            дата_и_время_посещенияLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_и_время_посещенияLabel.Location = new System.Drawing.Point(12, 14);
            дата_и_время_посещенияLabel.Name = "дата_и_время_посещенияLabel";
            дата_и_время_посещенияLabel.Size = new System.Drawing.Size(151, 49);
            дата_и_время_посещенияLabel.TabIndex = 5;
            дата_и_время_посещенияLabel.Text = "Дата и время посещения:";
            // 
            // итоговая_ценаLabel
            // 
            итоговая_ценаLabel.AutoSize = true;
            итоговая_ценаLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            итоговая_ценаLabel.Location = new System.Drawing.Point(12, 269);
            итоговая_ценаLabel.Name = "итоговая_ценаLabel";
            итоговая_ценаLabel.Size = new System.Drawing.Size(163, 23);
            итоговая_ценаLabel.TabIndex = 7;
            итоговая_ценаLabel.Text = "Итоговая цена (₽):";
            // 
            // id_типа_иглыLabel
            // 
            id_типа_иглыLabel.AutoSize = true;
            id_типа_иглыLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_типа_иглыLabel.Location = new System.Drawing.Point(12, 77);
            id_типа_иглыLabel.Name = "id_типа_иглыLabel";
            id_типа_иглыLabel.Size = new System.Drawing.Size(92, 23);
            id_типа_иглыLabel.TabIndex = 9;
            id_типа_иглыLabel.Text = "Тип иглы:";
            // 
            // примечание_о_посещенииLabel
            // 
            примечание_о_посещенииLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            примечание_о_посещенииLabel.Location = new System.Drawing.Point(12, 136);
            примечание_о_посещенииLabel.Name = "примечание_о_посещенииLabel";
            примечание_о_посещенииLabel.Size = new System.Drawing.Size(151, 55);
            примечание_о_посещенииLabel.TabIndex = 11;
            примечание_о_посещенииLabel.Text = "Примечание о посещении:";
            // 
            // id_скидкиLabel
            // 
            id_скидкиLabel.AutoSize = true;
            id_скидкиLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_скидкиLabel.Location = new System.Drawing.Point(12, 234);
            id_скидкиLabel.Name = "id_скидкиLabel";
            id_скидкиLabel.Size = new System.Drawing.Size(104, 23);
            id_скидкиLabel.TabIndex = 13;
            id_скидкиLabel.Text = "Скидка (₽):";
            // 
            // beautyStudioDataSet
            // 
            this.beautyStudioDataSet.DataSetName = "BeautyStudioDataSet";
            this.beautyStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПигментыTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = this.посещениеTableAdapter;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Процедуры_в_посещенииTableAdapter = null;
            this.tableAdapterManager.Процедуры_клиентаTableAdapter = null;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Тип_иглыTableAdapter = null;
            this.tableAdapterManager.Тип_кожиTableAdapter = null;
            this.tableAdapterManager.Тип_процедурыTableAdapter = null;
            // 
            // id_посещенияTextBox
            // 
            this.id_посещенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id посещения", true));
            this.id_посещенияTextBox.Enabled = false;
            this.id_посещенияTextBox.Location = new System.Drawing.Point(514, 77);
            this.id_посещенияTextBox.Name = "id_посещенияTextBox";
            this.id_посещенияTextBox.Size = new System.Drawing.Size(46, 20);
            this.id_посещенияTextBox.TabIndex = 2;
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id клиента", true));
            this.id_клиентаTextBox.Enabled = false;
            this.id_клиентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.id_клиентаTextBox.Location = new System.Drawing.Point(486, 51);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(74, 20);
            this.id_клиентаTextBox.TabIndex = 4;
            // 
            // итоговая_ценаTextBox
            // 
            this.итоговая_ценаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.итоговая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Итоговая цена", true));
            this.итоговая_ценаTextBox.Enabled = false;
            this.итоговая_ценаTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.итоговая_ценаTextBox.Location = new System.Drawing.Point(179, 269);
            this.итоговая_ценаTextBox.Name = "итоговая_ценаTextBox";
            this.итоговая_ценаTextBox.Size = new System.Drawing.Size(200, 29);
            this.итоговая_ценаTextBox.TabIndex = 9;
            // 
            // примечание_о_посещенииTextBox
            // 
            this.примечание_о_посещенииTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.примечание_о_посещенииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Примечание о посещении", true));
            this.примечание_о_посещенииTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.примечание_о_посещенииTextBox.Location = new System.Drawing.Point(179, 136);
            this.примечание_о_посещенииTextBox.Multiline = true;
            this.примечание_о_посещенииTextBox.Name = "примечание_о_посещенииTextBox";
            this.примечание_о_посещенииTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.примечание_о_посещенииTextBox.Size = new System.Drawing.Size(217, 67);
            this.примечание_о_посещенииTextBox.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.посещениеBindingSource, "Id типа иглы", true));
            this.comboBox1.DataSource = this.типИглыBindingSource;
            this.comboBox1.DisplayMember = "Название типа иглы";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Id типа иглы";
            // 
            // типИглыBindingSource
            // 
            this.типИглыBindingSource.DataMember = "Тип иглы";
            this.типИглыBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // тип_иглыTableAdapter
            // 
            this.тип_иглыTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.посещениеBindingSource, "Id скидки", true));
            this.comboBox2.DataSource = this.скидкаBindingSource;
            this.comboBox2.DisplayMember = "Размер скидки";
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(179, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 29);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Id скидки";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // скидкаBindingSource
            // 
            this.скидкаBindingSource.DataMember = "Скидка";
            this.скидкаBindingSource.DataSource = this.beautyStudioDataSet1;
            // 
            // beautyStudioDataSet1
            // 
            this.beautyStudioDataSet1.DataSetName = "BeautyStudioDataSet";
            this.beautyStudioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // скидкаTableAdapter
            // 
            this.скидкаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(398, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Процедуры:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(630, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить процедуру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addProcedure_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(402, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Сохранить посещение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(630, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // процедуры_в_посещенииTableAdapter
            // 
            this.процедуры_в_посещенииTableAdapter.ClearBeforeFill = true;
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
            this.процедуры_клиентаDataGridView.AllowUserToAddRows = false;
            this.процедуры_клиентаDataGridView.AllowUserToDeleteRows = false;
            this.процедуры_клиентаDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.процедуры_клиентаDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.процедуры_клиентаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.процедуры_клиентаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.процедуры_клиентаDataGridView.DataSource = this.процедуры_клиентаBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.процедуры_клиентаDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.процедуры_клиентаDataGridView.Location = new System.Drawing.Point(402, 37);
            this.процедуры_клиентаDataGridView.Name = "процедуры_клиентаDataGridView";
            this.процедуры_клиентаDataGridView.ReadOnly = true;
            this.процедуры_клиентаDataGridView.Size = new System.Drawing.Size(448, 163);
            this.процедуры_клиентаDataGridView.TabIndex = 8;
            this.процедуры_клиентаDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.процедуры_клиентаDataGridView_DataError);
            this.процедуры_клиентаDataGridView.RowContextMenuStripNeeded += new System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventHandler(this.процедуры_клиентаDataGridView_RowContextMenuStripNeeded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn1.DividerWidth = 2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id процедуры клиента";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id процедуры";
            this.dataGridViewTextBoxColumn2.DataSource = this.процедураBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Название процедуры";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id процедуры";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id процедуры";
            this.dataGridViewTextBoxColumn2.Width = 92;
            // 
            // процедураBindingSource
            // 
            this.процедураBindingSource.DataMember = "Процедура";
            this.процедураBindingSource.DataSource = this.beautyStudioDataSet1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id пигмента";
            this.dataGridViewTextBoxColumn3.DataSource = this.пигментыBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Название пигмента";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Id пигмента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id пигмента";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // пигментыBindingSource
            // 
            this.пигментыBindingSource.DataMember = "Пигменты";
            this.пигментыBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Примечание о процедуре клиента";
            this.dataGridViewTextBoxColumn4.HeaderText = "Примечание о процедуре клиента";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 166;
            // 
            // процедураTableAdapter
            // 
            this.процедураTableAdapter.ClearBeforeFill = true;
            // 
            // пигментыTableAdapter
            // 
            this.пигментыTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьПроцедуруToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 26);
            // 
            // удалитьПроцедуруToolStripMenuItem
            // 
            this.удалитьПроцедуруToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.удалитьПроцедуруToolStripMenuItem.Name = "удалитьПроцедуруToolStripMenuItem";
            this.удалитьПроцедуруToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.удалитьПроцедуруToolStripMenuItem.Text = "Удалить процедуру";
            this.удалитьПроцедуруToolStripMenuItem.Click += new System.EventHandler(this.удалитьПроцедуруToolStripMenuItem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Дата и время посещения", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(179, 18);
            this.maskedTextBox1.Mask = "00/00/0000 90:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 29);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Visiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 311);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.процедуры_клиентаDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_посещенияLabel);
            this.Controls.Add(this.id_посещенияTextBox);
            this.Controls.Add(id_клиентаLabel);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(дата_и_время_посещенияLabel);
            this.Controls.Add(итоговая_ценаLabel);
            this.Controls.Add(this.итоговая_ценаTextBox);
            this.Controls.Add(id_типа_иглыLabel);
            this.Controls.Add(примечание_о_посещенииLabel);
            this.Controls.Add(this.примечание_о_посещенииTextBox);
            this.Controls.Add(id_скидкиLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Visiting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Посещение";
            this.Activated += new System.EventHandler(this.Visiting_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Visiting_FormClosing);
            this.Load += new System.EventHandler(this.Visiting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИглыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пигментыBindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_посещенияTextBox;
        private System.Windows.Forms.TextBox id_клиентаTextBox;
        private System.Windows.Forms.TextBox итоговая_ценаTextBox;
        private System.Windows.Forms.TextBox примечание_о_посещенииTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource типИглыBindingSource;
        private BeautyStudioDataSetTableAdapters.Тип_иглыTableAdapter тип_иглыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private BeautyStudioDataSetTableAdapters.СкидкаTableAdapter скидкаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter процедуры_в_посещенииTableAdapter;
        private System.Windows.Forms.BindingSource процедуры_клиентаBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter процедуры_клиентаTableAdapter;
        private System.Windows.Forms.DataGridView процедуры_клиентаDataGridView;
        private BeautyStudioDataSetTableAdapters.ПроцедураTableAdapter процедураTableAdapter;
        private System.Windows.Forms.BindingSource пигментыBindingSource;
        private BeautyStudioDataSetTableAdapters.ПигментыTableAdapter пигментыTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьПроцедуруToolStripMenuItem;
        private BeautyStudioDataSet beautyStudioDataSet1;
        private System.Windows.Forms.BindingSource скидкаBindingSource;
        private System.Windows.Forms.BindingSource процедураBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}