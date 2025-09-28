namespace LR1._1_C_
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrendC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DecorC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeasonC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зПараметромToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безПараметраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копіюванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивестиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.COUNTRY = new System.Windows.Forms.ComboBox();
            this.BREND = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.VIEW = new System.Windows.Forms.ComboBox();
            this.COLOR = new System.Windows.Forms.ComboBox();
            this.DECOR = new System.Windows.Forms.ComboBox();
            this.SIZE = new System.Windows.Forms.ComboBox();
            this.SEASON = new System.Windows.Forms.ComboBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ViewC,
            this.ColorC,
            this.SizeC,
            this.BrendC,
            this.CountryC,
            this.DecorC,
            this.SeasonC,
            this.CostC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(918, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 721);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewC
            // 
            this.ViewC.HeaderText = "Вид";
            this.ViewC.MinimumWidth = 6;
            this.ViewC.Name = "ViewC";
            this.ViewC.Width = 110;
            // 
            // ColorC
            // 
            this.ColorC.HeaderText = "Колір";
            this.ColorC.MinimumWidth = 6;
            this.ColorC.Name = "ColorC";
            this.ColorC.Width = 125;
            // 
            // SizeC
            // 
            this.SizeC.HeaderText = "Розмір";
            this.SizeC.MinimumWidth = 6;
            this.SizeC.Name = "SizeC";
            this.SizeC.Width = 80;
            // 
            // BrendC
            // 
            this.BrendC.HeaderText = "Бренд";
            this.BrendC.MinimumWidth = 6;
            this.BrendC.Name = "BrendC";
            this.BrendC.Width = 125;
            // 
            // CountryC
            // 
            this.CountryC.HeaderText = "Країна бренду";
            this.CountryC.MinimumWidth = 6;
            this.CountryC.Name = "CountryC";
            this.CountryC.Width = 125;
            // 
            // DecorC
            // 
            this.DecorC.HeaderText = "Декор";
            this.DecorC.MinimumWidth = 6;
            this.DecorC.Name = "DecorC";
            this.DecorC.Width = 125;
            // 
            // SeasonC
            // 
            this.SeasonC.HeaderText = "Сезоність";
            this.SeasonC.MinimumWidth = 6;
            this.SeasonC.Name = "SeasonC";
            this.SeasonC.Width = 125;
            // 
            // CostC
            // 
            this.CostC.HeaderText = "Ціна";
            this.CostC.MinimumWidth = 6;
            this.CostC.Name = "CostC";
            this.CostC.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.зберегтиToolStripMenuItem,
            this.вивестиToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зПараметромToolStripMenuItem,
            this.безПараметраToolStripMenuItem,
            this.копіюванняToolStripMenuItem});
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.створитиToolStripMenuItem.Text = "Конструктори";
            // 
            // зПараметромToolStripMenuItem
            // 
            this.зПараметромToolStripMenuItem.Name = "зПараметромToolStripMenuItem";
            this.зПараметромToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зПараметромToolStripMenuItem.Text = "З параметром";
            this.зПараметромToolStripMenuItem.Click += new System.EventHandler(this.зПараметромToolStripMenuItem_Click);
            // 
            // безПараметраToolStripMenuItem
            // 
            this.безПараметраToolStripMenuItem.Name = "безПараметраToolStripMenuItem";
            this.безПараметраToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.безПараметраToolStripMenuItem.Text = "Без параметра";
            this.безПараметраToolStripMenuItem.Click += new System.EventHandler(this.безПараметраToolStripMenuItem_Click);
            // 
            // копіюванняToolStripMenuItem
            // 
            this.копіюванняToolStripMenuItem.Name = "копіюванняToolStripMenuItem";
            this.копіюванняToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.копіюванняToolStripMenuItem.Text = "Копіювання";
            this.копіюванняToolStripMenuItem.Click += new System.EventHandler(this.копіюванняToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            // 
            // вивестиToolStripMenuItem
            // 
            this.вивестиToolStripMenuItem.Name = "вивестиToolStripMenuItem";
            this.вивестиToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.вивестиToolStripMenuItem.Text = "Вивести";
            this.вивестиToolStripMenuItem.Click += new System.EventHandler(this.вивестиToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Розмір";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Колір";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ціна";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Бренд";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 42);
            this.label6.TabIndex = 8;
            this.label6.Text = "Країна бренду";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 42);
            this.label7.TabIndex = 9;
            this.label7.Text = "Декор";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 519);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 42);
            this.label8.TabIndex = 10;
            this.label8.Text = "Сезоність";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // COUNTRY
            // 
            this.COUNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COUNTRY.FormattingEnabled = true;
            this.COUNTRY.Items.AddRange(new object[] {
            "Швеція",
            "Іспанія",
            "Китай",
            "Німеччина",
            "Франція",
            "Італія"});
            this.COUNTRY.Location = new System.Drawing.Point(267, 371);
            this.COUNTRY.Name = "COUNTRY";
            this.COUNTRY.Size = new System.Drawing.Size(121, 24);
            this.COUNTRY.TabIndex = 12;
            this.COUNTRY.SelectedIndexChanged += new System.EventHandler(this.COUNTRY_SelectedIndexChanged);
            // 
            // BREND
            // 
            this.BREND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BREND.FormattingEnabled = true;
            this.BREND.Items.AddRange(new object[] {
            "No Brand",
            "H&M",
            "SHEIN",
            "Zara",
            "Hermes",
            "Louis Vuitton",
            "Adidas",
            "Prada",
            "Versace"});
            this.BREND.Location = new System.Drawing.Point(151, 302);
            this.BREND.Name = "BREND";
            this.BREND.Size = new System.Drawing.Size(121, 24);
            this.BREND.TabIndex = 13;
            this.BREND.SelectedIndexChanged += new System.EventHandler(this.BREND_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 681);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 47);
            this.button2.TabIndex = 20;
            this.button2.Text = "Фільтрація";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 42);
            this.label4.TabIndex = 21;
            this.label4.Text = "Опис";
            // 
            // VIEW
            // 
            this.VIEW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VIEW.FormattingEnabled = true;
            this.VIEW.Items.AddRange(new object[] {
            ""});
            this.VIEW.Location = new System.Drawing.Point(151, 86);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(121, 24);
            this.VIEW.TabIndex = 22;
            this.VIEW.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // COLOR
            // 
            this.COLOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COLOR.FormattingEnabled = true;
            this.COLOR.Items.AddRange(new object[] {
            "Бежевий",
            "Білий",
            "Блакитний",
            "Сірий",
            "Червоний",
            "Чорний"});
            this.COLOR.Location = new System.Drawing.Point(151, 158);
            this.COLOR.Name = "COLOR";
            this.COLOR.Size = new System.Drawing.Size(121, 24);
            this.COLOR.TabIndex = 23;
            // 
            // DECOR
            // 
            this.DECOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DECOR.FormattingEnabled = true;
            this.DECOR.Location = new System.Drawing.Point(179, 457);
            this.DECOR.Name = "DECOR";
            this.DECOR.Size = new System.Drawing.Size(121, 24);
            this.DECOR.TabIndex = 24;
            // 
            // SIZE
            // 
            this.SIZE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SIZE.FormattingEnabled = true;
            this.SIZE.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XS",
            "XM",
            "XL"});
            this.SIZE.Location = new System.Drawing.Point(151, 236);
            this.SIZE.Name = "SIZE";
            this.SIZE.Size = new System.Drawing.Size(121, 24);
            this.SIZE.TabIndex = 25;
            // 
            // SEASON
            // 
            this.SEASON.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SEASON.FormattingEnabled = true;
            this.SEASON.Items.AddRange(new object[] {
            "Зима",
            "Весна",
            "Літо",
            "Осінь"});
            this.SEASON.Location = new System.Drawing.Point(220, 536);
            this.SEASON.Name = "SEASON";
            this.SEASON.Size = new System.Drawing.Size(121, 24);
            this.SEASON.TabIndex = 26;
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(160, 606);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(140, 22);
            this.Cost.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 28;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.SEASON);
            this.Controls.Add(this.SIZE);
            this.Controls.Add(this.DECOR);
            this.Controls.Add(this.COLOR);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BREND);
            this.Controls.Add(this.COUNTRY);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивестиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox COUNTRY;
        private System.Windows.Forms.ComboBox BREND;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViewC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrendC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecorC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeasonC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostC;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VIEW;
        private System.Windows.Forms.ComboBox COLOR;
        private System.Windows.Forms.ComboBox DECOR;
        private System.Windows.Forms.ComboBox SIZE;
        private System.Windows.Forms.ComboBox SEASON;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem зПараметромToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безПараметраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копіюванняToolStripMenuItem;
    }
}

