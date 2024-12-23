namespace Tyuiu.GolubevDS.Sprint7.V7
{
    partial class FormAdd
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
            textBoxEntrance_GDS = new TextBox();
            textBoxFlat_GDS = new TextBox();
            textBoxRooms_GDS = new TextBox();
            textBoxSquare_GDS = new TextBox();
            textBoxKids_GDS = new TextBox();
            textBoxDebt_GDS = new TextBox();
            textBoxEntranceEnter_GDS = new TextBox();
            textBoxFlatEnter_GDS = new TextBox();
            textBoxRoomsEnter_GDS = new TextBox();
            textBoxSquareEnter_GDS = new TextBox();
            textBoxKidsEnter_GDS = new TextBox();
            textBoxDebtEnter_GDS = new TextBox();
            buttonAdd_GDS = new Button();
            SuspendLayout();
            // 
            // textBoxEntrance_GDS
            // 
            textBoxEntrance_GDS.BackColor = SystemColors.Control;
            textBoxEntrance_GDS.BorderStyle = BorderStyle.None;
            textBoxEntrance_GDS.Cursor = Cursors.IBeam;
            textBoxEntrance_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxEntrance_GDS.Location = new Point(12, 12);
            textBoxEntrance_GDS.Name = "textBoxEntrance_GDS";
            textBoxEntrance_GDS.ReadOnly = true;
            textBoxEntrance_GDS.Size = new Size(150, 18);
            textBoxEntrance_GDS.TabIndex = 1;
            textBoxEntrance_GDS.TabStop = false;
            textBoxEntrance_GDS.Text = "Номер подъезда";
            textBoxEntrance_GDS.TextChanged += textBoxEntrance_GDS_TextChanged;
            // 
            // textBoxFlat_GDS
            // 
            textBoxFlat_GDS.BackColor = SystemColors.Control;
            textBoxFlat_GDS.BorderStyle = BorderStyle.None;
            textBoxFlat_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFlat_GDS.Location = new Point(12, 45);
            textBoxFlat_GDS.Name = "textBoxFlat_GDS";
            textBoxFlat_GDS.ReadOnly = true;
            textBoxFlat_GDS.Size = new Size(150, 18);
            textBoxFlat_GDS.TabIndex = 1;
            textBoxFlat_GDS.TabStop = false;
            textBoxFlat_GDS.Text = "Номер квартиры";
            // 
            // textBoxRooms_GDS
            // 
            textBoxRooms_GDS.BackColor = SystemColors.Control;
            textBoxRooms_GDS.BorderStyle = BorderStyle.None;
            textBoxRooms_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRooms_GDS.Location = new Point(12, 78);
            textBoxRooms_GDS.Name = "textBoxRooms_GDS";
            textBoxRooms_GDS.ReadOnly = true;
            textBoxRooms_GDS.Size = new Size(150, 18);
            textBoxRooms_GDS.TabIndex = 2;
            textBoxRooms_GDS.TabStop = false;
            textBoxRooms_GDS.Text = "Количество комнат";
            // 
            // textBoxSquare_GDS
            // 
            textBoxSquare_GDS.BackColor = SystemColors.Control;
            textBoxSquare_GDS.BorderStyle = BorderStyle.None;
            textBoxSquare_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSquare_GDS.Location = new Point(12, 111);
            textBoxSquare_GDS.Name = "textBoxSquare_GDS";
            textBoxSquare_GDS.ReadOnly = true;
            textBoxSquare_GDS.Size = new Size(150, 18);
            textBoxSquare_GDS.TabIndex = 3;
            textBoxSquare_GDS.TabStop = false;
            textBoxSquare_GDS.Text = "Площадь";
            // 
            // textBoxKids_GDS
            // 
            textBoxKids_GDS.BackColor = SystemColors.Control;
            textBoxKids_GDS.BorderStyle = BorderStyle.None;
            textBoxKids_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxKids_GDS.Location = new Point(12, 142);
            textBoxKids_GDS.Name = "textBoxKids_GDS";
            textBoxKids_GDS.ReadOnly = true;
            textBoxKids_GDS.Size = new Size(150, 18);
            textBoxKids_GDS.TabIndex = 4;
            textBoxKids_GDS.TabStop = false;
            textBoxKids_GDS.Text = "Кол-во детей";
            // 
            // textBoxDebt_GDS
            // 
            textBoxDebt_GDS.BackColor = SystemColors.Control;
            textBoxDebt_GDS.BorderStyle = BorderStyle.None;
            textBoxDebt_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDebt_GDS.Location = new Point(12, 173);
            textBoxDebt_GDS.Name = "textBoxDebt_GDS";
            textBoxDebt_GDS.ReadOnly = true;
            textBoxDebt_GDS.Size = new Size(150, 18);
            textBoxDebt_GDS.TabIndex = 5;
            textBoxDebt_GDS.TabStop = false;
            textBoxDebt_GDS.Text = "Задолженность";
            // 
            // textBoxEntranceEnter_GDS
            // 
            textBoxEntranceEnter_GDS.Location = new Point(195, 12);
            textBoxEntranceEnter_GDS.Name = "textBoxEntranceEnter_GDS";
            textBoxEntranceEnter_GDS.Size = new Size(125, 27);
            textBoxEntranceEnter_GDS.TabIndex = 6;
            textBoxEntranceEnter_GDS.TextChanged += textBoxEntranceEnter_GDS_TextChanged;
            textBoxEntranceEnter_GDS.KeyPress += textBoxEntranceEnter_GDS_KeyPress;
            // 
            // textBoxFlatEnter_GDS
            // 
            textBoxFlatEnter_GDS.Location = new Point(195, 43);
            textBoxFlatEnter_GDS.Name = "textBoxFlatEnter_GDS";
            textBoxFlatEnter_GDS.Size = new Size(125, 27);
            textBoxFlatEnter_GDS.TabIndex = 7;
            textBoxFlatEnter_GDS.KeyPress += textBoxFlatEnter_GDS_KeyPress;
            // 
            // textBoxRoomsEnter_GDS
            // 
            textBoxRoomsEnter_GDS.Location = new Point(195, 76);
            textBoxRoomsEnter_GDS.Name = "textBoxRoomsEnter_GDS";
            textBoxRoomsEnter_GDS.Size = new Size(125, 27);
            textBoxRoomsEnter_GDS.TabIndex = 8;
            textBoxRoomsEnter_GDS.KeyPress += textBoxRoomsEnter_GDS_KeyPress;
            // 
            // textBoxSquareEnter_GDS
            // 
            textBoxSquareEnter_GDS.Location = new Point(195, 109);
            textBoxSquareEnter_GDS.Name = "textBoxSquareEnter_GDS";
            textBoxSquareEnter_GDS.Size = new Size(125, 27);
            textBoxSquareEnter_GDS.TabIndex = 9;
            textBoxSquareEnter_GDS.KeyPress += textBoxSquareEnter_GDS_KeyPress;
            // 
            // textBoxKidsEnter_GDS
            // 
            textBoxKidsEnter_GDS.Location = new Point(195, 140);
            textBoxKidsEnter_GDS.Name = "textBoxKidsEnter_GDS";
            textBoxKidsEnter_GDS.Size = new Size(125, 27);
            textBoxKidsEnter_GDS.TabIndex = 10;
            textBoxKidsEnter_GDS.KeyPress += textBoxKidsEnter_GDS_KeyPress;
            // 
            // textBoxDebtEnter_GDS
            // 
            textBoxDebtEnter_GDS.Location = new Point(195, 171);
            textBoxDebtEnter_GDS.Name = "textBoxDebtEnter_GDS";
            textBoxDebtEnter_GDS.Size = new Size(125, 27);
            textBoxDebtEnter_GDS.TabIndex = 11;
            textBoxDebtEnter_GDS.KeyPress += textBoxDebtEnter_GDS_KeyPress;
            // 
            // buttonAdd_GDS
            // 
            buttonAdd_GDS.Location = new Point(91, 221);
            buttonAdd_GDS.Name = "buttonAdd_GDS";
            buttonAdd_GDS.Size = new Size(145, 46);
            buttonAdd_GDS.TabIndex = 12;
            buttonAdd_GDS.Text = "Добавить";
            buttonAdd_GDS.UseVisualStyleBackColor = true;
            buttonAdd_GDS.Click += buttonAdd_GDS_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 293);
            Controls.Add(buttonAdd_GDS);
            Controls.Add(textBoxDebtEnter_GDS);
            Controls.Add(textBoxKidsEnter_GDS);
            Controls.Add(textBoxSquareEnter_GDS);
            Controls.Add(textBoxRoomsEnter_GDS);
            Controls.Add(textBoxFlatEnter_GDS);
            Controls.Add(textBoxEntranceEnter_GDS);
            Controls.Add(textBoxDebt_GDS);
            Controls.Add(textBoxKids_GDS);
            Controls.Add(textBoxSquare_GDS);
            Controls.Add(textBoxRooms_GDS);
            Controls.Add(textBoxFlat_GDS);
            Controls.Add(textBoxEntrance_GDS);
            Name = "FormAdd";
            Text = "Добавление строки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEntrance_GDS;
        private TextBox textBoxFlat_GDS;
        private TextBox textBoxRooms_GDS;
        private TextBox textBoxSquare_GDS;
        private TextBox textBoxKids_GDS;
        private TextBox textBoxDebt_GDS;
        private TextBox textBoxEntranceEnter_GDS;
        private TextBox textBoxFlatEnter_GDS;
        private TextBox textBoxRoomsEnter_GDS;
        private TextBox textBoxSquareEnter_GDS;
        private TextBox textBoxKidsEnter_GDS;
        private TextBox textBoxDebtEnter_GDS;
        private Button buttonAdd_GDS;
    }
}