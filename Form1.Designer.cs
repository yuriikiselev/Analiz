namespace Kiseleva
{
    partial class Glavnaya
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
            this.FIZIK = new System.Windows.Forms.Button();
            this.YRIK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Family = new System.Windows.Forms.TextBox();
            this.NameKlient = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DateBirthd = new System.Windows.Forms.MaskedTextBox();
            this.INN = new System.Windows.Forms.MaskedTextBox();
            this.OGRN = new System.Windows.Forms.MaskedTextBox();
            this.CountryPay = new System.Windows.Forms.TextBox();
            this.CountryBank = new System.Windows.Forms.TextBox();
            this.Valuta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameUL = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SizePay = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIZIK
            // 
            this.FIZIK.Location = new System.Drawing.Point(21, 276);
            this.FIZIK.Name = "FIZIK";
            this.FIZIK.Size = new System.Drawing.Size(126, 79);
            this.FIZIK.TabIndex = 0;
            this.FIZIK.Text = "Физическое лицо";
            this.FIZIK.UseVisualStyleBackColor = true;
            this.FIZIK.Click += new System.EventHandler(this.FIZIK_Click);
            // 
            // YRIK
            // 
            this.YRIK.Location = new System.Drawing.Point(361, 276);
            this.YRIK.Name = "YRIK";
            this.YRIK.Size = new System.Drawing.Size(126, 79);
            this.YRIK.TabIndex = 1;
            this.YRIK.Text = "Юридическое лицо";
            this.YRIK.UseVisualStyleBackColor = true;
            this.YRIK.Click += new System.EventHandler(this.YRIK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИНН*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ОГРН*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Страна совершения платежа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Страна банка эмитента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Размер платежа";
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(190, 42);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(100, 20);
            this.Family.TabIndex = 8;
            // 
            // NameKlient
            // 
            this.NameKlient.Location = new System.Drawing.Point(296, 42);
            this.NameKlient.Name = "NameKlient";
            this.NameKlient.Size = new System.Drawing.Size(100, 20);
            this.NameKlient.TabIndex = 9;
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(402, 42);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(100, 20);
            this.Otchestvo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата рождения";
            // 
            // DateBirthd
            // 
            this.DateBirthd.Location = new System.Drawing.Point(190, 68);
            this.DateBirthd.Name = "DateBirthd";
            this.DateBirthd.Size = new System.Drawing.Size(100, 20);
            this.DateBirthd.TabIndex = 17;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(190, 95);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(100, 20);
            this.INN.TabIndex = 18;
            // 
            // OGRN
            // 
            this.OGRN.Location = new System.Drawing.Point(190, 125);
            this.OGRN.Name = "OGRN";
            this.OGRN.Size = new System.Drawing.Size(100, 20);
            this.OGRN.TabIndex = 19;
            // 
            // CountryPay
            // 
            this.CountryPay.Location = new System.Drawing.Point(190, 154);
            this.CountryPay.Name = "CountryPay";
            this.CountryPay.Size = new System.Drawing.Size(100, 20);
            this.CountryPay.TabIndex = 20;
            // 
            // CountryBank
            // 
            this.CountryBank.Location = new System.Drawing.Point(190, 180);
            this.CountryBank.Name = "CountryBank";
            this.CountryBank.Size = new System.Drawing.Size(100, 20);
            this.CountryBank.TabIndex = 21;
            // 
            // Valuta
            // 
            this.Valuta.FormattingEnabled = true;
            this.Valuta.Items.AddRange(new object[] {
            "Рубль",
            "Доллар",
            "Евро"});
            this.Valuta.Location = new System.Drawing.Point(296, 206);
            this.Valuta.Name = "Valuta";
            this.Valuta.Size = new System.Drawing.Size(63, 21);
            this.Valuta.TabIndex = 24;
            this.Valuta.Text = "Рубль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Название юридического лица*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // NameUL
            // 
            this.NameUL.Location = new System.Drawing.Point(190, 232);
            this.NameUL.Name = "NameUL";
            this.NameUL.Size = new System.Drawing.Size(100, 20);
            this.NameUL.TabIndex = 26;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(297, 234);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Иностранное ЮЛ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "* только для проверки Юридических лиц";
            // 
            // SizePay
            // 
            this.SizePay.Location = new System.Drawing.Point(190, 206);
            this.SizePay.Name = "SizePay";
            this.SizePay.Size = new System.Drawing.Size(100, 20);
            this.SizePay.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ключ ФНС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Glavnaya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SizePay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.NameUL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Valuta);
            this.Controls.Add(this.CountryBank);
            this.Controls.Add(this.CountryPay);
            this.Controls.Add(this.OGRN);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.DateBirthd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.NameKlient);
            this.Controls.Add(this.Family);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YRIK);
            this.Controls.Add(this.FIZIK);
            this.Name = "Glavnaya";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Glavnaya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FIZIK;
        private System.Windows.Forms.Button YRIK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Family;
        public System.Windows.Forms.TextBox NameKlient;
        public System.Windows.Forms.TextBox Otchestvo;
        public System.Windows.Forms.MaskedTextBox DateBirthd;
        public System.Windows.Forms.MaskedTextBox INN;
        public System.Windows.Forms.MaskedTextBox OGRN;
        public System.Windows.Forms.TextBox CountryPay;
        public System.Windows.Forms.TextBox CountryBank;
        public System.Windows.Forms.ComboBox Valuta;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox NameUL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.MaskedTextBox SizePay;
        private System.Windows.Forms.Button button1;
    }
}

