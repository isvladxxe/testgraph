namespace testgraph
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picture = new System.Windows.Forms.PictureBox();
            this.color1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новеЗображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.збереженняФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.збереженняВСпецФорматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фільтриToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відтінкиСірогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФормуліToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнєЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зглажуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гаусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лінійнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gausV2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.негативToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепіяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автоЯскравістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказнийФільтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x = new System.Windows.Forms.ToolStripMenuItem();
            this.y = new System.Windows.Forms.ToolStripMenuItem();
            this.r = new System.Windows.Forms.ToolStripMenuItem();
            this.колірToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свапнутиКольориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBtoYCbCrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yCbCrtoRGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яскравістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.порівнянняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.влівоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.відзеркалитиГорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відзеркалитиВертToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(841, 524);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.SystemColors.Window;
            this.color1.Location = new System.Drawing.Point(12, 27);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(51, 45);
            this.color1.TabIndex = 1;
            this.color1.TabStop = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фільтриToolStripMenuItem,
            this.x,
            this.y,
            this.r,
            this.колірToolStripMenuItem,
            this.яскравістьToolStripMenuItem,
            this.порівнянняToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.mem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новеЗображенняToolStripMenuItem,
            this.збереженняФайлуToolStripMenuItem,
            this.відкритиToolStripMenuItem,
            this.збереженняВСпецФорматToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новеЗображенняToolStripMenuItem
            // 
            this.новеЗображенняToolStripMenuItem.Name = "новеЗображенняToolStripMenuItem";
            this.новеЗображенняToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.новеЗображенняToolStripMenuItem.Text = "Нове зображення";
            this.новеЗображенняToolStripMenuItem.Click += new System.EventHandler(this.новеЗображенняToolStripMenuItem_Click);
            // 
            // збереженняФайлуToolStripMenuItem
            // 
            this.збереженняФайлуToolStripMenuItem.Name = "збереженняФайлуToolStripMenuItem";
            this.збереженняФайлуToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.збереженняФайлуToolStripMenuItem.Text = "Збереження файлу";
            this.збереженняФайлуToolStripMenuItem.Click += new System.EventHandler(this.збереженняФайлуToolStripMenuItem_Click);
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // збереженняВСпецФорматToolStripMenuItem
            // 
            this.збереженняВСпецФорматToolStripMenuItem.Name = "збереженняВСпецФорматToolStripMenuItem";
            this.збереженняВСпецФорматToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.збереженняВСпецФорматToolStripMenuItem.Text = "збереження в спец формат";
            this.збереженняВСпецФорматToolStripMenuItem.Click += new System.EventHandler(this.збереженняВСпецФорматToolStripMenuItem_Click);
            // 
            // фільтриToolStripMenuItem
            // 
            this.фільтриToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відтінкиСірогоToolStripMenuItem,
            this.зглажуванняToolStripMenuItem,
            this.негативToolStripMenuItem,
            this.сепіяToolStripMenuItem,
            this.автоЯскравістьToolStripMenuItem,
            this.заказнийФільтрToolStripMenuItem});
            this.фільтриToolStripMenuItem.Name = "фільтриToolStripMenuItem";
            this.фільтриToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.фільтриToolStripMenuItem.Text = "Фільтри";
            // 
            // відтінкиСірогоToolStripMenuItem
            // 
            this.відтінкиСірогоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФормуліToolStripMenuItem,
            this.середнєЗначенняToolStripMenuItem});
            this.відтінкиСірогоToolStripMenuItem.Name = "відтінкиСірогоToolStripMenuItem";
            this.відтінкиСірогоToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.відтінкиСірогоToolStripMenuItem.Text = "Відтінки сірого";
            this.відтінкиСірогоToolStripMenuItem.Click += new System.EventHandler(this.відтінкиСірогоToolStripMenuItem_Click);
            // 
            // поФормуліToolStripMenuItem
            // 
            this.поФормуліToolStripMenuItem.Name = "поФормуліToolStripMenuItem";
            this.поФормуліToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.поФормуліToolStripMenuItem.Text = "По формулі";
            this.поФормуліToolStripMenuItem.Click += new System.EventHandler(this.поФормуліToolStripMenuItem_Click);
            // 
            // середнєЗначенняToolStripMenuItem
            // 
            this.середнєЗначенняToolStripMenuItem.Name = "середнєЗначенняToolStripMenuItem";
            this.середнєЗначенняToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.середнєЗначенняToolStripMenuItem.Text = "Середнє значення";
            this.середнєЗначенняToolStripMenuItem.Click += new System.EventHandler(this.середнєЗначенняToolStripMenuItem_Click);
            // 
            // зглажуванняToolStripMenuItem
            // 
            this.зглажуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гаусToolStripMenuItem,
            this.лінійнеToolStripMenuItem,
            this.gausV2ToolStripMenuItem});
            this.зглажуванняToolStripMenuItem.Name = "зглажуванняToolStripMenuItem";
            this.зглажуванняToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.зглажуванняToolStripMenuItem.Text = "Зглажування";
            // 
            // гаусToolStripMenuItem
            // 
            this.гаусToolStripMenuItem.Name = "гаусToolStripMenuItem";
            this.гаусToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.гаусToolStripMenuItem.Text = "Гаус";
            this.гаусToolStripMenuItem.Click += new System.EventHandler(this.гаусToolStripMenuItem_Click);
            // 
            // лінійнеToolStripMenuItem
            // 
            this.лінійнеToolStripMenuItem.Name = "лінійнеToolStripMenuItem";
            this.лінійнеToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.лінійнеToolStripMenuItem.Text = "Лінійне";
            this.лінійнеToolStripMenuItem.Click += new System.EventHandler(this.лінійнеToolStripMenuItem_Click);
            // 
            // gausV2ToolStripMenuItem
            // 
            this.gausV2ToolStripMenuItem.Name = "gausV2ToolStripMenuItem";
            this.gausV2ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.gausV2ToolStripMenuItem.Text = "gaus v2";
            this.gausV2ToolStripMenuItem.Click += new System.EventHandler(this.gausV2ToolStripMenuItem_Click);
            // 
            // негативToolStripMenuItem
            // 
            this.негативToolStripMenuItem.Name = "негативToolStripMenuItem";
            this.негативToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.негативToolStripMenuItem.Text = "Негатив";
            this.негативToolStripMenuItem.Click += new System.EventHandler(this.негативToolStripMenuItem_Click);
            // 
            // сепіяToolStripMenuItem
            // 
            this.сепіяToolStripMenuItem.Name = "сепіяToolStripMenuItem";
            this.сепіяToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.сепіяToolStripMenuItem.Text = "Сепія";
            this.сепіяToolStripMenuItem.Click += new System.EventHandler(this.сепіяToolStripMenuItem_Click);
            // 
            // автоЯскравістьToolStripMenuItem
            // 
            this.автоЯскравістьToolStripMenuItem.Name = "автоЯскравістьToolStripMenuItem";
            this.автоЯскравістьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.автоЯскравістьToolStripMenuItem.Text = "АвтоЯскравість";
            this.автоЯскравістьToolStripMenuItem.Click += new System.EventHandler(this.автоЯскравістьToolStripMenuItem_Click);
            // 
            // заказнийФільтрToolStripMenuItem
            // 
            this.заказнийФільтрToolStripMenuItem.Name = "заказнийФільтрToolStripMenuItem";
            this.заказнийФільтрToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.заказнийФільтрToolStripMenuItem.Text = "Заказний фільтр";
            this.заказнийФільтрToolStripMenuItem.Click += new System.EventHandler(this.заказнийФільтрToolStripMenuItem_Click);
            // 
            // x
            // 
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(34, 20);
            this.x.Text = "X=";
            // 
            // y
            // 
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(34, 20);
            this.y.Text = "Y=";
            // 
            // r
            // 
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(46, 20);
            this.r.Text = "R=10";
            // 
            // колірToolStripMenuItem
            // 
            this.колірToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свапнутиКольориToolStripMenuItem,
            this.rGBtoYCbCrToolStripMenuItem,
            this.yCbCrtoRGBToolStripMenuItem});
            this.колірToolStripMenuItem.Name = "колірToolStripMenuItem";
            this.колірToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.колірToolStripMenuItem.Text = "Колір";
            // 
            // свапнутиКольориToolStripMenuItem
            // 
            this.свапнутиКольориToolStripMenuItem.Name = "свапнутиКольориToolStripMenuItem";
            this.свапнутиКольориToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.свапнутиКольориToolStripMenuItem.Text = "Свапнути кольори";
            this.свапнутиКольориToolStripMenuItem.Click += new System.EventHandler(this.свапнутиКольориToolStripMenuItem_Click);
            // 
            // rGBtoYCbCrToolStripMenuItem
            // 
            this.rGBtoYCbCrToolStripMenuItem.Name = "rGBtoYCbCrToolStripMenuItem";
            this.rGBtoYCbCrToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.rGBtoYCbCrToolStripMenuItem.Text = "RGBtoYCbCr";
            this.rGBtoYCbCrToolStripMenuItem.Click += new System.EventHandler(this.rGBtoYCbCrToolStripMenuItem_Click);
            // 
            // yCbCrtoRGBToolStripMenuItem
            // 
            this.yCbCrtoRGBToolStripMenuItem.Name = "yCbCrtoRGBToolStripMenuItem";
            this.yCbCrtoRGBToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.yCbCrtoRGBToolStripMenuItem.Text = "YCbCrtoRGB";
            this.yCbCrtoRGBToolStripMenuItem.Click += new System.EventHandler(this.yCbCrtoRGBToolStripMenuItem_Click);
            // 
            // яскравістьToolStripMenuItem
            // 
            this.яскравістьToolStripMenuItem.Name = "яскравістьToolStripMenuItem";
            this.яскравістьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.яскравістьToolStripMenuItem.Text = "Яскравість";
            this.яскравістьToolStripMenuItem.Click += new System.EventHandler(this.яскравістьToolStripMenuItem_Click);
            // 
            // порівнянняToolStripMenuItem
            // 
            this.порівнянняToolStripMenuItem.Name = "порівнянняToolStripMenuItem";
            this.порівнянняToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.порівнянняToolStripMenuItem.Text = "Порівняння";
            this.порівнянняToolStripMenuItem.Click += new System.EventHandler(this.порівнянняToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.влівоToolStripMenuItem,
            this.вправоToolStripMenuItem,
            this.toolStripMenuItem2,
            this.відзеркалитиГорToolStripMenuItem,
            this.відзеркалитиВертToolStripMenuItem});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.поворотToolStripMenuItem.Text = "Поворот";
            // 
            // влівоToolStripMenuItem
            // 
            this.влівоToolStripMenuItem.Name = "влівоToolStripMenuItem";
            this.влівоToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.влівоToolStripMenuItem.Text = "Вліво";
            this.влівоToolStripMenuItem.Click += new System.EventHandler(this.влівоToolStripMenuItem_Click);
            // 
            // вправоToolStripMenuItem
            // 
            this.вправоToolStripMenuItem.Name = "вправоToolStripMenuItem";
            this.вправоToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.вправоToolStripMenuItem.Text = "Вправо";
            this.вправоToolStripMenuItem.Click += new System.EventHandler(this.вправоToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem2.Text = "180\'";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // відзеркалитиГорToolStripMenuItem
            // 
            this.відзеркалитиГорToolStripMenuItem.Name = "відзеркалитиГорToolStripMenuItem";
            this.відзеркалитиГорToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.відзеркалитиГорToolStripMenuItem.Text = "Відзеркалити гор.";
            this.відзеркалитиГорToolStripMenuItem.Click += new System.EventHandler(this.відзеркалитиГорToolStripMenuItem_Click);
            // 
            // відзеркалитиВертToolStripMenuItem
            // 
            this.відзеркалитиВертToolStripMenuItem.Name = "відзеркалитиВертToolStripMenuItem";
            this.відзеркалитиВертToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.відзеркалитиВертToolStripMenuItem.Text = "Відзеркалити верт.";
            this.відзеркалитиВертToolStripMenuItem.Click += new System.EventHandler(this.відзеркалитиВертToolStripMenuItem_Click);
            // 
            // mem
            // 
            this.mem.Name = "mem";
            this.mem.Size = new System.Drawing.Size(55, 20);
            this.mem.Text = "MEM=";
            this.mem.Click += new System.EventHandler(this.memToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(23, 107);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(40, 201);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "|.bmp||.exif||.gif||.jpg||.jpeg||.png||.tif||.tiff";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(92, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 526);
            this.panel1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "isvl@d image editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox color1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem новеЗображенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x;
        private System.Windows.Forms.ToolStripMenuItem y;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem r;
        private System.Windows.Forms.ToolStripMenuItem збереженняФайлуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem фільтриToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відтінкиСірогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФормуліToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнєЗначенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зглажуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem гаусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лінійнеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem негативToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem сепіяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem колірToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свапнутиКольориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яскравістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem порівнянняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBtoYCbCrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yCbCrtoRGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автоЯскравістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem влівоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem відзеркалитиГорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відзеркалитиВертToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gausV2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказнийФільтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mem;
        private System.Windows.Forms.ToolStripMenuItem збереженняВСпецФорматToolStripMenuItem;
    }
}

