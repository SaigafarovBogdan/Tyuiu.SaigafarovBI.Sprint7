
namespace Project.V14
{
    partial class FormGuideImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuideImage));
            groupBoxGuideImageDescription_SBI = new GroupBox();
            textBoxGuideImage_SBI = new TextBox();
            panelGuideImageDescription_SBI = new Panel();
            panelGuideImage_SBI = new Panel();
            pictureBoxGuideImage_SBI = new PictureBox();
            groupBoxGuideImageDescription_SBI.SuspendLayout();
            panelGuideImageDescription_SBI.SuspendLayout();
            panelGuideImage_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_SBI).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGuideImageDescription_SBI
            // 
            groupBoxGuideImageDescription_SBI.Controls.Add(textBoxGuideImage_SBI);
            groupBoxGuideImageDescription_SBI.Dock = DockStyle.Fill;
            groupBoxGuideImageDescription_SBI.Location = new Point(5, 5);
            groupBoxGuideImageDescription_SBI.Name = "groupBoxGuideImageDescription_SBI";
            groupBoxGuideImageDescription_SBI.Size = new Size(563, 209);
            groupBoxGuideImageDescription_SBI.TabIndex = 0;
            groupBoxGuideImageDescription_SBI.TabStop = false;
            groupBoxGuideImageDescription_SBI.Text = "Описание";
            // 
            // textBoxGuideImage_SBI
            // 
            textBoxGuideImage_SBI.BorderStyle = BorderStyle.None;
            textBoxGuideImage_SBI.Dock = DockStyle.Fill;
            textBoxGuideImage_SBI.Location = new Point(3, 19);
            textBoxGuideImage_SBI.Multiline = true;
            textBoxGuideImage_SBI.Name = "textBoxGuideImage_SBI";
            textBoxGuideImage_SBI.ReadOnly = true;
            textBoxGuideImage_SBI.Size = new Size(557, 187);
            textBoxGuideImage_SBI.TabIndex = 0;
            textBoxGuideImage_SBI.Text = resources.GetString("textBoxGuideImage_SBI.Text");
            textBoxGuideImage_SBI.Enter += this.textBoxGuideImage_SBI_Enter;
            // 
            // panelGuideImageDescription_SBI
            // 
            panelGuideImageDescription_SBI.Controls.Add(groupBoxGuideImageDescription_SBI);
            panelGuideImageDescription_SBI.Dock = DockStyle.Bottom;
            panelGuideImageDescription_SBI.Location = new Point(0, 231);
            panelGuideImageDescription_SBI.Name = "panelGuideImageDescription_SBI";
            panelGuideImageDescription_SBI.Padding = new Padding(5);
            panelGuideImageDescription_SBI.Size = new Size(573, 219);
            panelGuideImageDescription_SBI.TabIndex = 3;
            // 
            // panelGuideImage_SBI
            // 
            panelGuideImage_SBI.Controls.Add(pictureBoxGuideImage_SBI);
            panelGuideImage_SBI.Dock = DockStyle.Top;
            panelGuideImage_SBI.Location = new Point(0, 0);
            panelGuideImage_SBI.Name = "panelGuideImage_SBI";
            panelGuideImage_SBI.Padding = new Padding(5);
            panelGuideImage_SBI.Size = new Size(573, 225);
            panelGuideImage_SBI.TabIndex = 2;
            // 
            // pictureBoxGuideImage_SBI
            // 
            pictureBoxGuideImage_SBI.Dock = DockStyle.Fill;
            pictureBoxGuideImage_SBI.Image = (Image)resources.GetObject("pictureBoxGuideImage_SBI.Image");
            pictureBoxGuideImage_SBI.Location = new Point(5, 5);
            pictureBoxGuideImage_SBI.Name = "pictureBoxGuideImage_SBI";
            pictureBoxGuideImage_SBI.Size = new Size(563, 215);
            pictureBoxGuideImage_SBI.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuideImage_SBI.TabIndex = 0;
            pictureBoxGuideImage_SBI.TabStop = false;
            // 
            // FormGuideImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(panelGuideImageDescription_SBI);
            Controls.Add(panelGuideImage_SBI);
            MaximumSize = new Size(589, 489);
            MinimumSize = new Size(589, 489);
            Name = "FormGuideImage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            groupBoxGuideImageDescription_SBI.ResumeLayout(false);
            groupBoxGuideImageDescription_SBI.PerformLayout();
            panelGuideImageDescription_SBI.ResumeLayout(false);
            panelGuideImage_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuideImage_SBI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGuideImageDescription_SBI;
        private TextBox textBoxGuideImage_SBI;
        private Panel panelGuideImageDescription_SBI;
        private Panel panelGuideImage_SBI;
        private PictureBox pictureBoxGuideImage_SBI;
    }
}