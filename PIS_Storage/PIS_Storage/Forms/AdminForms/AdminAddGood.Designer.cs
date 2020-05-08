namespace PIS_Storage.Forms.AdminForms
{
    partial class AdminAddGood
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
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelAmount.Location = new System.Drawing.Point(21, 357);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(311, 49);
            this.labelAmount.TabIndex = 16;
            this.labelAmount.Text = "Количество товара на складе:  ";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelType.Location = new System.Drawing.Point(21, 229);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(147, 49);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "Тип товара:";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelPrice.Location = new System.Drawing.Point(21, 294);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(158, 49);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Цена товара: ";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelName.Location = new System.Drawing.Point(21, 158);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(253, 49);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Наименование товара:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(338, 175);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 20);
            this.textBoxName.TabIndex = 17;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Мебель",
            "Столы",
            "Бытовая техника",
            "Клавиатуры",
            "Телефоны",
            "Комьютерные мыши"});
            this.comboBoxType.Location = new System.Drawing.Point(338, 246);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(193, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(338, 311);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(101, 20);
            this.textBoxPrice.TabIndex = 19;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(338, 374);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(101, 20);
            this.textBoxAmount.TabIndex = 20;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAdd.Location = new System.Drawing.Point(552, 589);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(141, 41);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBack.Location = new System.Drawing.Point(26, 95);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 41);
            this.buttonBack.TabIndex = 25;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(926, 47);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxImage.TabIndex = 26;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPhoto.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddPhoto.Location = new System.Drawing.Point(1007, 375);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(174, 41);
            this.buttonAddPhoto.TabIndex = 27;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PIS_Storage.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(156, 62);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 28;
            this.pictureBoxLogo.TabStop = false;
            // 
            // AdminAddGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "AdminAddGood";
            this.Text = "AdminAddGood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}