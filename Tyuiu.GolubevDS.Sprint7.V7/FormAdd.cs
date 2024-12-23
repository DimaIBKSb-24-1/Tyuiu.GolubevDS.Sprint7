using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GolubevDS.Sprint7.V7
{
    public partial class FormAdd : Form
    {

        FormMain fmain;
        public FormAdd(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }

        private void textBoxEntranceEnter_GDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntranceEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxFlatEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRoomsEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSquareEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxKidsEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxDebtEnter_GDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_GDS_Click(object sender, EventArgs e)
        {
            if ((textBoxKidsEnter_GDS.Text == "") || (textBoxDebtEnter_GDS.Text == ""))
            {
                MessageBox.Show("Введите обязательные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                fmain.dataGridViewBase_GDS.Rows.Add(textBoxEntranceEnter_GDS.Text, textBoxFlatEnter_GDS.Text, textBoxRoomsEnter_GDS.Text, textBoxSquareEnter_GDS.Text, textBoxKidsEnter_GDS.Text, textBoxDebtEnter_GDS.Text);
                this.Close();
            }
        }

        private void textBoxEntrance_GDS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

