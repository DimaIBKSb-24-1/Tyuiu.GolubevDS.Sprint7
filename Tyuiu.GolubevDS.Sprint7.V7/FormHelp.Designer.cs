namespace Tyuiu.GolubevDS.Sprint7.V7
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxInfoHelp_GDS = new TextBox();
            pictureBoxInfo_GDS = new PictureBox();
            textBoxInfo_GDS = new TextBox();
            buttonClose_GDS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_GDS).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfoHelp_GDS
            // 
            textBoxInfoHelp_GDS.BackColor = SystemColors.Control;
            textBoxInfoHelp_GDS.BorderStyle = BorderStyle.None;
            textBoxInfoHelp_GDS.Location = new Point(9, 12);
            textBoxInfoHelp_GDS.Multiline = true;
            textBoxInfoHelp_GDS.Name = "textBoxInfoHelp_GDS";
            textBoxInfoHelp_GDS.ReadOnly = true;
            textBoxInfoHelp_GDS.Size = new Size(645, 242);
            textBoxInfoHelp_GDS.TabIndex = 0;
            textBoxInfoHelp_GDS.TabStop = false;
            textBoxInfoHelp_GDS.Text = resources.GetString("textBoxInfoHelp_GDS.Text");
            textBoxInfoHelp_GDS.TextChanged += textBoxInfoHelp_GDS_TextChanged;
            // 
            // pictureBoxInfo_GDS
            // 
            pictureBoxInfo_GDS.Image = (Image)resources.GetObject("pictureBoxInfo_GDS.Image");
            pictureBoxInfo_GDS.Location = new Point(9, 260);
            pictureBoxInfo_GDS.Name = "pictureBoxInfo_GDS";
            pictureBoxInfo_GDS.Size = new Size(204, 214);
            pictureBoxInfo_GDS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxInfo_GDS.TabIndex = 1;
            pictureBoxInfo_GDS.TabStop = false;
            // 
            // textBoxInfo_GDS
            // 
            textBoxInfo_GDS.BackColor = SystemColors.Control;
            textBoxInfo_GDS.BorderStyle = BorderStyle.None;
            textBoxInfo_GDS.Location = new Point(234, 260);
            textBoxInfo_GDS.Multiline = true;
            textBoxInfo_GDS.Name = "textBoxInfo_GDS";
            textBoxInfo_GDS.ReadOnly = true;
            textBoxInfo_GDS.Size = new Size(420, 144);
            textBoxInfo_GDS.TabIndex = 2;
            textBoxInfo_GDS.TabStop = false;
            textBoxInfo_GDS.Text = resources.GetString("textBoxInfo_GDS.Text");
            textBoxInfo_GDS.TextChanged += textBoxInfo_GDS_TextChanged;
            // 
            // buttonClose_GDS
            // 
            buttonClose_GDS.Location = new Point(377, 419);
            buttonClose_GDS.Name = "buttonClose_GDS";
            buttonClose_GDS.Size = new Size(128, 44);
            buttonClose_GDS.TabIndex = 3;
            buttonClose_GDS.Text = "Закрыть";
            buttonClose_GDS.UseVisualStyleBackColor = true;
            buttonClose_GDS.Click += buttonClose_GDS_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 486);
            Controls.Add(buttonClose_GDS);
            Controls.Add(textBoxInfo_GDS);
            Controls.Add(pictureBoxInfo_GDS);
            Controls.Add(textBoxInfoHelp_GDS);
            Name = "FormHelp";
            Text = "О программе ";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInfo_GDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfoHelp_GDS;
        private PictureBox pictureBoxInfo_GDS;
        private TextBox textBoxInfo_GDS;
        private Button buttonClose_GDS;
    }
}