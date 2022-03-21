namespace BeautyStudio
{
    partial class Procedure
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
            System.Windows.Forms.Label id_процедурыLabel;
            System.Windows.Forms.Label id_пигментаLabel;
            System.Windows.Forms.Label примечание_о_процедуре_клиентаLabel;
            System.Windows.Forms.Label id_процедуры_клиентаLabel;
            System.Windows.Forms.Label id_посещенияLabel;
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.процедуры_клиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_клиентаTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
            this.btnSave = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.процедураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедураTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПроцедураTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.пигментыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пигментыTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.ПигментыTableAdapter();
            this.процедуры_в_посещенииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.процедуры_в_посещенииTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter();
            this.примечание_о_процедуре_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.id_процедуры_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.id_посещенияTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            id_процедурыLabel = new System.Windows.Forms.Label();
            id_пигментаLabel = new System.Windows.Forms.Label();
            примечание_о_процедуре_клиентаLabel = new System.Windows.Forms.Label();
            id_процедуры_клиентаLabel = new System.Windows.Forms.Label();
            id_посещенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пигментыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_процедурыLabel
            // 
            id_процедурыLabel.AutoSize = true;
            id_процедурыLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_процедурыLabel.Location = new System.Drawing.Point(12, 18);
            id_процедурыLabel.Name = "id_процедурыLabel";
            id_процедурыLabel.Size = new System.Drawing.Size(195, 23);
            id_процедурыLabel.TabIndex = 3;
            id_процедурыLabel.Text = "Название процедуры:";
            // 
            // id_пигментаLabel
            // 
            id_пигментаLabel.AutoSize = true;
            id_пигментаLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_пигментаLabel.Location = new System.Drawing.Point(12, 62);
            id_пигментаLabel.Name = "id_пигментаLabel";
            id_пигментаLabel.Size = new System.Drawing.Size(213, 23);
            id_пигментаLabel.TabIndex = 5;
            id_пигментаLabel.Text = "Используемый пигмент:";
            // 
            // примечание_о_процедуре_клиентаLabel
            // 
            примечание_о_процедуре_клиентаLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            примечание_о_процедуре_клиентаLabel.Location = new System.Drawing.Point(12, 119);
            примечание_о_процедуре_клиентаLabel.Name = "примечание_о_процедуре_клиентаLabel";
            примечание_о_процедуре_клиентаLabel.Size = new System.Drawing.Size(213, 55);
            примечание_о_процедуре_клиентаLabel.TabIndex = 7;
            примечание_о_процедуре_клиентаLabel.Text = "Примечание о процедуре клиента:";
            // 
            // id_процедуры_клиентаLabel
            // 
            id_процедуры_клиентаLabel.AutoSize = true;
            id_процедуры_клиентаLabel.Enabled = false;
            id_процедуры_клиентаLabel.Location = new System.Drawing.Point(255, 152);
            id_процедуры_клиентаLabel.Name = "id_процедуры_клиентаLabel";
            id_процедуры_клиентаLabel.Size = new System.Drawing.Size(121, 13);
            id_процедуры_клиентаLabel.TabIndex = 14;
            id_процедуры_клиентаLabel.Text = "Id процедуры клиента:";
            id_процедуры_клиентаLabel.Visible = false;
            // 
            // id_посещенияLabel
            // 
            id_посещенияLabel.AutoSize = true;
            id_посещенияLabel.Enabled = false;
            id_посещенияLabel.Location = new System.Drawing.Point(265, 126);
            id_посещенияLabel.Name = "id_посещенияLabel";
            id_посещенияLabel.Size = new System.Drawing.Size(79, 13);
            id_посещенияLabel.TabIndex = 12;
            id_посещенияLabel.Text = "Id посещения:";
            id_посещенияLabel.Visible = false;
            // 
            // beautyStudioDataSet
            // 
            this.beautyStudioDataSet.DataSetName = "BeautyStudioDataSet";
            this.beautyStudioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПигментыTableAdapter = null;
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Процедуры_в_посещенииTableAdapter = null;
            this.tableAdapterManager.Процедуры_клиентаTableAdapter = this.процедуры_клиентаTableAdapter;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Тип_иглыTableAdapter = null;
            this.tableAdapterManager.Тип_кожиTableAdapter = null;
            this.tableAdapterManager.Тип_процедурыTableAdapter = null;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(243, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(395, 198);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(147, 31);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.процедуры_клиентаBindingSource, "Id процедуры", true));
            this.comboBox1.DataSource = this.процедураBindingSource;
            this.comboBox1.DisplayMember = "Название процедуры";
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 29);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id процедуры";
            // 
            // процедураBindingSource
            // 
            this.процедураBindingSource.DataMember = "Процедура";
            this.процедураBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // процедураTableAdapter
            // 
            this.процедураTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.процедуры_клиентаBindingSource, "Id пигмента", true));
            this.comboBox2.DataSource = this.пигментыBindingSource;
            this.comboBox2.DisplayMember = "Название пигмента";
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(243, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(299, 29);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Id пигмента";
            // 
            // пигментыBindingSource
            // 
            this.пигментыBindingSource.DataMember = "Пигменты";
            this.пигментыBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // пигментыTableAdapter
            // 
            this.пигментыTableAdapter.ClearBeforeFill = true;
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
            // примечание_о_процедуре_клиентаTextBox
            // 
            this.примечание_о_процедуре_клиентаTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.примечание_о_процедуре_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедуры_клиентаBindingSource, "Примечание о процедуре клиента", true));
            this.примечание_о_процедуре_клиентаTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.примечание_о_процедуре_клиентаTextBox.Location = new System.Drawing.Point(243, 103);
            this.примечание_о_процедуре_клиентаTextBox.Multiline = true;
            this.примечание_о_процедуре_клиентаTextBox.Name = "примечание_о_процедуре_клиентаTextBox";
            this.примечание_о_процедуре_клиентаTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.примечание_о_процедуре_клиентаTextBox.Size = new System.Drawing.Size(316, 87);
            this.примечание_о_процедуре_клиентаTextBox.TabIndex = 3;
            // 
            // id_процедуры_клиентаTextBox
            // 
            this.id_процедуры_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедуры_в_посещенииBindingSource, "Id процедуры клиента", true));
            this.id_процедуры_клиентаTextBox.Enabled = false;
            this.id_процедуры_клиентаTextBox.Location = new System.Drawing.Point(379, 149);
            this.id_процедуры_клиентаTextBox.Name = "id_процедуры_клиентаTextBox";
            this.id_процедуры_клиентаTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_процедуры_клиентаTextBox.TabIndex = 15;
            // 
            // id_посещенияTextBox
            // 
            this.id_посещенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедуры_в_посещенииBindingSource, "Id посещения", true));
            this.id_посещенияTextBox.Enabled = false;
            this.id_посещенияTextBox.Location = new System.Drawing.Point(379, 119);
            this.id_посещенияTextBox.Name = "id_посещенияTextBox";
            this.id_посещенияTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_посещенияTextBox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.процедуры_клиентаBindingSource, "Id процедуры клиента", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(395, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // Procedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 238);
            this.ControlBox = false;
            this.Controls.Add(this.примечание_о_процедуре_клиентаTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_посещенияLabel);
            this.Controls.Add(this.id_посещенияTextBox);
            this.Controls.Add(id_процедуры_клиентаLabel);
            this.Controls.Add(this.id_процедуры_клиентаTextBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(id_процедурыLabel);
            this.Controls.Add(id_пигментаLabel);
            this.Controls.Add(примечание_о_процедуре_клиентаLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Procedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление процедуры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Procedure_FormClosing);
            this.Load += new System.EventHandler(this.Procedure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_клиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пигментыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.процедуры_в_посещенииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private System.Windows.Forms.BindingSource процедуры_клиентаBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_клиентаTableAdapter процедуры_клиентаTableAdapter;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource процедураBindingSource;
        private BeautyStudioDataSetTableAdapters.ПроцедураTableAdapter процедураTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource пигментыBindingSource;
        private BeautyStudioDataSetTableAdapters.ПигментыTableAdapter пигментыTableAdapter;
        private System.Windows.Forms.BindingSource процедуры_в_посещенииBindingSource;
        private BeautyStudioDataSetTableAdapters.Процедуры_в_посещенииTableAdapter процедуры_в_посещенииTableAdapter;
        private System.Windows.Forms.TextBox примечание_о_процедуре_клиентаTextBox;
        private System.Windows.Forms.TextBox id_процедуры_клиентаTextBox;
        private System.Windows.Forms.TextBox id_посещенияTextBox;
        private System.Windows.Forms.TextBox textBox1;

    }
}