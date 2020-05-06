namespace PIS_Storage
{
    partial class ManagerStartScreen
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
            this.buttonOpenOrderList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpenOrderList
            // 
            this.buttonOpenOrderList.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonOpenOrderList.Location = new System.Drawing.Point(229, 67);
            this.buttonOpenOrderList.Name = "buttonOpenOrderList";
            this.buttonOpenOrderList.Size = new System.Drawing.Size(322, 97);
            this.buttonOpenOrderList.TabIndex = 14;
            this.buttonOpenOrderList.Text = "Просмотреть список заказов";
            this.buttonOpenOrderList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(229, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 97);
            this.button1.TabIndex = 15;
            this.button1.Text = "Просмотреть список товаров";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManagerStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpenOrderList);
            this.MaximizeBox = false;
            this.Name = "ManagerStartScreen";
            this.Text = "ManagerStartScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenOrderList;
        private System.Windows.Forms.Button button1;
    }
}