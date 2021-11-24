
namespace Курсовая_формы
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variantDataSet = new Курсовая_формы.VariantDataSet();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonReal = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодреализацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_клиента = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Код_товара = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длятоваровBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variantDataSet1 = new Курсовая_формы.VariantDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddReal = new System.Windows.Forms.Button();
            this.buttonUpdateReal = new System.Windows.Forms.Button();
            this.buttonDeleteReal = new System.Windows.Forms.Button();
            this.buttonWordAll = new System.Windows.Forms.Button();
            this.buttonExcelAll = new System.Windows.Forms.Button();
            this.товарыTableAdapter = new Курсовая_формы.VariantDataSetTableAdapters.ТоварыTableAdapter();
            this.для_товаровTableAdapter = new Курсовая_формы.VariantDataSetTableAdapters.Для_товаровTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.длятоваровBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.товарыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_товара";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_товара";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_товара";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Цена_за_единицу_товара";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена_за_единицу_товара";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "Товары";
            this.товарыBindingSource.DataSource = this.variantDataSet;
            this.товарыBindingSource.CurrentChanged += new System.EventHandler(this.товарыBindingSource_CurrentChanged);
            // 
            // variantDataSet
            // 
            this.variantDataSet.DataSetName = "VariantDataSet";
            this.variantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(566, 25);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 32);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(566, 64);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(179, 32);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(566, 103);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 32);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Location = new System.Drawing.Point(566, 143);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(179, 32);
            this.buttonClients.TabIndex = 4;
            this.buttonClients.Text = "Клиенты";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonReal
            // 
            this.buttonReal.Location = new System.Drawing.Point(566, 182);
            this.buttonReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReal.Name = "buttonReal";
            this.buttonReal.Size = new System.Drawing.Size(179, 32);
            this.buttonReal.TabIndex = 5;
            this.buttonReal.Text = "Реализация товаров";
            this.buttonReal.UseVisualStyleBackColor = true;
            this.buttonReal.Click += new System.EventHandler(this.buttonReal_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(566, 222);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(179, 32);
            this.buttonExcel.TabIndex = 6;
            this.buttonExcel.Text = "Выгрузить в Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодреализацииDataGridViewTextBoxColumn,
            this.Код_клиента,
            this.Код_товара,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.фИОDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.длятоваровBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 316);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(545, 235);
            this.dataGridView2.TabIndex = 7;
            // 
            // кодреализацииDataGridViewTextBoxColumn
            // 
            this.кодреализацииDataGridViewTextBoxColumn.DataPropertyName = "Код_реализации";
            this.кодреализацииDataGridViewTextBoxColumn.HeaderText = "Код_реализации";
            this.кодреализацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодреализацииDataGridViewTextBoxColumn.Name = "кодреализацииDataGridViewTextBoxColumn";
            this.кодреализацииDataGridViewTextBoxColumn.Visible = false;
            this.кодреализацииDataGridViewTextBoxColumn.Width = 75;
            // 
            // Код_клиента
            // 
            this.Код_клиента.DataPropertyName = "Код_клиента";
            this.Код_клиента.HeaderText = "Код_клиента";
            this.Код_клиента.MinimumWidth = 6;
            this.Код_клиента.Name = "Код_клиента";
            this.Код_клиента.Visible = false;
            this.Код_клиента.Width = 125;
            // 
            // Код_товара
            // 
            this.Код_товара.DataPropertyName = "Код_товара";
            this.Код_товара.HeaderText = "Код_товара";
            this.Код_товара.MinimumWidth = 6;
            this.Код_товара.Name = "Код_товара";
            this.Код_товара.Visible = false;
            this.Код_товара.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Наименование_товара";
            this.dataGridViewTextBoxColumn4.HeaderText = "Наименование_товара";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена_за_единицу_товара";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена_за_единицу_товара";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО клиента";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 200;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // длятоваровBindingSource
            // 
            this.длятоваровBindingSource.DataMember = "Для_товаров";
            this.длятоваровBindingSource.DataSource = this.variantDataSet1;
            // 
            // variantDataSet1
            // 
            this.variantDataSet1.DataSetName = "VariantDataSet";
            this.variantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Клиенты, которым продан этот товар:";
            // 
            // buttonAddReal
            // 
            this.buttonAddReal.Location = new System.Drawing.Point(566, 336);
            this.buttonAddReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddReal.Name = "buttonAddReal";
            this.buttonAddReal.Size = new System.Drawing.Size(179, 32);
            this.buttonAddReal.TabIndex = 9;
            this.buttonAddReal.Text = "Добавить покупку";
            this.buttonAddReal.UseVisualStyleBackColor = true;
            this.buttonAddReal.Click += new System.EventHandler(this.buttonAddReal_Click);
            // 
            // buttonUpdateReal
            // 
            this.buttonUpdateReal.Location = new System.Drawing.Point(566, 376);
            this.buttonUpdateReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateReal.Name = "buttonUpdateReal";
            this.buttonUpdateReal.Size = new System.Drawing.Size(179, 32);
            this.buttonUpdateReal.TabIndex = 10;
            this.buttonUpdateReal.Text = "Изменить покупку";
            this.buttonUpdateReal.UseVisualStyleBackColor = true;
            this.buttonUpdateReal.Click += new System.EventHandler(this.buttonUpdateReal_Click);
            // 
            // buttonDeleteReal
            // 
            this.buttonDeleteReal.Location = new System.Drawing.Point(566, 416);
            this.buttonDeleteReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteReal.Name = "buttonDeleteReal";
            this.buttonDeleteReal.Size = new System.Drawing.Size(179, 32);
            this.buttonDeleteReal.TabIndex = 11;
            this.buttonDeleteReal.Text = "Удалить покупку";
            this.buttonDeleteReal.UseVisualStyleBackColor = true;
            this.buttonDeleteReal.Click += new System.EventHandler(this.buttonDeleteReal_Click);
            // 
            // buttonWordAll
            // 
            this.buttonWordAll.Location = new System.Drawing.Point(566, 496);
            this.buttonWordAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWordAll.Name = "buttonWordAll";
            this.buttonWordAll.Size = new System.Drawing.Size(179, 32);
            this.buttonWordAll.TabIndex = 14;
            this.buttonWordAll.Text = "Выгрузить в Word";
            this.buttonWordAll.UseVisualStyleBackColor = true;
            this.buttonWordAll.Click += new System.EventHandler(this.buttonWordAll_Click);
            // 
            // buttonExcelAll
            // 
            this.buttonExcelAll.Location = new System.Drawing.Point(566, 456);
            this.buttonExcelAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcelAll.Name = "buttonExcelAll";
            this.buttonExcelAll.Size = new System.Drawing.Size(179, 32);
            this.buttonExcelAll.TabIndex = 13;
            this.buttonExcelAll.Text = "Выгрузить в Excel";
            this.buttonExcelAll.UseVisualStyleBackColor = true;
            this.buttonExcelAll.Click += new System.EventHandler(this.buttonExcelAll_Click);
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // для_товаровTableAdapter
            // 
            this.для_товаровTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 578);
            this.Controls.Add(this.buttonWordAll);
            this.Controls.Add(this.buttonExcelAll);
            this.Controls.Add(this.buttonDeleteReal);
            this.Controls.Add(this.buttonUpdateReal);
            this.Controls.Add(this.buttonAddReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonReal);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.длятоваровBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценазаединицутовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private VariantDataSet variantDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private VariantDataSetTableAdapters.ТоварыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonReal;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource длятоваровBindingSource;
        private VariantDataSet variantDataSet1;
        private VariantDataSetTableAdapters.Для_товаровTableAdapter для_товаровTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddReal;
        private System.Windows.Forms.Button buttonUpdateReal;
        private System.Windows.Forms.Button buttonDeleteReal;
        private System.Windows.Forms.Button buttonWordAll;
        private System.Windows.Forms.Button buttonExcelAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодреализацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_клиента;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_товара;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
    }
}

