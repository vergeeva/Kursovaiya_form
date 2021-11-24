
namespace Курсовая_формы
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодклиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийАдресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variantDataSet = new Курсовая_формы.VariantDataSet();
            this.клиентыTableAdapter = new Курсовая_формы.VariantDataSetTableAdapters.КлиентыTableAdapter();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonReal = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодреализацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.домашнийАдресDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиетовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценазаединицутовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дляклиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.для_клиентовTableAdapter = new Курсовая_формы.VariantDataSetTableAdapters.Для_клиентовTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExcelAll = new System.Windows.Forms.Button();
            this.buttonDeleteReal = new System.Windows.Forms.Button();
            this.buttonUpdateReal = new System.Windows.Forms.Button();
            this.buttonAddReal = new System.Windows.Forms.Button();
            this.buttonWordAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дляклиентовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодклиентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.домашнийАдресDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.клиентыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодклиентаDataGridViewTextBoxColumn
            // 
            this.кодклиентаDataGridViewTextBoxColumn.DataPropertyName = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.HeaderText = "Код_клиента";
            this.кодклиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодклиентаDataGridViewTextBoxColumn.Name = "кодклиентаDataGridViewTextBoxColumn";
            this.кодклиентаDataGridViewTextBoxColumn.Visible = false;
            this.кодклиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 200;
            // 
            // домашнийАдресDataGridViewTextBoxColumn
            // 
            this.домашнийАдресDataGridViewTextBoxColumn.DataPropertyName = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn.HeaderText = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.домашнийАдресDataGridViewTextBoxColumn.Name = "домашнийАдресDataGridViewTextBoxColumn";
            this.домашнийАдресDataGridViewTextBoxColumn.Width = 300;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.variantDataSet;
            this.клиентыBindingSource.CurrentChanged += new System.EventHandler(this.клиентыBindingSource_CurrentChanged);
            // 
            // variantDataSet
            // 
            this.variantDataSet.DataSetName = "VariantDataSet";
            this.variantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(614, 102);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 32);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(614, 63);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(179, 32);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Изменить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(614, 24);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(179, 32);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(614, 182);
            this.buttonExcel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(179, 32);
            this.buttonExcel.TabIndex = 8;
            this.buttonExcel.Text = "Выгрузить в Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // buttonReal
            // 
            this.buttonReal.Location = new System.Drawing.Point(614, 142);
            this.buttonReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReal.Name = "buttonReal";
            this.buttonReal.Size = new System.Drawing.Size(179, 32);
            this.buttonReal.TabIndex = 7;
            this.buttonReal.Text = "Реализация товаров";
            this.buttonReal.UseVisualStyleBackColor = true;
            this.buttonReal.Click += new System.EventHandler(this.buttonReal_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодреализацииDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.домашнийАдресDataGridViewTextBoxColumn1,
            this.наименованиетовараDataGridViewTextBoxColumn,
            this.ценазаединицутовараDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.дляклиентовBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(774, 193);
            this.dataGridView2.TabIndex = 9;
            // 
            // кодреализацииDataGridViewTextBoxColumn
            // 
            this.кодреализацииDataGridViewTextBoxColumn.DataPropertyName = "Код_реализации";
            this.кодреализацииDataGridViewTextBoxColumn.HeaderText = "Код_реализации";
            this.кодреализацииDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодреализацииDataGridViewTextBoxColumn.Name = "кодреализацииDataGridViewTextBoxColumn";
            this.кодреализацииDataGridViewTextBoxColumn.Visible = false;
            this.кодреализацииDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.Visible = false;
            this.фИОDataGridViewTextBoxColumn1.Width = 125;
            // 
            // домашнийАдресDataGridViewTextBoxColumn1
            // 
            this.домашнийАдресDataGridViewTextBoxColumn1.DataPropertyName = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn1.HeaderText = "Домашний адрес";
            this.домашнийАдресDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.домашнийАдресDataGridViewTextBoxColumn1.Name = "домашнийАдресDataGridViewTextBoxColumn1";
            this.домашнийАдресDataGridViewTextBoxColumn1.Visible = false;
            this.домашнийАдресDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиетовараDataGridViewTextBoxColumn
            // 
            this.наименованиетовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.HeaderText = "Наименование_товара";
            this.наименованиетовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиетовараDataGridViewTextBoxColumn.Name = "наименованиетовараDataGridViewTextBoxColumn";
            this.наименованиетовараDataGridViewTextBoxColumn.Width = 150;
            // 
            // ценазаединицутовараDataGridViewTextBoxColumn
            // 
            this.ценазаединицутовараDataGridViewTextBoxColumn.DataPropertyName = "Цена_за_единицу_товара";
            this.ценазаединицутовараDataGridViewTextBoxColumn.HeaderText = "Цена_за_единицу_товара";
            this.ценазаединицутовараDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценазаединицутовараDataGridViewTextBoxColumn.Name = "ценазаединицутовараDataGridViewTextBoxColumn";
            this.ценазаединицутовараDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            this.стоимостьDataGridViewTextBoxColumn.Width = 125;
            // 
            // дляклиентовBindingSource
            // 
            this.дляклиентовBindingSource.DataMember = "Для_клиентов";
            this.дляклиентовBindingSource.DataSource = this.variantDataSet;
            // 
            // для_клиентовTableAdapter
            // 
            this.для_клиентовTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-4, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Товары, приобретенные клиентом:";
            // 
            // buttonExcelAll
            // 
            this.buttonExcelAll.Location = new System.Drawing.Point(781, 397);
            this.buttonExcelAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExcelAll.Name = "buttonExcelAll";
            this.buttonExcelAll.Size = new System.Drawing.Size(179, 32);
            this.buttonExcelAll.TabIndex = 15;
            this.buttonExcelAll.Text = "Выгрузить в Excel";
            this.buttonExcelAll.UseVisualStyleBackColor = true;
            this.buttonExcelAll.Click += new System.EventHandler(this.buttonExcelAll_Click);
            // 
            // buttonDeleteReal
            // 
            this.buttonDeleteReal.Location = new System.Drawing.Point(781, 357);
            this.buttonDeleteReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteReal.Name = "buttonDeleteReal";
            this.buttonDeleteReal.Size = new System.Drawing.Size(179, 32);
            this.buttonDeleteReal.TabIndex = 13;
            this.buttonDeleteReal.Text = "Удалить покупку";
            this.buttonDeleteReal.UseVisualStyleBackColor = true;
            this.buttonDeleteReal.Click += new System.EventHandler(this.buttonDeleteReal_Click);
            // 
            // buttonUpdateReal
            // 
            this.buttonUpdateReal.Location = new System.Drawing.Point(781, 318);
            this.buttonUpdateReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateReal.Name = "buttonUpdateReal";
            this.buttonUpdateReal.Size = new System.Drawing.Size(179, 32);
            this.buttonUpdateReal.TabIndex = 12;
            this.buttonUpdateReal.Text = "Изменить покупку";
            this.buttonUpdateReal.UseVisualStyleBackColor = true;
            this.buttonUpdateReal.Click += new System.EventHandler(this.buttonUpdateReal_Click);
            // 
            // buttonAddReal
            // 
            this.buttonAddReal.Location = new System.Drawing.Point(781, 279);
            this.buttonAddReal.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddReal.Name = "buttonAddReal";
            this.buttonAddReal.Size = new System.Drawing.Size(179, 32);
            this.buttonAddReal.TabIndex = 11;
            this.buttonAddReal.Text = "Добавить покупку";
            this.buttonAddReal.UseVisualStyleBackColor = true;
            this.buttonAddReal.Click += new System.EventHandler(this.buttonAddReal_Click);
            // 
            // buttonWordAll
            // 
            this.buttonWordAll.Location = new System.Drawing.Point(781, 437);
            this.buttonWordAll.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWordAll.Name = "buttonWordAll";
            this.buttonWordAll.Size = new System.Drawing.Size(179, 32);
            this.buttonWordAll.TabIndex = 17;
            this.buttonWordAll.Text = "Выгрузить в Word";
            this.buttonWordAll.UseVisualStyleBackColor = true;
            this.buttonWordAll.Click += new System.EventHandler(this.buttonWordAll_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 481);
            this.Controls.Add(this.buttonWordAll);
            this.Controls.Add(this.buttonExcelAll);
            this.Controls.Add(this.buttonDeleteReal);
            this.Controls.Add(this.buttonUpdateReal);
            this.Controls.Add(this.buttonAddReal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonReal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дляклиентовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VariantDataSet variantDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private VariantDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодклиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийАдресDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonReal;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource дляклиентовBindingSource;
        private VariantDataSetTableAdapters.Для_клиентовTableAdapter для_клиентовTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcelAll;
        private System.Windows.Forms.Button buttonDeleteReal;
        private System.Windows.Forms.Button buttonUpdateReal;
        private System.Windows.Forms.Button buttonAddReal;
        private System.Windows.Forms.Button buttonWordAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодреализацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn домашнийАдресDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиетовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценазаединицутовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
    }
}