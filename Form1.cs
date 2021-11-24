using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Курсовая_формы
{
    public partial class Form1 : Form
    {
        private Excel.Application excelapp; // Программа Excel
        private Excel.Window excelWindow; // Окно программы Excel
        private Excel.Workbooks excelappworkbooks; // Рабочие книги
        private Excel.Workbook excelappworkbook; // Рабочая книга
        private Excel.Sheets excelsheets; // Рабочие листы
        private Excel.Worksheet excelworksheet; // Рабочий лист
        private Excel.Range excelcells; // Диапазон ячеек или ячейка

        private Word.Application WordApp; // Программа Word
        private Word.Documents WordDocuments; // Документы
        private Word.Document WordDocument; // Документ
        private Word.Paragraphs WordParagraphs; // Параграфы
        private Word.Paragraph WordParagraph; // Параграф
        private Word.Range WordRange; // Выделенный диапазон
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "variantDataSet.Товары". При необходимости она может быть перемещена или удалена.
            товарыTableAdapter.Fill(this.variantDataSet.Товары);


        }

        private void товарыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = товарыBindingSource.Current as DataRowView;
            int ID_product = 0;
            if (drv != null)
            {
                ID_product = Convert.ToInt32(drv.Row["Код_товара"]);
            }
            для_товаровTableAdapter.Fill(variantDataSet1.Для_товаров, ID_product);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавить
            Product frm = new Product();
            frm.ShowDialog();
            if (frm.Upd)
            {
                товарыTableAdapter.Insert(frm.Product_Name, frm.Product_Count);
                товарыTableAdapter.Fill(variantDataSet.Товары);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //изменить
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            String Product_Name = dataGridView1.CurrentRow.Cells[1].Value as string;
            int Product_Count = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            Product frm = new Product();
            frm.Product_Name = Product_Name;
            frm.Product_Count = Product_Count;
            frm.ShowDialog();
            if (frm.Upd)
            {
                товарыTableAdapter.Update(frm.Product_Name, frm.Product_Count, ID, Product_Name, Product_Count);
                товарыTableAdapter.Fill(variantDataSet.Товары);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить товар?", "Вопрос",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dataGridView1.CurrentRow;
                int ID = Convert.ToInt32(dgvr.Cells[0].Value);
                String Product_Name = dgvr.Cells[1].Value as String;
                int Product_Count = Convert.ToInt32(dgvr.Cells[2].Value);

                товарыTableAdapter.Delete(ID, Product_Name, Product_Count);
                товарыTableAdapter.Fill(variantDataSet.Товары);
            }
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void buttonAddReal_Click(object sender, EventArgs e)
        {
            //Добавить покупку
            DataRowView drv = товарыBindingSource.Current as DataRowView;
            int Product_ID = Convert.ToInt32(drv.Row["Код_товара"]);
            For_Product frm = new For_Product(1);
            frm.ShowDialog();
            if (frm.Upd)
            {
                для_товаровTableAdapter.Connection.Open(); //Открываем подключение
                //Задаем параметры запроса
                для_товаровTableAdapter.Adapter.InsertCommand.Parameters["Код_товара"].Value = Product_ID;
                для_товаровTableAdapter.Adapter.InsertCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                для_товаровTableAdapter.Adapter.InsertCommand.Parameters["Код_клиента"].Value = frm.Client_ID;
                //Выполняем
                try
                {
                    для_товаровTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    для_товаровTableAdapter.Fill(variantDataSet1.Для_товаров, Product_ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно добавить объект");
                }
                для_товаровTableAdapter.Connection.Close(); //Закрываем подключение

            }
        }

        private void buttonUpdateReal_Click(object sender, EventArgs e)
        {
            //Изменить покупку
            DataRowView drv = длятоваровBindingSource.Current as DataRowView;
            //String Client_Name = Convert.ToString(drv.Row["ФИО"]);
            int ID_CLient = Convert.ToInt32(drv.Row["Код_клиента"]);
            int Count_of_Products = Convert.ToInt32(drv.Row["Количество"]);
            For_Product frm = new For_Product(ID_CLient);
            int ID_product = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);

            //frm.Client_ID = ID_CLient;

            frm.Count_of_Products = Count_of_Products;
            frm.ShowDialog();
            if (frm.Upd)
            {
                для_товаровTableAdapter.Connection.Open(); //Открываем подключение
                //Код клиента
                для_товаровTableAdapter.Adapter.UpdateCommand.Parameters["Код_клиента"].Value = frm.Client_ID;
                //Код товара
                для_товаровTableAdapter.Adapter.UpdateCommand.Parameters["Код_товара"].Value = ID_product;
                //Количество
                для_товаровTableAdapter.Adapter.UpdateCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                //Код реализации
                для_товаровTableAdapter.Adapter.UpdateCommand.Parameters["Original_Код_реализации"].Value = Real_ID;

                для_товаровTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                для_товаровTableAdapter.Fill(variantDataSet1.Для_товаров, ID_product);
                для_товаровTableAdapter.Connection.Close();
            }
        }

        private void buttonDeleteReal_Click(object sender, EventArgs e)
        {
            //Удалить покупку
            DataRowView drv = длятоваровBindingSource.Current as DataRowView;
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);
            int ID_product = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var result = MessageBox.Show("Удалить покупку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                для_товаровTableAdapter.Connection.Open(); //Открываем подключение
                для_товаровTableAdapter.Adapter.DeleteCommand.Parameters["Код_реализации"].Value = Real_ID;
                для_товаровTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                для_товаровTableAdapter.Fill(variantDataSet1.Для_товаров, ID_product);
                для_товаровTableAdapter.Connection.Close();
            }
        }

        private void buttonReal_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //Передать в Excel
            // Запустим Excel
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            // В книге, которую создадим позже, будет 3 листа
            excelapp.SheetsInNewWorkbook = 3;
            // Создадим книгу
            excelapp.Workbooks.Add(Type.Missing);
            // Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            // Получаем ссылку на рабочие листы книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets[1];
            // Сделаем первый лист активным
            excelworksheet.Activate();
            // Запишем в ячейку A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "Наименование товара";
            excelcells.Font.Bold = 2;
            // Запишем в ячейку B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "Цена за единицу товара";
            excelcells.Font.Bold = 2;
            string[] c = { "A", "B"};
            // Цикл по строкам таблицы
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                // Цикл по столбцам
                for (int j = 0; j < dataGridView1.ColumnCount-1; j++)
                {
                    // Вывод в ячейку i+2, j Excel-я содержимого соответствующей ячейки
                    // dataGridView1 
                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +
                    Convert.ToString(i + 2));
                    excelcells.Value2 = dataGridView1.Rows[i].Cells[j+1].Value.ToString();
                    excelcells.Font.Size = 14;
                    excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
                } // for
            } // for

            excelcells = excelworksheet.get_Range("A1", "B" +
Convert.ToSingle(dataGridView1.RowCount));
            Excel.XlBordersIndex bi = Excel.XlBordersIndex.xlInsideVertical;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlInsideHorizontal;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeLeft;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeTop;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeBottom;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeRight;
            excelcells.Borders[bi].LineStyle = 1;
            excelcells = excelworksheet.get_Range("A1", "B" + Convert.ToSingle(dataGridView1.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Font.Size = 14;
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells.Columns.AutoFit();
        }

        private void buttonExcelAll_Click(object sender, EventArgs e)
        {
            DataRowView drv = товарыBindingSource.Current as DataRowView;

            //Передать в Excel
            // Запустим Excel
            excelapp = new Excel.Application();
            // Сделаем Excel видимым
            excelapp.Visible = true;
            // В книге, которую создадим позже, будет 3 листа
            excelapp.SheetsInNewWorkbook = 3;
            // Создадим книгу
            excelapp.Workbooks.Add(Type.Missing);
            // Получаем набор ссылок на объекты Workbook (на созданные книги)
            excelappworkbooks = excelapp.Workbooks;
            //Получаем ссылку на книгу 1 - нумерация от 1
            excelappworkbook = excelappworkbooks[1];
            // Получаем ссылку на рабочие листы книги
            excelsheets = excelappworkbook.Worksheets;
            //Получаем ссылку на лист 1
            excelworksheet = (Excel.Worksheet)excelsheets[1];
            // Сделаем первый лист активным
            excelworksheet.Activate();
            // Запишем в ячейку A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "ФИО клиента";
            excelcells.Font.Bold = 2;
            // Запишем в ячейку B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "Количество товара '" +  Convert.ToString(drv.Row["Наименование_товара"]) + "'";
            excelcells.Font.Bold = 2;
            string[] c = { "A", "B" };
            // Цикл по строкам таблицы
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                // Цикл по столбцам
                for (int j = 0; j < 2; j++)
                {
                    // Вывод в ячейку i+2, j Excel-я содержимого соответствующей ячейки
                    // dataGridView1 
                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +
                    Convert.ToString(i + 2));
                    excelcells.Value2 = dataGridView2.Rows[i].Cells[j + 5].Value.ToString();
                    excelcells.Font.Size = 14;
                    excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
                } // for
            } // for

            excelcells = excelworksheet.get_Range("A1", "B" +
Convert.ToSingle(dataGridView2.RowCount));
            Excel.XlBordersIndex bi = Excel.XlBordersIndex.xlInsideVertical;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlInsideHorizontal;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeLeft;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeTop;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeBottom;
            excelcells.Borders[bi].LineStyle = 1;
            bi = Excel.XlBordersIndex.xlEdgeRight;
            excelcells.Borders[bi].LineStyle = 1;
            excelcells = excelworksheet.get_Range("A1", "B" + Convert.ToSingle(dataGridView2.RowCount + 1));
            // Подгоним ширины столбцов
            excelcells.Font.Size = 14;
            excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
            excelcells.Columns.AutoFit();
        }

        private void buttonWordAll_Click(object sender, EventArgs e)
        {
            // Запускаем Word
            WordApp = new Word.Application();
            // Делаем Word видимым
            WordApp.Visible = true;

            WordDocuments = WordApp.Documents;
            // Добавляем документ
            WordDocument = WordDocuments.Add();

            // Получаем доступ к объекту все параграфы
            WordParagraphs = WordDocument.Content.Paragraphs;
            // Получаем доступ к объекту первый параграф
            WordParagraph = WordParagraphs[1];
            // Устанавливаем выравнивание по центру
            WordParagraph.Alignment =
            Word.WdParagraphAlignment.wdAlignParagraphCenter;
            // Получаем доступ к объекту выделенный участок
            WordRange = WordParagraph.Range;
            // Добавим текст в выделенный участок
            WordRange.InsertAfter("Товары и клиенты, которым они проданы\n");
            // Сделаем шрифт выделенного участка жирным
            WordRange.Font.Bold = 1;
            // Сделаем размер шрифта выделенного участка равным 16
            WordRange.Font.Size = 16;
            // Сбросим выделение участка
            WordRange.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            // Сейчас выделенным участком будет пустой участок в конце текста
            WordRange = WordParagraph.Range;
            // Добавим текст, он будет выделенным участком.
            WordRange.InsertAfter("по состоянию на " +
             DateTime.Now.ToLongDateString() + "\n");
            // Сделаем шрифт выделенного участка нежирным
            WordRange.Font.Bold = 0;
            // Сделаем размер шрифта выделенного участка равным 14
            WordRange.Font.Size = 14;
            int i = 0, j = 0;
            for (товарыBindingSource.MoveFirst(); i < товарыBindingSource.Count;
товарыBindingSource.MoveNext())
            {
                // Получаем доступ к объекту текущая запись таблицы товары
                DataRowView drv1 = товарыBindingSource.Current as DataRowView;
                int ID_Product = Convert.ToInt32(drv1.Row["Код_товара"]);
                string Product_Name = Convert.ToString(drv1.Row["Наименование_товара"]);
                int Product_Price = Convert.ToInt32(drv1.Row["Цена_за_единицу_товара"]);
                // Добавим параграф
                WordParagraph = WordParagraphs.Add();
                // Устанавливаем выравнивание по левой границе
                WordParagraph.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphLeft;
                // Получим доступ к выделенному участку нового параграфа
                WordRange = WordParagraph.Range;
                // Установим шрифт выделенного участка нового параграфа
                WordRange.Font.Bold = 0;
                WordRange.Font.Size = 12;
                // Добавим текст в новый параграф
                WordRange.InsertAfter(Product_Name + " Цена: " + Convert.ToString(Product_Price) + " рублей");
                j = 0;
                // Заполним набор данных 
                для_товаровTableAdapter.Fill(variantDataSet1.Для_товаров, ID_Product);
                for (длятоваровBindingSource.MoveFirst();
                j < длятоваровBindingSource.Count;
                длятоваровBindingSource.MoveNext())
                {
                    // Получаем доступ к объекту текущая запись DataTable1
                    DataRowView drv2 = длятоваровBindingSource.Current as
                    DataRowView;
                    // Получаем значения полей StopNumb, Name
                    int Count = Convert.ToInt32(drv2.Row["Количество"]);
                    string _Name = drv2.Row["ФИО"].ToString();
                    // Добавим параграф
                    WordParagraph = WordParagraphs.Add();
                    // Устанавливаем выравнивание по левой границе
                    WordParagraph.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    // Получим доступ к выделенному участку нового параграфа
                    WordRange = WordParagraph.Range;
                    // Установим шрифт выделенного участка нового параграфа
                    WordRange.Font.Bold = 0;
                    WordRange.Font.Size = 12;
                    // Добавим текст в новый параграф
                    WordRange.InsertAfter("\t" + _Name + "; куплено: " + Convert.ToString(Count) + " штук" );
                    WordRange.Font.Size = 12;
                    WordParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    j++;
                } // for
                i++;
            }
            WordParagraph = WordParagraphs.Add();
            WordParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        }
    }
}
