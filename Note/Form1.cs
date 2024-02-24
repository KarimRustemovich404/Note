using System;
using System.Windows.Forms;

namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Methods
        /// <summary>
        /// Метод для создания файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        /// <summary>
        /// Метод для открытия файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Открыть";
            openFileDialog.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }
        /// <summary>
        /// Метод для сохранения файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog = new SaveFileDialog();
            openFileDialog.Title = "Сохранить";
            openFileDialog.Filter = "Text Documents(*.txt)|*.txt|All Files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = openFileDialog.FileName;
        }
        /// <summary>
        /// Метод для печати файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = printDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }
        /// <summary>
        /// Метод для выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выйтиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Метод для вырезания текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void вырезатьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        /// <summary>
        /// Метод для копирования текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        /// <summary>
        /// Метод для вставки текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        /// <summary>
        /// Метод для изменения шрифта текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }
        /// <summary>
        /// Метод для изменения цвета текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog.Color;
            }
        }
        /// <summary>
        /// Метод для выозва справки о приложении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Котята inc.");
        }
        #endregion
    }
}
