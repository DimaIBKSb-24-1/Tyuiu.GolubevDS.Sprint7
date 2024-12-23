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
    public partial class FormEdit : Form
    {

        FormMain fmain;
        public FormEdit(FormMain fm)
        {
            InitializeComponent();
            this.fmain = fm;
        }
        private void buttonEdit_GDS_Click(object sender, EventArgs e)
        {
            int a = fmain.dataGridViewBase_GDS.CurrentRow.Index;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[0].Value = textBoxEntranceEnter_GDS.Text;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[1].Value = textBoxFlatEnter_GDS.Text;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[2].Value = textBoxRoomsEnter_GDS.Text;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[3].Value = textBoxSquareEnter_GDS.Text;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[4].Value = textBoxKidsEnter_GDS.Text;
            fmain.dataGridViewBase_GDS.Rows[a].Cells[5].Value = textBoxDebtEnter_GDS.Text;
            this.Close();
        }

        public void textBoxEntranceEnter_GDS_TextChanged(object sender, EventArgs e)
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
    }
}
