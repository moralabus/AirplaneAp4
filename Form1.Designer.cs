namespace AirplaneAp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSelectFoto = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonAddAirplaneWithFoto = new System.Windows.Forms.Button();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonShowAirplaneInfo = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.buttonCalculateAverageConsumption = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectFoto
            // 
            this.buttonSelectFoto.Location = new System.Drawing.Point(680, 109);
            this.buttonSelectFoto.Name = "buttonSelectFoto";
            this.buttonSelectFoto.Size = new System.Drawing.Size(280, 36);
            this.buttonSelectFoto.TabIndex = 55;
            this.buttonSelectFoto.Text = "выбрать фото";
            this.buttonSelectFoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(680, 151);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(280, 280);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 54;
            this.pictureBoxFoto.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(214, 31);
            this.textBox2.TabIndex = 53;
            this.textBox2.Text = "расход топлива";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 31);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "введите дальность";
            // 
            // dateTimePickerManufactureDate
            // 
            this.dateTimePickerManufactureDate.Location = new System.Drawing.Point(163, 219);
            this.dateTimePickerManufactureDate.Name = "dateTimePickerManufactureDate";
            this.dateTimePickerManufactureDate.Size = new System.Drawing.Size(321, 31);
            this.dateTimePickerManufactureDate.TabIndex = 51;
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(388, 12);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(321, 31);
            this.textBoxAirplaneName.TabIndex = 50;
            this.textBoxAirplaneName.Text = "Имя самолета";
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.HorizontalScrollbar = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(163, 301);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(321, 79);
            this.listBoxAirplanes.TabIndex = 49;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(163, 256);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(321, 39);
            this.buttonSort.TabIndex = 48;
            this.buttonSort.Text = "сортировка самолетов ";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonAddAirplaneWithFoto
            // 
            this.buttonAddAirplaneWithFoto.Location = new System.Drawing.Point(163, 430);
            this.buttonAddAirplaneWithFoto.Name = "buttonAddAirplaneWithFoto";
            this.buttonAddAirplaneWithFoto.Size = new System.Drawing.Size(321, 41);
            this.buttonAddAirplaneWithFoto.TabIndex = 47;
            this.buttonAddAirplaneWithFoto.Text = "добавить летучую бибику";
            this.buttonAddAirplaneWithFoto.UseVisualStyleBackColor = true;
            this.buttonAddAirplaneWithFoto.Click += new System.EventHandler(this.buttonAddAirplaneWithFoto_Click);
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(383, 178);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownFuelConsumption.TabIndex = 46;
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(383, 141);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(101, 31);
            this.numericUpDownRange.TabIndex = 45;
            this.numericUpDownRange.Tag = "";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(163, 102);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(321, 33);
            this.comboBoxModel.TabIndex = 44;
            this.comboBoxModel.Text = "выберите модель самолета";
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(163, 524);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(321, 41);
            this.buttonLoadFromFile.TabIndex = 56;
            this.buttonLoadFromFile.Text = "загрузить из файла";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(163, 477);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(321, 41);
            this.buttonSaveToFile.TabIndex = 57;
            this.buttonSaveToFile.Text = "сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(680, 440);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(280, 31);
            this.textBoxOutput.TabIndex = 58;
            // 
            // buttonShowAirplaneInfo
            // 
            this.buttonShowAirplaneInfo.Location = new System.Drawing.Point(680, 477);
            this.buttonShowAirplaneInfo.Name = "buttonShowAirplaneInfo";
            this.buttonShowAirplaneInfo.Size = new System.Drawing.Size(280, 41);
            this.buttonShowAirplaneInfo.TabIndex = 59;
            this.buttonShowAirplaneInfo.Text = "информация о самолете";
            this.buttonShowAirplaneInfo.UseVisualStyleBackColor = true;
            this.buttonShowAirplaneInfo.Click += new System.EventHandler(this.buttonShowAirplaneInfo_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // buttonCalculateAverageConsumption
            // 
            this.buttonCalculateAverageConsumption.Location = new System.Drawing.Point(163, 571);
            this.buttonCalculateAverageConsumption.Name = "buttonCalculateAverageConsumption";
            this.buttonCalculateAverageConsumption.Size = new System.Drawing.Size(321, 49);
            this.buttonCalculateAverageConsumption.TabIndex = 61;
            this.buttonCalculateAverageConsumption.Text = "средний расход топлива";
            this.buttonCalculateAverageConsumption.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 694);
            this.Controls.Add(this.buttonCalculateAverageConsumption);
            this.Controls.Add(this.buttonShowAirplaneInfo);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSelectFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePickerManufactureDate);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Controls.Add(this.listBoxAirplanes);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonAddAirplaneWithFoto);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.comboBoxModel);
            this.Name = "Form1";
            this.Text = "e";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFoto;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerManufactureDate;
        private System.Windows.Forms.TextBox textBoxAirplaneName;
        private System.Windows.Forms.ListBox listBoxAirplanes;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonAddAirplaneWithFoto;
        private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
        private System.Windows.Forms.NumericUpDown numericUpDownRange;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonShowAirplaneInfo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button buttonCalculateAverageConsumption;
    }
}

