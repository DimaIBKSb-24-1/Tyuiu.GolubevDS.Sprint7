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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxHelper_GDS = new GroupBox();
            buttonHelp_GDS = new Button();
            buttonSave_GDS = new Button();
            buttonOpenBase_GDS = new Button();
            dataGridViewBase_GDS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
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
            buttonAreaGr_GDS = new Button();
            buttonFilterCansel_GDS = new Button();
            comboBoxFilter_GDS = new ComboBox();
            buttonFilter_GDS = new Button();
            textBoxAverage_GDS = new TextBox();
            buttonAverage_GDS = new Button();
            textBoxMax_GDS = new TextBox();
            groupBoxButtons_GDS = new GroupBox();
            buttonEdit_GDS = new Button();
            buttonDelete_GDS = new Button();
            buttonAdd_GDS = new Button();
            buttonViewBase_GDS = new Button();
            chartGr_GDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialogMain_GDS = new OpenFileDialog();
            saveFileDialogMain_GDS = new SaveFileDialog();
            toolTipInfo_GDS = new ToolTip(components);
            groupBoxHelper_GDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GDS).BeginInit();
            groupBoxFunction_GDS.SuspendLayout();
            groupBoxButtons_GDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGr_GDS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxHelper_GDS
            // 
            groupBoxHelper_GDS.Controls.Add(buttonHelp_GDS);
            groupBoxHelper_GDS.Controls.Add(buttonSave_GDS);
            groupBoxHelper_GDS.Controls.Add(buttonOpenBase_GDS);
            groupBoxHelper_GDS.Location = new Point(12, 2);
            groupBoxHelper_GDS.Name = "groupBoxHelper_GDS";
            groupBoxHelper_GDS.Size = new Size(1299, 70);
            groupBoxHelper_GDS.TabIndex = 0;
            groupBoxHelper_GDS.TabStop = false;
            groupBoxHelper_GDS.Enter += groupBoxHelper_GDS_Enter;
            // 
            // buttonHelp_GDS
            // 
            buttonHelp_GDS.Image = (Image)resources.GetObject("buttonHelp_GDS.Image");
            buttonHelp_GDS.Location = new Point(1220, 10);
            buttonHelp_GDS.Name = "buttonHelp_GDS";
            buttonHelp_GDS.Size = new Size(73, 54);
            buttonHelp_GDS.TabIndex = 2;
            buttonHelp_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonSave_GDS
            // 
            buttonSave_GDS.Image = (Image)resources.GetObject("buttonSave_GDS.Image");
            buttonSave_GDS.Location = new Point(107, 17);
            buttonSave_GDS.Name = "buttonSave_GDS";
            buttonSave_GDS.Size = new Size(94, 44);
            buttonSave_GDS.TabIndex = 1;
            buttonSave_GDS.UseVisualStyleBackColor = true;
            buttonSave_GDS.Click += buttonSave_GDS_Click;
            // 
            // buttonOpenBase_GDS
            // 
            buttonOpenBase_GDS.Image = (Image)resources.GetObject("buttonOpenBase_GDS.Image");
            buttonOpenBase_GDS.Location = new Point(6, 17);
            buttonOpenBase_GDS.Name = "buttonOpenBase_GDS";
            buttonOpenBase_GDS.Size = new Size(94, 44);
            buttonOpenBase_GDS.TabIndex = 0;
            buttonOpenBase_GDS.UseVisualStyleBackColor = true;
            buttonOpenBase_GDS.Click += buttonOpenBase_GDS_Click;
            // 
            // dataGridViewBase_GDS
            // 
            dataGridViewBase_GDS.AllowUserToAddRows = false;
            dataGridViewBase_GDS.AllowUserToOrderColumns = true;
            dataGridViewBase_GDS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBase_GDS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_GDS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewBase_GDS.Location = new Point(355, 102);
            dataGridViewBase_GDS.Name = "dataGridViewBase_GDS";
            dataGridViewBase_GDS.RowHeadersWidth = 51;
            dataGridViewBase_GDS.Size = new Size(950, 412);
            dataGridViewBase_GDS.TabIndex = 1;
            dataGridViewBase_GDS.CellContentClick += dataGridViewBase_GDS_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Номер подъезда";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Номер квартиры";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Количество комнат";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Общая площадь";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Есть ли дети";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Есть ли задолженность";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
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
            textBoxFind_GDS.Location = new Point(1, 36);
            textBoxFind_GDS.Name = "textBoxFind_GDS";
            textBoxFind_GDS.Size = new Size(315, 27);
            textBoxFind_GDS.TabIndex = 3;
            // 
            // buttonFind_GDS
            // 
            buttonFind_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFind_GDS.Location = new Point(0, 69);
            buttonFind_GDS.Name = "buttonFind_GDS";
            buttonFind_GDS.Size = new Size(315, 29);
            buttonFind_GDS.TabIndex = 4;
            buttonFind_GDS.Text = "Поиск";
            buttonFind_GDS.UseVisualStyleBackColor = true;
            buttonFind_GDS.Click += buttonFind_GDS_Click;
            // 
            // labelInfo_GDS
            // 
            labelInfo_GDS.AutoSize = true;
            labelInfo_GDS.Location = new Point(107, 101);
            labelInfo_GDS.Name = "labelInfo_GDS";
            labelInfo_GDS.Size = new Size(118, 20);
            labelInfo_GDS.TabIndex = 5;
            labelInfo_GDS.Text = "Сортировка по ";
            // 
            // buttonArea_GDS
            // 
            buttonArea_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonArea_GDS.Location = new Point(0, 124);
            buttonArea_GDS.Name = "buttonArea_GDS";
            buttonArea_GDS.Size = new Size(315, 29);
            buttonArea_GDS.TabIndex = 6;
            buttonArea_GDS.Text = "Площади";
            buttonArea_GDS.UseVisualStyleBackColor = true;
            buttonArea_GDS.Click += buttonArea_GDS_Click;
            // 
            // buttonKids_GDS
            // 
            buttonKids_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonKids_GDS.Location = new Point(0, 159);
            buttonKids_GDS.Name = "buttonKids_GDS";
            buttonKids_GDS.Size = new Size(315, 29);
            buttonKids_GDS.TabIndex = 7;
            buttonKids_GDS.Text = "Наличию детей";
            buttonKids_GDS.UseVisualStyleBackColor = true;
            buttonKids_GDS.Click += buttonKids_GDS_Click;
            // 
            // buttonMin_GDS
            // 
            buttonMin_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMin_GDS.Location = new Point(-1, 194);
            buttonMin_GDS.Name = "buttonMin_GDS";
            buttonMin_GDS.Size = new Size(153, 44);
            buttonMin_GDS.TabIndex = 13;
            buttonMin_GDS.Text = "Найти минимальную площадь";
            buttonMin_GDS.UseVisualStyleBackColor = true;
            buttonMin_GDS.Click += buttonMin_GDS_Click;
            // 
            // buttonMax_GDS
            // 
            buttonMax_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonMax_GDS.Location = new Point(-1, 244);
            buttonMax_GDS.Name = "buttonMax_GDS";
            buttonMax_GDS.Size = new Size(152, 45);
            buttonMax_GDS.TabIndex = 9;
            buttonMax_GDS.Text = "Найти максимальную площадь";
            buttonMax_GDS.UseVisualStyleBackColor = true;
            buttonMax_GDS.Click += buttonMax_GDS_Click;
            // 
            // textBoxMin_GDS
            // 
            textBoxMin_GDS.Location = new Point(159, 194);
            textBoxMin_GDS.Multiline = true;
            textBoxMin_GDS.Name = "textBoxMin_GDS";
            textBoxMin_GDS.Size = new Size(157, 44);
            textBoxMin_GDS.TabIndex = 14;
            // 
            // groupBoxFunction_GDS
            // 
            groupBoxFunction_GDS.Controls.Add(buttonAreaGr_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonFilterCansel_GDS);
            groupBoxFunction_GDS.Controls.Add(comboBoxFilter_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonFilter_GDS);
            groupBoxFunction_GDS.Controls.Add(textBoxAverage_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonMin_GDS);
            groupBoxFunction_GDS.Controls.Add(textBoxMin_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonAverage_GDS);
            groupBoxFunction_GDS.Controls.Add(textBoxMax_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonKids_GDS);
            groupBoxFunction_GDS.Controls.Add(label_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonArea_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonMax_GDS);
            groupBoxFunction_GDS.Controls.Add(labelInfo_GDS);
            groupBoxFunction_GDS.Controls.Add(textBoxFind_GDS);
            groupBoxFunction_GDS.Controls.Add(buttonFind_GDS);
            groupBoxFunction_GDS.Location = new Point(12, 72);
            groupBoxFunction_GDS.Name = "groupBoxFunction_GDS";
            groupBoxFunction_GDS.Size = new Size(319, 648);
            groupBoxFunction_GDS.TabIndex = 15;
            groupBoxFunction_GDS.TabStop = false;
            // 
            // buttonAreaGr_GDS
            // 
            buttonAreaGr_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAreaGr_GDS.Location = new Point(-1, 581);
            buttonAreaGr_GDS.Name = "buttonAreaGr_GDS";
            buttonAreaGr_GDS.Size = new Size(316, 61);
            buttonAreaGr_GDS.TabIndex = 19;
            buttonAreaGr_GDS.Text = "Вывести график полезной площади относительно количества комнат";
            buttonAreaGr_GDS.UseVisualStyleBackColor = true;
            buttonAreaGr_GDS.Click += buttonAreaGr_GDS_Click;
            // 
            // buttonFilterCansel_GDS
            // 
            buttonFilterCansel_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilterCansel_GDS.Location = new Point(1, 397);
            buttonFilterCansel_GDS.Name = "buttonFilterCansel_GDS";
            buttonFilterCansel_GDS.Size = new Size(151, 45);
            buttonFilterCansel_GDS.TabIndex = 18;
            buttonFilterCansel_GDS.Text = "Отменить фильтрацию";
            buttonFilterCansel_GDS.UseVisualStyleBackColor = true;
            buttonFilterCansel_GDS.Click += buttonFilterCansel_GDS_Click;
            // 
            // comboBoxFilter_GDS
            // 
            comboBoxFilter_GDS.FormattingEnabled = true;
            comboBoxFilter_GDS.Items.AddRange(new object[] { "Есть", "Нет" });
            comboBoxFilter_GDS.Location = new Point(158, 355);
            comboBoxFilter_GDS.Name = "comboBoxFilter_GDS";
            comboBoxFilter_GDS.Size = new Size(157, 28);
            comboBoxFilter_GDS.TabIndex = 17;
            // 
            // buttonFilter_GDS
            // 
            buttonFilter_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilter_GDS.Location = new Point(1, 346);
            buttonFilter_GDS.Name = "buttonFilter_GDS";
            buttonFilter_GDS.Size = new Size(151, 45);
            buttonFilter_GDS.TabIndex = 16;
            buttonFilter_GDS.Text = "Фильтрация по задолженности";
            buttonFilter_GDS.UseVisualStyleBackColor = true;
            buttonFilter_GDS.Click += buttonFilter_GDS_Click;
            // 
            // textBoxAverage_GDS
            // 
            textBoxAverage_GDS.Location = new Point(159, 295);
            textBoxAverage_GDS.Multiline = true;
            textBoxAverage_GDS.Name = "textBoxAverage_GDS";
            textBoxAverage_GDS.Size = new Size(157, 45);
            textBoxAverage_GDS.TabIndex = 15;
            // 
            // buttonAverage_GDS
            // 
            buttonAverage_GDS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAverage_GDS.Location = new Point(-1, 295);
            buttonAverage_GDS.Name = "buttonAverage_GDS";
            buttonAverage_GDS.Size = new Size(153, 45);
            buttonAverage_GDS.TabIndex = 11;
            buttonAverage_GDS.Text = "Найти среднее значение площадей";
            buttonAverage_GDS.UseVisualStyleBackColor = true;
            buttonAverage_GDS.Click += buttonAverage_GDS_Click;
            // 
            // textBoxMax_GDS
            // 
            textBoxMax_GDS.Location = new Point(158, 244);
            textBoxMax_GDS.Multiline = true;
            textBoxMax_GDS.Name = "textBoxMax_GDS";
            textBoxMax_GDS.Size = new Size(157, 45);
            textBoxMax_GDS.TabIndex = 10;
            textBoxMax_GDS.TextChanged += textBoxMax_GDS_TextChanged;
            // 
            // groupBoxButtons_GDS
            // 
            groupBoxButtons_GDS.Controls.Add(buttonEdit_GDS);
            groupBoxButtons_GDS.Controls.Add(buttonDelete_GDS);
            groupBoxButtons_GDS.Controls.Add(buttonAdd_GDS);
            groupBoxButtons_GDS.Controls.Add(buttonViewBase_GDS);
            groupBoxButtons_GDS.Location = new Point(12, 726);
            groupBoxButtons_GDS.Name = "groupBoxButtons_GDS";
            groupBoxButtons_GDS.Size = new Size(1298, 90);
            groupBoxButtons_GDS.TabIndex = 16;
            groupBoxButtons_GDS.TabStop = false;
            // 
            // buttonEdit_GDS
            // 
            buttonEdit_GDS.Image = (Image)resources.GetObject("buttonEdit_GDS.Image");
            buttonEdit_GDS.Location = new Point(1229, 26);
            buttonEdit_GDS.Name = "buttonEdit_GDS";
            buttonEdit_GDS.Size = new Size(63, 47);
            buttonEdit_GDS.TabIndex = 3;
            buttonEdit_GDS.UseVisualStyleBackColor = true;
            buttonEdit_GDS.Click += buttonEdit_GDS_Click;
            // 
            // buttonDelete_GDS
            // 
            buttonDelete_GDS.Image = (Image)resources.GetObject("buttonDelete_GDS.Image");
            buttonDelete_GDS.Location = new Point(1146, 25);
            buttonDelete_GDS.Name = "buttonDelete_GDS";
            buttonDelete_GDS.Size = new Size(63, 48);
            buttonDelete_GDS.TabIndex = 2;
            buttonDelete_GDS.UseVisualStyleBackColor = true;
            buttonDelete_GDS.Click += buttonDelete_GDS_Click;
            // 
            // buttonAdd_GDS
            // 
            buttonAdd_GDS.Image = (Image)resources.GetObject("buttonAdd_GDS.Image");
            buttonAdd_GDS.Location = new Point(1064, 26);
            buttonAdd_GDS.Name = "buttonAdd_GDS";
            buttonAdd_GDS.Size = new Size(63, 48);
            buttonAdd_GDS.TabIndex = 1;
            buttonAdd_GDS.UseVisualStyleBackColor = true;
            // 
            // buttonViewBase_GDS
            // 
            buttonViewBase_GDS.Image = (Image)resources.GetObject("buttonViewBase_GDS.Image");
            buttonViewBase_GDS.Location = new Point(16, 26);
            buttonViewBase_GDS.Name = "buttonViewBase_GDS";
            buttonViewBase_GDS.Size = new Size(72, 48);
            buttonViewBase_GDS.TabIndex = 0;
            buttonViewBase_GDS.UseVisualStyleBackColor = true;
            buttonViewBase_GDS.Click += buttonViewBase_GDS_Click;
            // 
            // chartGr_GDS
            // 
            chartArea2.Name = "ChartArea1";
            chartGr_GDS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartGr_GDS.Legends.Add(legend2);
            chartGr_GDS.Location = new Point(355, 520);
            chartGr_GDS.Name = "chartGr_GDS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartGr_GDS.Series.Add(series2);
            chartGr_GDS.Size = new Size(950, 200);
            chartGr_GDS.TabIndex = 17;
            chartGr_GDS.Text = "chart1";
            // 
            // openFileDialogMain_GDS
            // 
            openFileDialogMain_GDS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 817);
            Controls.Add(chartGr_GDS);
            Controls.Add(groupBoxButtons_GDS);
            Controls.Add(dataGridViewBase_GDS);
            Controls.Add(groupBoxHelper_GDS);
            Controls.Add(groupBoxFunction_GDS);
            Name = "FormMain";
            Text = "Домоуправление ";
            groupBoxHelper_GDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_GDS).EndInit();
            groupBoxFunction_GDS.ResumeLayout(false);
            groupBoxFunction_GDS.PerformLayout();
            groupBoxButtons_GDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGr_GDS).EndInit();
            ResumeLayout(false);
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
        private Button buttonAverage_GDS;
        private TextBox textBoxAverage_GDS;
        private Button buttonFilterCansel_GDS;
        private ComboBox comboBoxFilter_GDS;
        private Button buttonFilter_GDS;
        private Button buttonAreaGr_GDS;
        private GroupBox groupBoxButtons_GDS;
        private Button buttonAdd_GDS;
        private Button buttonViewBase_GDS;
        private Button buttonEdit_GDS;
        private Button buttonDelete_GDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGr_GDS;
        private OpenFileDialog openFileDialogMain_GDS;
        private SaveFileDialog saveFileDialogMain_GDS;
        private ToolTip toolTipInfo_GDS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
