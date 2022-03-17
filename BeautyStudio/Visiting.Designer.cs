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
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.посещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.посещениеTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
            this.id_посещенияTextBox = new System.Windows.Forms.TextBox();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.дата_и_время_посещенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.итоговая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.примечание_о_посещенииTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.типИглыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_иглыTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Тип_иглыTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.скидкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.скидкаTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.СкидкаTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fKПроцедурыВПосещенииПосещениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_в_посещенииTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter();
            id_посещенияLabel = new System.Windows.Forms.Label();
            id_клиентаLabel = new System.Windows.Forms.Label();
            дата_и_время_посещенияLabel = new System.Windows.Forms.Label();
            итоговая_ценаLabel = new System.Windows.Forms.Label();
            id_типа_иглыLabel = new System.Windows.Forms.Label();
            примечание_о_посещенииLabel = new System.Windows.Forms.Label();
            id_скидкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИглыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыВПосещенииПосещениеBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_посещенияLabel
            // 
            id_посещенияLabel.AutoSize = true;
            id_посещенияLabel.Enabled = false;
            id_посещенияLabel.Location = new System.Drawing.Point(403, 80);
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
            id_клиентаLabel.Location = new System.Drawing.Point(403, 58);
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
            итоговая_ценаLabel.Size = new System.Drawing.Size(136, 23);
            итоговая_ценаLabel.TabIndex = 7;
            итоговая_ценаLabel.Text = "Итоговая цена:";
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
            id_скидкиLabel.Size = new System.Drawing.Size(77, 23);
            id_скидкиLabel.TabIndex = 13;
            id_скидкиLabel.Text = "Скидка:";
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
            this.id_посещенияTextBox.Location = new System.Drawing.Point(504, 77);
            this.id_посещенияTextBox.Name = "id_посещенияTextBox";
            this.id_посещенияTextBox.Size = new System.Drawing.Size(46, 20);
            this.id_посещенияTextBox.TabIndex = 2;
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id клиента", true));
            this.id_клиентаTextBox.Enabled = false;
            this.id_клиентаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.id_клиентаTextBox.Location = new System.Drawing.Point(476, 51);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(74, 20);
            this.id_клиентаTextBox.TabIndex = 4;
            // 
            // дата_и_время_посещенияDateTimePicker
            // 
            this.дата_и_время_посещенияDateTimePicker.CustomFormat = "";
            this.дата_и_время_посещенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.посещениеBindingSource, "Дата и время посещения", true));
            this.дата_и_время_посещенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Дата и время посещения", true));
            this.дата_и_время_посещенияDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_и_время_посещенияDateTimePicker.Location = new System.Drawing.Point(169, 14);
            this.дата_и_время_посещенияDateTimePicker.Name = "дата_и_время_посещенияDateTimePicker";
            this.дата_и_время_посещенияDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.дата_и_время_посещенияDateTimePicker.TabIndex = 6;
            // 
            // итоговая_ценаTextBox
            // 
            this.итоговая_ценаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.итоговая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Итоговая цена", true));
            this.итоговая_ценаTextBox.Enabled = false;
            this.итоговая_ценаTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.итоговая_ценаTextBox.Location = new System.Drawing.Point(169, 269);
            this.итоговая_ценаTextBox.Name = "итоговая_ценаTextBox";
            this.итоговая_ценаTextBox.Size = new System.Drawing.Size(200, 29);
            this.итоговая_ценаTextBox.TabIndex = 8;
            // 
            // примечание_о_посещенииTextBox
            // 
            this.примечание_о_посещенииTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.примечание_о_посещенииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Примечание о посещении", true));
            this.примечание_о_посещенииTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.примечание_о_посещенииTextBox.Location = new System.Drawing.Point(169, 136);
            this.примечание_о_посещенииTextBox.Multiline = true;
            this.примечание_о_посещенииTextBox.Name = "примечание_о_посещенииTextBox";
            this.примечание_о_посещенииTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.примечание_о_посещенииTextBox.Size = new System.Drawing.Size(217, 67);
            this.примечание_о_посещенииTextBox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(448, 162);
            this.dataGridView1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.посещениеBindingSource, "Id типа иглы", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типИглыBindingSource, "Название типа иглы", true));
            this.comboBox1.DataSource = this.типИглыBindingSource;
            this.comboBox1.DisplayMember = "Название типа иглы";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 29);
            this.comboBox1.TabIndex = 16;
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
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.скидкаBindingSource, "Название скидки", true));
            this.comboBox2.DataSource = this.скидкаBindingSource;
            this.comboBox2.DisplayMember = "Название скидки";
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(169, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 29);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "Id скидки";
            // 
            // скидкаBindingSource
            // 
            this.скидкаBindingSource.DataMember = "Скидка";
            this.скидкаBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // скидкаTableAdapter
            // 
            this.скидкаTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(388, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Процедуры:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(619, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить процедуру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addProcedure_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(392, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сохранить посещение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(620, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Отмена";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // fKПроцедурыВПосещенииПосещениеBindingSource
            // 
            this.fKПроцедурыВПосещенииПосещениеBindingSource.DataMember = "FK_Процедуры в посещении_Посещение";
            this.fKПроцедурыВПосещенииПосещениеBindingSource.DataSource = this.посещениеBindingSource;
            // 
            // процедуры_в_посещенииTableAdapter
            // 
            this.процедуры_в_посещенииTableAdapter.ClearBeforeFill = true;
            // 
            // Visiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 314);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(id_посещенияLabel);
            this.Controls.Add(this.id_посещенияTextBox);
            this.Controls.Add(id_клиентаLabel);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(дата_и_время_посещенияLabel);
            this.Controls.Add(this.дата_и_время_посещенияDateTimePicker);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типИглыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.скидкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKПроцедурыВПосещенииПосещениеBindingSource)).EndInit();
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
        private System.Windows.Forms.DateTimePicker дата_и_время_посещенияDateTimePicker;
        private System.Windows.Forms.TextBox итоговая_ценаTextBox;
        private System.Windows.Forms.TextBox примечание_о_посещенииTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource типИглыBindingSource;
        private BeautyStudioDataSetTableAdapters.Тип_иглыTableAdapter тип_иглыTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource скидкаBindingSource;
        private BeautyStudioDataSetTableAdapters.СкидкаTableAdapter скидкаTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource fKПроцедурыВПосещенииПосещениеBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter процедуры_в_посещенииTableAdapter;
    }
}