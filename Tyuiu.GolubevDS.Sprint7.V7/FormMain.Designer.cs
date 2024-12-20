namespace Tyuiu.GolubevDS.Sprint7.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxHelper_GDS = new GroupBox();
            buttonHelp_GDS = new Button();
            buttonSave_GDS = new Button();
            buttonOpenBase_GDS = new Button();
            dataGridViewBase_GDS = new DataGridView();
            label_GDS = new Label();
            textBoxFind_GDS = new TextBox();
            buttonFind_GDS = new Button();
            labelInfo_GDS = new Label();
            buttonArea_GDS = new Button();
            buttonKids_GDS = new Button();
            buttonMin_GDS = new Button();
            buttonMax_GDS = new Button();
            textBoxMin_GDS = new TextBox();
            groupBoxFunction_GDS = new GroupBox();
            textBoxMax_GDS = new TextBox();
            groupBoxHelper_GDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GDS).BeginInit();
            groupBoxFunction_GDS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxHelper_GDS
            // 
            groupBoxHelper_GDS.Controls.Add(buttonHelp_GDS);
            groupBoxHelper_GDS.Controls.Add(buttonSave_GDS);
            groupBoxHelper_GDS.Controls.Add(buttonOpenBase_GDS);
            groupBoxHelper_GDS.Location = new Point(12, 12);
            groupBoxHelper_GDS.Name = "groupBoxHelper_GDS";
            groupBoxHelper_GDS.Size = new Size(1299, 84);
            groupBoxHelper_GDS.TabIndex = 0;
            groupBoxHelper_GDS.TabStop = false;
            groupBoxHelper_GDS.Enter += groupBoxHelper_GDS_Enter;
            // 
            // buttonHelp_GDS
            // 
            buttonHelp_GDS.Location = new Point(1199, 26);
            buttonHelp_GDS.Name = "buttonHelp_GDS";
            buttonHelp_GDS.Size = new Size(94, 29);
            buttonHelp_GDS.TabIndex = 2;
            buttonHelp_GDS.Text = "button";
            buttonHelp_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonSave_GDS
            // 
            buttonSave_GDS.Location = new Point(159, 26);
            buttonSave_GDS.Name = "buttonSave_GDS";
            buttonSave_GDS.Size = new Size(94, 29);
            buttonSave_GDS.TabIndex = 1;
            buttonSave_GDS.Text = "5";
            buttonSave_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonOpenBase_GDS
            // 
            buttonOpenBase_GDS.Location = new Point(21, 26);
            buttonOpenBase_GDS.Name = "buttonOpenBase_GDS";
            buttonOpenBase_GDS.Size = new Size(94, 29);
            buttonOpenBase_GDS.TabIndex = 0;
            buttonOpenBase_GDS.Text = "button1";
            buttonOpenBase_GDS.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBase_GDS
            // 
            dataGridViewBase_GDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_GDS.Location = new Point(355, 102);
            dataGridViewBase_GDS.Name = "dataGridViewBase_GDS";
            dataGridViewBase_GDS.RowHeadersWidth = 51;
            dataGridViewBase_GDS.Size = new Size(950, 470);
            dataGridViewBase_GDS.TabIndex = 1;
            // 
            // label_GDS
            // 
            label_GDS.AutoSize = true;
            label_GDS.Location = new Point(98, 13);
            label_GDS.Name = "label_GDS";
            label_GDS.Size = new Size(127, 20);
            label_GDS.TabIndex = 2;
            label_GDS.Text = "Текстовый поиск";
            // 
            // textBoxFind_GDS
            // 
            textBoxFind_GDS.Location = new Point(13, 125);
            textBoxFind_GDS.Name = "textBoxFind_GDS";
            textBoxFind_GDS.Size = new Size(315, 27);
            textBoxFind_GDS.TabIndex = 3;
            // 
            // buttonFind_GDS
            // 
            buttonFind_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFind_GDS.Location = new Point(13, 158);
            buttonFind_GDS.Name = "buttonFind_GDS";
            buttonFind_GDS.Size = new Size(315, 29);
            buttonFind_GDS.TabIndex = 4;
            buttonFind_GDS.Text = "Поиск";
            buttonFind_GDS.UseVisualStyleBackColor = true;
            // 
            // labelInfo_GDS
            // 
            labelInfo_GDS.AutoSize = true;
            labelInfo_GDS.Location = new Point(119, 201);
            labelInfo_GDS.Name = "labelInfo_GDS";
            labelInfo_GDS.Size = new Size(118, 20);
            labelInfo_GDS.TabIndex = 5;
            labelInfo_GDS.Text = "Сортировка по ";
            // 
            // buttonArea_GDS
            // 
            buttonArea_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonArea_GDS.Location = new Point(13, 224);
            buttonArea_GDS.Name = "buttonArea_GDS";
            buttonArea_GDS.Size = new Size(315, 29);
            buttonArea_GDS.TabIndex = 6;
            buttonArea_GDS.Text = "Площади";
            buttonArea_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonKids_GDS
            // 
            buttonKids_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonKids_GDS.Location = new Point(13, 259);
            buttonKids_GDS.Name = "buttonKids_GDS";
            buttonKids_GDS.Size = new Size(315, 29);
            buttonKids_GDS.TabIndex = 7;
            buttonKids_GDS.Text = "Наличию детей";
            buttonKids_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonMin_GDS
            // 
            buttonMin_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMin_GDS.Location = new Point(12, 304);
            buttonMin_GDS.Name = "buttonMin_GDS";
            buttonMin_GDS.Size = new Size(153, 44);
            buttonMin_GDS.TabIndex = 13;
            buttonMin_GDS.Text = "Найти минимальную площадь";
            buttonMin_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonMax_GDS
            // 
            buttonMax_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMax_GDS.Location = new Point(1, 265);
            buttonMax_GDS.Name = "buttonMax_GDS";
            buttonMax_GDS.Size = new Size(152, 45);
            buttonMax_GDS.TabIndex = 9;
            buttonMax_GDS.Text = "Найти максимальную площадь";
            buttonMax_GDS.UseVisualStyleBackColor = true;
            // 
            // textBoxMin_GDS
            // 
            textBoxMin_GDS.Location = new Point(171, 304);
            textBoxMin_GDS.Multiline = true;
            textBoxMin_GDS.Name = "textBoxMin_GDS";
            textBoxMin_GDS.Size = new Size(157, 44);
            textBoxMin_GDS.TabIndex = 14;
            // 
            // groupBoxFunction_GDS
            // 
            groupBoxFunction_GDS.Controls.Add(textBoxMax_GDS);
            groupBoxFunction_GDS.Controls.Add(label_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonMax_GDS);
            groupBoxFunction_GDS.Location = new Point(12, 89);
            groupBoxFunction_GDS.Name = "groupBoxFunction_GDS";
            groupBoxFunction_GDS.Size = new Size(337, 426);
            groupBoxFunction_GDS.TabIndex = 15;
            groupBoxFunction_GDS.TabStop = false;
            // 
            // textBoxMax_GDS
            // 
            textBoxMax_GDS.Location = new Point(159, 265);
            textBoxMax_GDS.Multiline = true;
            textBoxMax_GDS.Name = "textBoxMax_GDS";
            textBoxMax_GDS.Size = new Size(157, 45);
            textBoxMax_GDS.TabIndex = 10;
            textBoxMax_GDS.TextChanged += textBoxMax_GDS_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 765);
            Controls.Add(textBoxMin_GDS);
            Controls.Add(buttonMin_GDS);
            Controls.Add(buttonKids_GDS);
            Controls.Add(buttonArea_GDS);
            Controls.Add(labelInfo_GDS);
            Controls.Add(buttonFind_GDS);
            Controls.Add(textBoxFind_GDS);
            Controls.Add(dataGridViewBase_GDS);
            Controls.Add(groupBoxHelper_GDS);
            Controls.Add(groupBoxFunction_GDS);
            Name = "FormMain";
            Text = "Form1";
            groupBoxHelper_GDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GDS).EndInit();
            groupBoxFunction_GDS.ResumeLayout(false);
            groupBoxFunction_GDS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxHelper_GDS;
        private Button buttonHelp_GDS;
        private Button buttonSave_GDS;
        private Button buttonOpenBase_GDS;
        private DataGridView dataGridViewBase_GDS;
        private Label label_GDS;
        private TextBox textBoxFind_GDS;
        private Button buttonFind_GDS;
        private Label labelInfo_GDS;
        private Button buttonArea_GDS;
        private Button buttonKids_GDS;
        private Button buttonMin_GDS;
        private Button buttonMax_GDS;
        private TextBox textBoxMin_GDS;
        private GroupBox groupBoxFunction_GDS;
        private TextBox textBoxMax_GDS;
    }
}
