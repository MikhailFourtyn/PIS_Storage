namespace PIS_Storage.Forms.AdminForms
{
    partial class AdminFullInfoGood
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
            this.components = new System.ComponentModel.Container();
            this.buttonAddPhoto = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.goodTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelTypeMsg = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelType = new System.Windows.Forms.Label();
            this.buttonEditType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddPhoto
            // 
            this.buttonAddPhoto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPhoto.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonAddPhoto.Location = new System.Drawing.Point(1007, 445);
            this.buttonAddPhoto.Name = "buttonAddPhoto";
            this.buttonAddPhoto.Size = new System.Drawing.Size(174, 41);
            this.buttonAddPhoto.TabIndex = 39;
            this.buttonAddPhoto.Text = "Добавить фото";
            this.buttonAddPhoto.UseVisualStyleBackColor = false;
            this.buttonAddPhoto.Click += new System.EventHandler(this.buttonAddPhoto_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBack.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonBack.Location = new System.Drawing.Point(30, 84);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(141, 41);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonUpdate.Location = new System.Drawing.Point(456, 590);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(370, 41);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "Подтвердить изменения";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(342, 428);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(101, 20);
            this.textBoxAmount.TabIndex = 35;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(342, 365);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(101, 20);
            this.textBoxPrice.TabIndex = 34;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DataSource = this.goodTypeBindingSource;
            this.comboBoxType.DisplayMember = "Name";
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(342, 284);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(193, 21);
            this.comboBoxType.TabIndex = 33;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // goodTypeBindingSource
            // 
            this.goodTypeBindingSource.DataSource = typeof(PIS_Storage.GoodType);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(342, 164);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(275, 20);
            this.textBoxName.TabIndex = 32;
            // 
            // labelAmount
            // 
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelAmount.Location = new System.Drawing.Point(25, 411);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(311, 49);
            this.labelAmount.TabIndex = 31;
            this.labelAmount.Text = "Количество товара на складе:  ";
            this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTypeMsg
            // 
            this.labelTypeMsg.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelTypeMsg.Location = new System.Drawing.Point(25, 218);
            this.labelTypeMsg.Name = "labelTypeMsg";
            this.labelTypeMsg.Size = new System.Drawing.Size(147, 49);
            this.labelTypeMsg.TabIndex = 30;
            this.labelTypeMsg.Text = "Тип товара:";
            this.labelTypeMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelPrice.Location = new System.Drawing.Point(25, 348);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(158, 49);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Цена товара: ";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelName.Location = new System.Drawing.Point(25, 147);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(253, 49);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "Наименование товара:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(939, 119);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxImage.TabIndex = 38;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Italic);
            this.labelType.Location = new System.Drawing.Point(337, 217);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(385, 49);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "[Тип товара]";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEditType
            // 
            this.buttonEditType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditType.Font = new System.Drawing.Font("Calibri", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonEditType.Location = new System.Drawing.Point(456, 487);
            this.buttonEditType.Name = "buttonEditType";
            this.buttonEditType.Size = new System.Drawing.Size(370, 72);
            this.buttonEditType.TabIndex = 42;
            this.buttonEditType.Text = "Включить режим изменения данных о товаре";
            this.buttonEditType.UseVisualStyleBackColor = false;
            this.buttonEditType.Click += new System.EventHandler(this.buttonEditType_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1264, 60);
            this.label1.TabIndex = 43;
            this.label1.Text = "Данные о товаре";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminFullInfoGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonAddPhoto);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTypeMsg);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "AdminFullInfoGood";
            this.Text = "AdminFullInfoGood";
            ((System.ComponentModel.ISupportInitialize)(this.goodTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddPhoto;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelTypeMsg;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Button buttonEditType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource goodTypeBindingSource;
    }
}