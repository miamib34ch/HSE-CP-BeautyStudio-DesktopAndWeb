namespace BeautyStudio
{
    partial class AddClient
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label id_типа_кожиLabel;
            System.Windows.Forms.Label противопоказанияLabel;
            System.Windows.Forms.Label примечание_о_клиентеLabel;
            System.Windows.Forms.Label соглашениеLabel;
            System.Windows.Forms.Label как_узнал_о_салонеLabel;
            this.beautyStudioDataSet = new BeautyStudio.BeautyStudioDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new BeautyStudio.BeautyStudioDataSetTableAdapters.TableAdapterManager();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.противопоказанияTextBox = new System.Windows.Forms.TextBox();
            this.примечание_о_клиентеTextBox = new System.Windows.Forms.TextBox();
            this.соглашениеTextBox = new System.Windows.Forms.TextBox();
            this.как_узнал_о_салонеTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.типКожиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тип_кожиTableAdapter = new BeautyStudio.BeautyStudioDataSetTableAdapters.Тип_кожиTableAdapter();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            id_типа_кожиLabel = new System.Windows.Forms.Label();
            противопоказанияLabel = new System.Windows.Forms.Label();
            примечание_о_клиентеLabel = new System.Windows.Forms.Label();
            соглашениеLabel = new System.Windows.Forms.Label();
            как_узнал_о_салонеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типКожиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фамилияLabel.Location = new System.Drawing.Point(15, 18);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(93, 23);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            имяLabel.Location = new System.Drawing.Point(15, 54);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(51, 23);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            отчествоLabel.Location = new System.Drawing.Point(15, 89);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(91, 23);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_телефонаLabel.Location = new System.Drawing.Point(15, 124);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(154, 23);
            номер_телефонаLabel.TabIndex = 9;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рожденияLabel.Location = new System.Drawing.Point(15, 163);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(145, 23);
            дата_рожденияLabel.TabIndex = 11;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // id_типа_кожиLabel
            // 
            id_типа_кожиLabel.AutoSize = true;
            id_типа_кожиLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_типа_кожиLabel.Location = new System.Drawing.Point(15, 199);
            id_типа_кожиLabel.Name = "id_типа_кожиLabel";
            id_типа_кожиLabel.Size = new System.Drawing.Size(95, 23);
            id_типа_кожиLabel.TabIndex = 13;
            id_типа_кожиLabel.Text = "Тип кожи:";
            // 
            // противопоказанияLabel
            // 
            противопоказанияLabel.AutoSize = true;
            противопоказанияLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            противопоказанияLabel.Location = new System.Drawing.Point(15, 253);
            противопоказанияLabel.Name = "противопоказанияLabel";
            противопоказанияLabel.Size = new System.Drawing.Size(175, 23);
            противопоказанияLabel.TabIndex = 15;
            противопоказанияLabel.Text = "Противопоказания:";
            // 
            // примечание_о_клиентеLabel
            // 
            примечание_о_клиентеLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            примечание_о_клиентеLabel.Location = new System.Drawing.Point(15, 317);
            примечание_о_клиентеLabel.Name = "примечание_о_клиентеLabel";
            примечание_о_клиентеLabel.Size = new System.Drawing.Size(154, 48);
            примечание_о_клиентеLabel.TabIndex = 17;
            примечание_о_клиентеLabel.Text = "Примечание о клиенте:";
            // 
            // соглашениеLabel
            // 
            соглашениеLabel.AutoSize = true;
            соглашениеLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            соглашениеLabel.Location = new System.Drawing.Point(15, 404);
            соглашениеLabel.Name = "соглашениеLabel";
            соглашениеLabel.Size = new System.Drawing.Size(116, 23);
            соглашениеLabel.TabIndex = 19;
            соглашениеLabel.Text = "Соглашение:";
            // 
            // как_узнал_о_салонеLabel
            // 
            как_узнал_о_салонеLabel.AutoSize = true;
            как_узнал_о_салонеLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            как_узнал_о_салонеLabel.Location = new System.Drawing.Point(15, 481);
            как_узнал_о_салонеLabel.Name = "как_узнал_о_салонеLabel";
            как_узнал_о_салонеLabel.Size = new System.Drawing.Size(172, 23);
            как_узнал_о_салонеLabel.TabIndex = 21;
            как_узнал_о_салонеLabel.Text = "Как узнал о салоне:";
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
            this.tableAdapterManager.ПосещениеTableAdapter = null;
            this.tableAdapterManager.ПроцедураTableAdapter = null;
            this.tableAdapterManager.Процедуры_в_посещенииTableAdapter = null;
            this.tableAdapterManager.Процедуры_клиентаTableAdapter = null;
            this.tableAdapterManager.СкидкаTableAdapter = null;
            this.tableAdapterManager.Тип_иглыTableAdapter = null;
            this.tableAdapterManager.Тип_кожиTableAdapter = null;
            this.tableAdapterManager.Тип_процедурыTableAdapter = null;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.BackColor = System.Drawing.Color.White;
            this.фамилияTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Фамилия", true));
            this.фамилияTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фамилияTextBox.Location = new System.Drawing.Point(208, 18);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(320, 29);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Имя", true));
            this.имяTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.имяTextBox.Location = new System.Drawing.Point(208, 53);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(320, 29);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Отчество", true));
            this.отчествоTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчествоTextBox.Location = new System.Drawing.Point(208, 88);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(320, 29);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Checked = false;
            this.дата_рожденияDateTimePicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(208, 158);
            this.дата_рожденияDateTimePicker.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.дата_рожденияDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(320, 29);
            this.дата_рожденияDateTimePicker.TabIndex = 12;
            this.дата_рожденияDateTimePicker.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            // 
            // противопоказанияTextBox
            // 
            this.противопоказанияTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.противопоказанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Противопоказания", true));
            this.противопоказанияTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.противопоказанияTextBox.Location = new System.Drawing.Point(208, 228);
            this.противопоказанияTextBox.Multiline = true;
            this.противопоказанияTextBox.Name = "противопоказанияTextBox";
            this.противопоказанияTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.противопоказанияTextBox.Size = new System.Drawing.Size(337, 70);
            this.противопоказанияTextBox.TabIndex = 16;
            // 
            // примечание_о_клиентеTextBox
            // 
            this.примечание_о_клиентеTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.примечание_о_клиентеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Примечание о клиенте", true));
            this.примечание_о_клиентеTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.примечание_о_клиентеTextBox.Location = new System.Drawing.Point(208, 304);
            this.примечание_о_клиентеTextBox.Multiline = true;
            this.примечание_о_клиентеTextBox.Name = "примечание_о_клиентеTextBox";
            this.примечание_о_клиентеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.примечание_о_клиентеTextBox.Size = new System.Drawing.Size(337, 70);
            this.примечание_о_клиентеTextBox.TabIndex = 18;
            // 
            // соглашениеTextBox
            // 
            this.соглашениеTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.соглашениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Соглашение", true));
            this.соглашениеTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.соглашениеTextBox.Location = new System.Drawing.Point(208, 380);
            this.соглашениеTextBox.Multiline = true;
            this.соглашениеTextBox.Name = "соглашениеTextBox";
            this.соглашениеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.соглашениеTextBox.Size = new System.Drawing.Size(337, 70);
            this.соглашениеTextBox.TabIndex = 20;
            // 
            // как_узнал_о_салонеTextBox
            // 
            this.как_узнал_о_салонеTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.как_узнал_о_салонеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Как узнал о салоне", true));
            this.как_узнал_о_салонеTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.как_узнал_о_салонеTextBox.Location = new System.Drawing.Point(208, 456);
            this.как_узнал_о_салонеTextBox.Multiline = true;
            this.как_узнал_о_салонеTextBox.Name = "как_узнал_о_салонеTextBox";
            this.как_узнал_о_салонеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.как_узнал_о_салонеTextBox.Size = new System.Drawing.Size(337, 70);
            this.как_узнал_о_салонеTextBox.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(93, 540);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 30);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(282, 540);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 30);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // типКожиBindingSource
            // 
            this.типКожиBindingSource.DataMember = "Тип кожи";
            this.типКожиBindingSource.DataSource = this.beautyStudioDataSet;
            // 
            // тип_кожиTableAdapter
            // 
            this.тип_кожиTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.клиентBindingSource, "Id типа кожи", true));
            this.comboBoxType.DataSource = this.типКожиBindingSource;
            this.comboBoxType.DisplayMember = "Название типа кожи";
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxType.Location = new System.Drawing.Point(208, 193);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(320, 29);
            this.comboBoxType.TabIndex = 25;
            this.comboBoxType.ValueMember = "Id типа кожи";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Номер телефона", true));
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(208, 123);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(320, 29);
            this.maskedTextBox1.TabIndex = 26;
            // 
            // AddClient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(559, 581);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(id_типа_кожиLabel);
            this.Controls.Add(противопоказанияLabel);
            this.Controls.Add(this.противопоказанияTextBox);
            this.Controls.Add(примечание_о_клиентеLabel);
            this.Controls.Add(this.примечание_о_клиентеTextBox);
            this.Controls.Add(соглашениеLabel);
            this.Controls.Add(this.соглашениеTextBox);
            this.Controls.Add(как_узнал_о_салонеLabel);
            this.Controls.Add(this.как_узнал_о_салонеTextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClient_FormClosing);
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.AddClient_GiveFeedback);
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типКожиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private BeautyStudioDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox противопоказанияTextBox;
        private System.Windows.Forms.TextBox примечание_о_клиентеTextBox;
        private System.Windows.Forms.TextBox соглашениеTextBox;
        private System.Windows.Forms.TextBox как_узнал_о_салонеTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource типКожиBindingSource;
        private BeautyStudioDataSetTableAdapters.Тип_кожиTableAdapter тип_кожиTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}