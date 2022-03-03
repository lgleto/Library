using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dataGridViewCategories.DataSource = DataSetHelper.GetInstance().DataSetLibrary;
            dataGridViewCategories.DataMember = DataSetHelper.TABLE_CATEGORIES;
            //dataGridViewCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCategories.AutoGenerateColumns = true;
            dataGridViewCategories.AutoResizeColumns();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Category c = new Category(textBoxNameCategory.Text, AgeRange.Age19to99);
            //Category.add(c);
            (new FormAddCategory()).ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {

            var currentRow = dataGridViewCategories.CurrentCell.RowIndex;
            if (currentRow >= 0) {
                Category.remove(currentRow);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridViewCategories.CurrentCell.RowIndex;
            if (currentRow >= 0)
            {
                Category c = Category.get(currentRow);
                (new FormAddCategory(currentRow,  c)).ShowDialog();
            
            }
        }
    }
}
