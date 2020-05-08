namespace PIS_Storage.Forms.UserForms
{
    partial class ArrangeOrder
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonArrangeOrder = new System.Windows.Forms.Button();
            this.labelAmountInStorage = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Calibri", 16F);
            this.labelType.Location = new System.Drawing.Point(21, 204);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(734, 49);
            this.labelType.TabIndex = 17;
            this.labelType.Text = "Тип товара:";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelType.Click += new System.EventHandler(this.labelType_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 16F);
            this.labelPrice.Location = new System.Drawing.Point(21, 266);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(463, 49);
            this.labelPrice.TabIndex = 15;
            this.labelPrice.Text = "Цена:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 16F);
            this.labelName.Location = new System.Drawing.Point(21, 155);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(734, 49);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Наименование:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.Location = new System.Drawing.Point(21, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 49);
            this.label2.TabIndex = 19;
            this.label2.Text = "Введите количество товара для покупки:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxAmount.Location = new System.Drawing.Point(437, 400);
            this.textBoxAmount.MaxLength = 5;
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(176, 29);
            this.textBoxAmount.TabIndex = 20;
            // 
            // buttonArrangeOrder
            // 
            this.buttonArrangeOrder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonArrangeOrder.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonArrangeOrder.Location = new System.Drawing.Point(456, 589);
            this.buttonArrangeOrder.Name = "buttonArrangeOrder";
            this.buttonArrangeOrder.Size = new System.Drawing.Size(314, 41);
            this.buttonArrangeOrder.TabIndex = 21;
            this.buttonArrangeOrder.Text = "Оформить заказ";
            this.buttonArrangeOrder.UseVisualStyleBackColor = false;
            this.buttonArrangeOrder.Click += new System.EventHandler(this.buttonArrangeOrder_Click);
            // 
            // labelAmountInStorage
            // 
            this.labelAmountInStorage.Font = new System.Drawing.Font("Calibri", 16F);
            this.labelAmountInStorage.Location = new System.Drawing.Point(21, 319);
            this.labelAmountInStorage.Name = "labelAmountInStorage";
            this.labelAmountInStorage.Size = new System.Drawing.Size(463, 49);
            this.labelAmountInStorage.TabIndex = 22;
            this.labelAmountInStorage.Text = "Количество товара на складе: ";
            this.labelAmountInStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAmountInStorage.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(929, 24);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxImage.TabIndex = 12;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBack.Location = new System.Drawing.Point(26, 108);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(135, 41);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PIS_Storage.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(149, 61);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 24;
            this.pictureBoxLogo.TabStop = false;
            // 
            // ArrangeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelAmountInStorage);
            this.Controls.Add(this.buttonArrangeOrder);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxImage);
            this.Name = "ArrangeOrder";
            this.Text = "ArrangeOrder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonArrangeOrder;
        private System.Windows.Forms.Label labelAmountInStorage;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}