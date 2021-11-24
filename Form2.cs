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
    public partial class Form2 : Form
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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "variantDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.variantDataSet.Клиенты);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Добавить
            Clients frm = new Clients();
            frm.ShowDialog();
            if (frm.Upd)
            {
                клиентыTableAdapter.Insert(frm.Client_Name, frm.Client_Adres);
                клиентыTableAdapter.Fill(variantDataSet.Клиенты);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //изменить
            int ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            String Client_Name = dataGridView1.CurrentRow.Cells[1].Value as string;
            String Client_Adres = dataGridView1.CurrentRow.Cells[2].Value as string;
            Clients frm = new Clients();
            frm.Client_Name = Client_Name;
            frm.Client_Adres = Client_Adres;
            frm.ShowDialog();
            if (frm.Upd)
            {
                клиентыTableAdapter.Update(frm.Client_Name, frm.Client_Adres, ID, Client_Name, Client_Adres);
                клиентыTableAdapter.Fill(variantDataSet.Клиенты);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Удалить клиента?", "Вопрос",
 MessageBoxButtons.YesNo,
 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow dgvr = dataGridView1.CurrentRow;
                int ID = Convert.ToInt32(dgvr.Cells[0].Value);
                String Client_Name = dgvr.Cells[1].Value as String;
                String Client_Adres = dgvr.Cells[2].Value as String;

                клиентыTableAdapter.Delete(ID, Client_Name, Client_Adres);
                клиентыTableAdapter.Fill(variantDataSet.Клиенты);
            }
        }

        private void клиентыBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drv = клиентыBindingSource.Current as DataRowView;
            int ID_client = 0;
            if (drv != null)
            {
                ID_client = Convert.ToInt32(drv.Row["Код_клиента"]);
            }
            для_клиентовTableAdapter.Fill(variantDataSet.Для_клиентов, ID_client);
        }

        private void buttonAddReal_Click(object sender, EventArgs e)
        {
            //Добавить покупку
            DataRowView drv = клиентыBindingSource.Current as DataRowView;
            int Client_ID = Convert.ToInt32(drv.Row["Код_клиента"]);
            For_Clients frm = new For_Clients(1);
            frm.ShowDialog();
            if (frm.Upd)
            {
                для_клиентовTableAdapter.Connection.Open(); //Открываем подключение
                //Задаем параметры запроса
                для_клиентовTableAdapter.Adapter.InsertCommand.Parameters["Код_клиента"].Value = Client_ID;
                для_клиентовTableAdapter.Adapter.InsertCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                для_клиентовTableAdapter.Adapter.InsertCommand.Parameters["Код_товара"].Value = frm.Product_ID;
                //Выполняем
                try
                {
                    для_клиентовTableAdapter.Adapter.InsertCommand.ExecuteNonQuery();
                    для_клиентовTableAdapter.Fill(variantDataSet.Для_клиентов, Client_ID);
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно добавить объект");
                }
                для_клиентовTableAdapter.Connection.Close(); //Закрываем подключение

            }
        }

        private void buttonUpdateReal_Click(object sender, EventArgs e)
        {
            //Изменить покупку
            //Код товара Код клиента количество
            DataRowView drv = дляклиентовBindingSource.Current as DataRowView;
            //String Client_Name = Convert.ToString(drv.Row["ФИО"]);
            int ID_CLient = Convert.ToInt32(drv.Row["Код_клиента"]);
            int Count_of_Products = Convert.ToInt32(drv.Row["Количество"]);
            For_Clients frm = new For_Clients(1);
            int ID_product = Convert.ToInt32(drv.Row["Код_товара"]);
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);

            //frm.Client_ID = ID_CLient;

            frm.Count_of_Products = Count_of_Products;
            frm.ShowDialog();
            if (frm.Upd)
            {
                для_клиентовTableAdapter.Connection.Open(); //Открываем подключение
                //Код клиента
                для_клиентовTableAdapter.Adapter.UpdateCommand.Parameters["Код_клиента"].Value = ID_CLient;
                //Код товара
                для_клиентовTableAdapter.Adapter.UpdateCommand.Parameters["Код_товара"].Value = frm.Product_ID;
                //Количество
                для_клиентовTableAdapter.Adapter.UpdateCommand.Parameters["Количество"].Value = frm.Count_of_Products;
                //Код реализации
                для_клиентовTableAdapter.Adapter.UpdateCommand.Parameters["Original_Код_реализации"].Value = Real_ID;

                для_клиентовTableAdapter.Adapter.UpdateCommand.ExecuteNonQuery();
                для_клиентовTableAdapter.Fill(variantDataSet.Для_клиентов, ID_product);
                для_клиентовTableAdapter.Connection.Close();
            }
        }

        private void buttonDeleteReal_Click(object sender, EventArgs e)
        {
            //Удалить покупку
            DataRowView drv = дляклиентовBindingSource.Current as DataRowView;
            int Real_ID = Convert.ToInt32(drv.Row["Код_реализации"]);
            int ID_product = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var result = MessageBox.Show("Удалить покупку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                для_клиентовTableAdapter.Connection.Open(); //Открываем подключение
                для_клиентовTableAdapter.Adapter.DeleteCommand.Parameters["Код_реализации"].Value = Real_ID;
                для_клиентовTableAdapter.Adapter.DeleteCommand.ExecuteNonQuery();
                для_клиентовTableAdapter.Fill(variantDataSet.Для_клиентов, ID_product);
                для_клиентовTableAdapter.Connection.Close();
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
            string[] c = { "A", "B" };
            // Цикл по строкам таблицы
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                // Цикл по столбцам
                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    // Вывод в ячейку i+2, j Excel-я содержимого соответствующей ячейки
                    // dataGridView1 
                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +
                    Convert.ToString(i + 2));
                    excelcells.Value2 = dataGridView1.Rows[i].Cells[j + 1].Value.ToString();
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
            DataRowView drv = клиентыBindingSource.Current as DataRowView;
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
            excelworksheet.Name = Convert.ToString(drv.Row["ФИО"]).Split(' ')[0] + " " + Convert.ToString(drv.Row["ФИО"]).Split(' ')[1];
            // Запишем в ячейку A1
            excelcells = excelworksheet.get_Range("A1", "A1");
            excelcells.Value2 = "Наименование товара";
            excelcells.Font.Bold = 2;
            // Запишем в ячейку B1
            excelcells = excelworksheet.get_Range("B1", "B1");
            excelcells.Value2 = "Цена за единицу товара";
            excelcells.Font.Bold = 2;
            // Запишем в ячейку C1
            excelcells = excelworksheet.get_Range("C1", "C1");
            excelcells.Value2 = "Количество";
            excelcells.Font.Bold = 2;
            // Запишем в ячейку D1
            excelcells = excelworksheet.get_Range("D1", "D1");
            excelcells.Value2 = "Стоимость";
            excelcells.Font.Bold = 2;

            string[] c = { "A", "B", "C", "D"};
            // Цикл по строкам таблицы
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                // Цикл по столбцам
                for (int j = 0; j < c.Length; j++)
                {
                    // Вывод в ячейку i+2, j Excel-я содержимого соответствующей ячейки
                    // dataGridView1 
                    excelcells = excelworksheet.get_Range(c[j] + Convert.ToString(i + 2), c[j] +
                    Convert.ToString(i + 2));
                    excelcells.Value2 = dataGridView2.Rows[i].Cells[j + 3].Value.ToString();
                    excelcells.Font.Size = 13;
                    excelcells.HorizontalAlignment = Excel.Constants.xlCenter;
                } // for
            } // for

            excelcells = excelworksheet.get_Range("A1", "D" +
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
            excelcells = excelworksheet.get_Range("A1", "D" + Convert.ToSingle(dataGridView2.RowCount + 1));
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
            WordRange.InsertAfter("Клиенты и товары, которые они купили\n");
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
            for (клиентыBindingSource.MoveFirst(); i < клиентыBindingSource.Count;
клиентыBindingSource.MoveNext())
            {
                // Получаем доступ к объекту текущая запись таблицы товары
                DataRowView drv1 = клиентыBindingSource.Current as DataRowView;
                int ID_Client= Convert.ToInt32(drv1.Row["Код_клиента"]);
                string Client_Name = Convert.ToString(drv1.Row["ФИО"]);
                string Client_Adres = drv1.Row["Домашний адрес"].ToString();
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
                WordRange.InsertAfter(Client_Name + " Домашний адрес: " + Client_Adres);
                j = 0;
                // Заполним набор данных 
                для_клиентовTableAdapter.Fill(variantDataSet.Для_клиентов, ID_Client);
                for (дляклиентовBindingSource.MoveFirst();
                j < дляклиентовBindingSource.Count;
                дляклиентовBindingSource.MoveNext())
                {
                    // Получаем доступ к объекту текущая запись 
                    DataRowView drv2 = дляклиентовBindingSource.Current as
                    DataRowView;
                    // Получаем значения полей StopNumb, Name
                    int Count = Convert.ToInt32(drv2.Row["Количество"]);
                    int Price = Convert.ToInt32(drv2.Row["Цена_за_единицу_товара"]);
                    int St = Convert.ToInt32(drv2.Row["Стоимость"]);
                    string _Name = drv2.Row["Наименование_товара"].ToString();
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
                    WordRange.InsertAfter("\t" + _Name + "; количество: " + Count + " штук;" + " Цена: " + Price + " рублей;" + " Стоимость: " + St + " рублей");
                    WordRange.Font.Size = 12;
                    WordParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                    j++;
                } // for
                i++;
            }
            WordParagraph = WordParagraphs.Add();
            WordRange.Font.Size = 12;
            WordParagraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
        }
    }
}

