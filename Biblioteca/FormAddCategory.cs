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
    public partial class FormAddCategory : Form
    {
        Category category;
        int index;

        public FormAddCategory()
        {
            InitializeComponent();
        }

        public FormAddCategory(int index, Category category)
        {
            InitializeComponent();
            this.category = category;
            this.index = index;
            textBoxName.Text = category.Name;
            switch (category.Age) {
                case AgeRange.Age0to5:
                    radioButton0_5.Checked = true;
                    break;
                case AgeRange.Age6to12:
                    radioButton6_12.Checked = true;
                    break;
                case AgeRange.Age13to18:
                    radioButton13_18.Checked = true;
                    break;
                case AgeRange.Age19to99:
                    radioButton19_99.Checked = true;
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
   
            AgeRange age;
            if (radioButton0_5.Checked)
            {
                age = AgeRange.Age0to5;
            }
            else if (radioButton6_12.Checked)
            {
                age = AgeRange.Age6to12;
            }
            else if (radioButton13_18.Checked)
            {
                age = AgeRange.Age13to18;
            }
            else if (radioButton19_99.Checked)
            {
                age = AgeRange.Age19to99;
            }
            else {
                MessageBox.Show(
                   "Tem que selecionar uma idade!",
                   "Alerta",
                   MessageBoxButtons.OK);
               return;
            }

            string name = textBoxName.Text;

            if (category == null)
            {
                Category.add(name, age);
            }
            else 
            {
                Category.update(index, name, age);
            }


            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
