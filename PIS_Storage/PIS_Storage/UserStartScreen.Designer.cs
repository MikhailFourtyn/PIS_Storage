namespace PIS_Storage
{
    partial class UserStartScreen
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
            this.buttonOpenGoodList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenGoodList
            // 
            this.buttonOpenGoodList.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonOpenGoodList.Location = new System.Drawing.Point(236, 144);
            this.buttonOpenGoodList.Name = "buttonOpenGoodList";
            this.buttonOpenGoodList.Size = new System.Drawing.Size(322, 97);
            this.buttonOpenGoodList.TabIndex = 13;
            this.buttonOpenGoodList.Text = "Просмотреть товары в наличии";
            this.buttonOpenGoodList.UseVisualStyleBackColor = true;
            // 
            // UserStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpenGoodList);
            this.Name = "UserStartScreen";
            this.Text = "UserStartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenGoodList;
    }
}