namespace BeautyStudio
{
    partial class test2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test2));
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
            this.посещениеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.посещениеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_посещенияTextBox = new System.Windows.Forms.TextBox();
            this.id_клиентаTextBox = new System.Windows.Forms.TextBox();
            this.дата_и_время_посещенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.итоговая_ценаTextBox = new System.Windows.Forms.TextBox();
            this.id_типа_иглыTextBox = new System.Windows.Forms.TextBox();
            this.примечание_о_посещенииTextBox = new System.Windows.Forms.TextBox();
            this.id_скидкиTextBox = new System.Windows.Forms.TextBox();
            id_посещенияLabel = new System.Windows.Forms.Label();
            id_клиентаLabel = new System.Windows.Forms.Label();
            дата_и_время_посещенияLabel = new System.Windows.Forms.Label();
            итоговая_ценаLabel = new System.Windows.Forms.Label();
            id_типа_иглыLabel = new System.Windows.Forms.Label();
            примечание_о_посещенииLabel = new System.Windows.Forms.Label();
            id_скидкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingNavigator)).BeginInit();
            this.посещениеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
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
            // посещениеBindingNavigator
            // 
            this.посещениеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.посещениеBindingNavigator.BindingSource = this.посещениеBindingSource;
            this.посещениеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.посещениеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.посещениеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.посещениеBindingNavigatorSaveItem});
            this.посещениеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.посещениеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.посещениеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.посещениеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.посещениеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.посещениеBindingNavigator.Name = "посещениеBindingNavigator";
            this.посещениеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.посещениеBindingNavigator.Size = new System.Drawing.Size(868, 25);
            this.посещениеBindingNavigator.TabIndex = 0;
            this.посещениеBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // посещениеBindingNavigatorSaveItem
            // 
            this.посещениеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.посещениеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("посещениеBindingNavigatorSaveItem.Image")));
            this.посещениеBindingNavigatorSaveItem.Name = "посещениеBindingNavigatorSaveItem";
            this.посещениеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.посещениеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.посещениеBindingNavigatorSaveItem.Click += new System.EventHandler(this.посещениеBindingNavigatorSaveItem_Click);
            // 
            // id_посещенияLabel
            // 
            id_посещенияLabel.AutoSize = true;
            id_посещенияLabel.Location = new System.Drawing.Point(500, 217);
            id_посещенияLabel.Name = "id_посещенияLabel";
            id_посещенияLabel.Size = new System.Drawing.Size(79, 13);
            id_посещенияLabel.TabIndex = 1;
            id_посещенияLabel.Text = "Id посещения:";
            // 
            // id_посещенияTextBox
            // 
            this.id_посещенияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id посещения", true));
            this.id_посещенияTextBox.Location = new System.Drawing.Point(648, 214);
            this.id_посещенияTextBox.Name = "id_посещенияTextBox";
            this.id_посещенияTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_посещенияTextBox.TabIndex = 2;
            // 
            // id_клиентаLabel
            // 
            id_клиентаLabel.AutoSize = true;
            id_клиентаLabel.Location = new System.Drawing.Point(500, 243);
            id_клиентаLabel.Name = "id_клиентаLabel";
            id_клиентаLabel.Size = new System.Drawing.Size(63, 13);
            id_клиентаLabel.TabIndex = 3;
            id_клиентаLabel.Text = "Id клиента:";
            // 
            // id_клиентаTextBox
            // 
            this.id_клиентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id клиента", true));
            this.id_клиентаTextBox.Location = new System.Drawing.Point(648, 240);
            this.id_клиентаTextBox.Name = "id_клиентаTextBox";
            this.id_клиентаTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_клиентаTextBox.TabIndex = 4;
            // 
            // дата_и_время_посещенияLabel
            // 
            дата_и_время_посещенияLabel.AutoSize = true;
            дата_и_время_посещенияLabel.Location = new System.Drawing.Point(500, 270);
            дата_и_время_посещенияLabel.Name = "дата_и_время_посещенияLabel";
            дата_и_время_посещенияLabel.Size = new System.Drawing.Size(140, 13);
            дата_и_время_посещенияLabel.TabIndex = 5;
            дата_и_время_посещенияLabel.Text = "Дата и время посещения:";
            // 
            // дата_и_время_посещенияDateTimePicker
            // 
            this.дата_и_время_посещенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.посещениеBindingSource, "Дата и время посещения", true));
            this.дата_и_время_посещенияDateTimePicker.Location = new System.Drawing.Point(648, 266);
            this.дата_и_время_посещенияDateTimePicker.Name = "дата_и_время_посещенияDateTimePicker";
            this.дата_и_время_посещенияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_и_время_посещенияDateTimePicker.TabIndex = 6;
            // 
            // итоговая_ценаLabel
            // 
            итоговая_ценаLabel.AutoSize = true;
            итоговая_ценаLabel.Location = new System.Drawing.Point(500, 295);
            итоговая_ценаLabel.Name = "итоговая_ценаLabel";
            итоговая_ценаLabel.Size = new System.Drawing.Size(85, 13);
            итоговая_ценаLabel.TabIndex = 7;
            итоговая_ценаLabel.Text = "Итоговая цена:";
            // 
            // итоговая_ценаTextBox
            // 
            this.итоговая_ценаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Итоговая цена", true));
            this.итоговая_ценаTextBox.Location = new System.Drawing.Point(648, 292);
            this.итоговая_ценаTextBox.Name = "итоговая_ценаTextBox";
            this.итоговая_ценаTextBox.Size = new System.Drawing.Size(200, 20);
            this.итоговая_ценаTextBox.TabIndex = 8;
            // 
            // id_типа_иглыLabel
            // 
            id_типа_иглыLabel.AutoSize = true;
            id_типа_иглыLabel.Location = new System.Drawing.Point(500, 321);
            id_типа_иглыLabel.Name = "id_типа_иглыLabel";
            id_типа_иглыLabel.Size = new System.Drawing.Size(73, 13);
            id_типа_иглыLabel.TabIndex = 9;
            id_типа_иглыLabel.Text = "Id типа иглы:";
            // 
            // id_типа_иглыTextBox
            // 
            this.id_типа_иглыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id типа иглы", true));
            this.id_типа_иглыTextBox.Location = new System.Drawing.Point(648, 318);
            this.id_типа_иглыTextBox.Name = "id_типа_иглыTextBox";
            this.id_типа_иглыTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_типа_иглыTextBox.TabIndex = 10;
            // 
            // примечание_о_посещенииLabel
            // 
            примечание_о_посещенииLabel.AutoSize = true;
            примечание_о_посещенииLabel.Location = new System.Drawing.Point(500, 347);
            примечание_о_посещенииLabel.Name = "примечание_о_посещенииLabel";
            примечание_о_посещенииLabel.Size = new System.Drawing.Size(142, 13);
            примечание_о_посещенииLabel.TabIndex = 11;
            примечание_о_посещенииLabel.Text = "Примечание о посещении:";
            // 
            // примечание_о_посещенииTextBox
            // 
            this.примечание_о_посещенииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Примечание о посещении", true));
            this.примечание_о_посещенииTextBox.Location = new System.Drawing.Point(648, 344);
            this.примечание_о_посещенииTextBox.Name = "примечание_о_посещенииTextBox";
            this.примечание_о_посещенииTextBox.Size = new System.Drawing.Size(200, 20);
            this.примечание_о_посещенииTextBox.TabIndex = 12;
            // 
            // id_скидкиLabel
            // 
            id_скидкиLabel.AutoSize = true;
            id_скидкиLabel.Location = new System.Drawing.Point(500, 373);
            id_скидкиLabel.Name = "id_скидкиLabel";
            id_скидкиLabel.Size = new System.Drawing.Size(58, 13);
            id_скидкиLabel.TabIndex = 13;
            id_скидкиLabel.Text = "Id скидки:";
            // 
            // id_скидкиTextBox
            // 
            this.id_скидкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.посещениеBindingSource, "Id скидки", true));
            this.id_скидкиTextBox.Location = new System.Drawing.Point(648, 370);
            this.id_скидкиTextBox.Name = "id_скидкиTextBox";
            this.id_скидкиTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_скидкиTextBox.TabIndex = 14;
            // 
            // test2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(id_посещенияLabel);
            this.Controls.Add(this.id_посещенияTextBox);
            this.Controls.Add(id_клиентаLabel);
            this.Controls.Add(this.id_клиентаTextBox);
            this.Controls.Add(дата_и_время_посещенияLabel);
            this.Controls.Add(this.дата_и_время_посещенияDateTimePicker);
            this.Controls.Add(итоговая_ценаLabel);
            this.Controls.Add(this.итоговая_ценаTextBox);
            this.Controls.Add(id_типа_иглыLabel);
            this.Controls.Add(this.id_типа_иглыTextBox);
            this.Controls.Add(примечание_о_посещенииLabel);
            this.Controls.Add(this.примечание_о_посещенииTextBox);
            this.Controls.Add(id_скидкиLabel);
            this.Controls.Add(this.id_скидкиTextBox);
            this.Controls.Add(this.посещениеBindingNavigator);
            this.Name = "test2";
            this.Text = "test2";
            this.Load += new System.EventHandler(this.test2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beautyStudioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.посещениеBindingNavigator)).EndInit();
            this.посещениеBindingNavigator.ResumeLayout(false);
            this.посещениеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BeautyStudioDataSet beautyStudioDataSet;
        private System.Windows.Forms.BindingSource посещениеBindingSource;
        private BeautyStudioDataSetTableAdapters.ПосещениеTableAdapter посещениеTableAdapter;
        private BeautyStudioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator посещениеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton посещениеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_посещенияTextBox;
        private System.Windows.Forms.TextBox id_клиентаTextBox;
        private System.Windows.Forms.DateTimePicker дата_и_время_посещенияDateTimePicker;
        private System.Windows.Forms.TextBox итоговая_ценаTextBox;
        private System.Windows.Forms.TextBox id_типа_иглыTextBox;
        private System.Windows.Forms.TextBox примечание_о_посещенииTextBox;
        private System.Windows.Forms.TextBox id_скидкиTextBox;
    }
}