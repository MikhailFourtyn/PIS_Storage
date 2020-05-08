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
            this.buttonShowOrderList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowGoodList = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowOrderList
            // 
            this.buttonShowOrderList.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonShowOrderList.Location = new System.Drawing.Point(439, 304);
            this.buttonShowOrderList.Name = "buttonShowOrderList";
            this.buttonShowOrderList.Size = new System.Drawing.Size(322, 97);
            this.buttonShowOrderList.TabIndex = 14;
            this.buttonShowOrderList.Text = "Просмотреть список заказов";
            this.buttonShowOrderList.UseVisualStyleBackColor = true;
            this.buttonShowOrderList.Click += new System.EventHandler(this.buttonShowOrderList_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1264, 60);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добро пожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowGoodList
            // 
            this.buttonShowGoodList.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonShowGoodList.Location = new System.Drawing.Point(439, 171);
            this.buttonShowGoodList.Name = "buttonShowGoodList";
            this.buttonShowGoodList.Size = new System.Drawing.Size(322, 97);
            this.buttonShowGoodList.TabIndex = 19;
            this.buttonShowGoodList.Text = "Просмотреть список товаров";
            this.buttonShowGoodList.UseVisualStyleBackColor = true;
            this.buttonShowGoodList.Click += new System.EventHandler(this.buttonShowGoodList_Click);
            // 
            // ManagerStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonShowGoodList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonShowOrderList);
            this.MaximizeBox = false;
            this.Name = "ManagerStartScreen";
            this.Text = "ManagerStartScreen";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShowOrderList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowGoodList;
    }
}