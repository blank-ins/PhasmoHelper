
namespace PhasmoHelper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.evidenceBox = new System.Windows.Forms.GroupBox();
            this.radio_key = new System.Windows.Forms.Label();
            this.term_key = new System.Windows.Forms.Label();
            this.orb_key = new System.Windows.Forms.Label();
            this.notes_key = new System.Windows.Forms.Label();
            this.reset_key = new System.Windows.Forms.Label();
            this.print_key = new System.Windows.Forms.Label();
            this.emp_key = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.orb = new System.Windows.Forms.CheckBox();
            this.notes = new System.Windows.Forms.CheckBox();
            this.radio = new System.Windows.Forms.CheckBox();
            this.term = new System.Windows.Forms.CheckBox();
            this.print = new System.Windows.Forms.CheckBox();
            this.emp = new System.Windows.Forms.CheckBox();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.urei = new System.Windows.Forms.Label();
            this.mara = new System.Windows.Forms.Label();
            this.demon = new System.Windows.Forms.Label();
            this.polterheist = new System.Windows.Forms.Label();
            this.spirit = new System.Windows.Forms.Label();
            this.mirage = new System.Windows.Forms.Label();
            this.shadow = new System.Windows.Forms.Label();
            this.jin = new System.Windows.Forms.Label();
            this.phantom = new System.Windows.Forms.Label();
            this.oni = new System.Windows.Forms.Label();
            this.revenant = new System.Windows.Forms.Label();
            this.banshi = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionBox = new System.Windows.Forms.GroupBox();
            this.HotkeyStrip = new System.Windows.Forms.StatusStrip();
            this.HotkeyStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HotkeyStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsResetLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.SettingsResetLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.separator = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.evidenceBox.SuspendLayout();
            this.typeBox.SuspendLayout();
            this.descriptionBox.SuspendLayout();
            this.HotkeyStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // evidenceBox
            // 
            this.evidenceBox.Controls.Add(this.radio_key);
            this.evidenceBox.Controls.Add(this.term_key);
            this.evidenceBox.Controls.Add(this.orb_key);
            this.evidenceBox.Controls.Add(this.notes_key);
            this.evidenceBox.Controls.Add(this.reset_key);
            this.evidenceBox.Controls.Add(this.print_key);
            this.evidenceBox.Controls.Add(this.emp_key);
            this.evidenceBox.Controls.Add(this.ResetButton);
            this.evidenceBox.Controls.Add(this.orb);
            this.evidenceBox.Controls.Add(this.notes);
            this.evidenceBox.Controls.Add(this.radio);
            this.evidenceBox.Controls.Add(this.term);
            this.evidenceBox.Controls.Add(this.print);
            this.evidenceBox.Controls.Add(this.emp);
            this.evidenceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.evidenceBox.Location = new System.Drawing.Point(13, 13);
            this.evidenceBox.Name = "evidenceBox";
            this.evidenceBox.Size = new System.Drawing.Size(218, 230);
            this.evidenceBox.TabIndex = 0;
            this.evidenceBox.TabStop = false;
            this.evidenceBox.Text = "Улики";
            // 
            // radio_key
            // 
            this.radio_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.radio_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radio_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radio_key.Location = new System.Drawing.Point(7, 92);
            this.radio_key.Name = "radio_key";
            this.radio_key.Size = new System.Drawing.Size(44, 17);
            this.radio_key.TabIndex = 7;
            this.radio_key.Tag = "D7";
            this.radio_key.Text = "KEY";
            this.radio_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_key.UseMnemonic = false;
            this.radio_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // term_key
            // 
            this.term_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.term_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.term_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.term_key.Location = new System.Drawing.Point(6, 68);
            this.term_key.Name = "term_key";
            this.term_key.Size = new System.Drawing.Size(44, 17);
            this.term_key.TabIndex = 7;
            this.term_key.Tag = "D6";
            this.term_key.Text = "KEY";
            this.term_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.term_key.UseMnemonic = false;
            this.term_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // orb_key
            // 
            this.orb_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orb_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orb_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orb_key.Location = new System.Drawing.Point(7, 140);
            this.orb_key.Name = "orb_key";
            this.orb_key.Size = new System.Drawing.Size(44, 17);
            this.orb_key.TabIndex = 7;
            this.orb_key.Tag = "D9";
            this.orb_key.Text = "KEY";
            this.orb_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orb_key.UseMnemonic = false;
            this.orb_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // notes_key
            // 
            this.notes_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notes_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notes_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notes_key.Location = new System.Drawing.Point(7, 116);
            this.notes_key.Name = "notes_key";
            this.notes_key.Size = new System.Drawing.Size(44, 17);
            this.notes_key.TabIndex = 7;
            this.notes_key.Tag = "D8";
            this.notes_key.Text = "KEY";
            this.notes_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notes_key.UseMnemonic = false;
            this.notes_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // reset_key
            // 
            this.reset_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reset_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_key.Location = new System.Drawing.Point(162, 204);
            this.reset_key.Name = "reset_key";
            this.reset_key.Size = new System.Drawing.Size(50, 17);
            this.reset_key.TabIndex = 7;
            this.reset_key.Tag = "D0";
            this.reset_key.Text = "KEY";
            this.reset_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reset_key.UseMnemonic = false;
            this.reset_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // print_key
            // 
            this.print_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.print_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.print_key.Location = new System.Drawing.Point(7, 43);
            this.print_key.Name = "print_key";
            this.print_key.Size = new System.Drawing.Size(44, 17);
            this.print_key.TabIndex = 7;
            this.print_key.Tag = "D5";
            this.print_key.Text = "KEY";
            this.print_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.print_key.UseMnemonic = false;
            this.print_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // emp_key
            // 
            this.emp_key.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emp_key.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_key.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emp_key.Location = new System.Drawing.Point(7, 20);
            this.emp_key.Name = "emp_key";
            this.emp_key.Size = new System.Drawing.Size(44, 17);
            this.emp_key.TabIndex = 7;
            this.emp_key.Tag = "D4";
            this.emp_key.Text = "KEY";
            this.emp_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.emp_key.UseMnemonic = false;
            this.emp_key.DoubleClick += new System.EventHandler(this.key_init);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(7, 201);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(150, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.TabStop = false;
            this.ResetButton.Text = "Сбросить";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // orb
            // 
            this.orb.AutoSize = true;
            this.orb.Location = new System.Drawing.Point(56, 140);
            this.orb.Name = "orb";
            this.orb.Size = new System.Drawing.Size(127, 17);
            this.orb.TabIndex = 5;
            this.orb.TabStop = false;
            this.orb.Text = "Призрачный огонёк";
            this.orb.UseVisualStyleBackColor = true;
            this.orb.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // notes
            // 
            this.notes.AutoSize = true;
            this.notes.Location = new System.Drawing.Point(56, 116);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(122, 17);
            this.notes.TabIndex = 4;
            this.notes.TabStop = false;
            this.notes.Text = "Записи в блокноте";
            this.notes.UseVisualStyleBackColor = true;
            this.notes.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Location = new System.Drawing.Point(56, 92);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(101, 17);
            this.radio.TabIndex = 3;
            this.radio.TabStop = false;
            this.radio.Text = "Радиориёмник";
            this.radio.UseVisualStyleBackColor = true;
            this.radio.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(56, 68);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(150, 17);
            this.term.TabIndex = 2;
            this.term.TabStop = false;
            this.term.Text = "Минусовая температура";
            this.term.UseVisualStyleBackColor = true;
            this.term.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // print
            // 
            this.print.AutoSize = true;
            this.print.Location = new System.Drawing.Point(56, 44);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(79, 17);
            this.print.TabIndex = 1;
            this.print.TabStop = false;
            this.print.Text = "Отпечатки";
            this.print.UseVisualStyleBackColor = true;
            this.print.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Location = new System.Drawing.Point(56, 23);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(76, 17);
            this.emp.TabIndex = 0;
            this.emp.TabStop = false;
            this.emp.Text = "ЭМП ур. 5";
            this.emp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.emp.UseVisualStyleBackColor = true;
            this.emp.CheckedChanged += new System.EventHandler(this.CheckBox_Changed);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.urei);
            this.typeBox.Controls.Add(this.mara);
            this.typeBox.Controls.Add(this.demon);
            this.typeBox.Controls.Add(this.polterheist);
            this.typeBox.Controls.Add(this.spirit);
            this.typeBox.Controls.Add(this.mirage);
            this.typeBox.Controls.Add(this.shadow);
            this.typeBox.Controls.Add(this.jin);
            this.typeBox.Controls.Add(this.phantom);
            this.typeBox.Controls.Add(this.oni);
            this.typeBox.Controls.Add(this.revenant);
            this.typeBox.Controls.Add(this.banshi);
            this.typeBox.Location = new System.Drawing.Point(237, 13);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(146, 229);
            this.typeBox.TabIndex = 1;
            this.typeBox.TabStop = false;
            this.typeBox.Tag = "true";
            this.typeBox.Text = "Призраки";
            // 
            // urei
            // 
            this.urei.AutoSize = true;
            this.urei.Cursor = System.Windows.Forms.Cursors.Help;
            this.urei.Location = new System.Drawing.Point(70, 140);
            this.urei.Name = "urei";
            this.urei.Size = new System.Drawing.Size(34, 13);
            this.urei.TabIndex = 11;
            this.urei.Text = "Юрэй";
            this.urei.Click += new System.EventHandler(this.Type_Click);
            // 
            // mara
            // 
            this.mara.AutoSize = true;
            this.mara.Cursor = System.Windows.Forms.Cursors.Help;
            this.mara.Location = new System.Drawing.Point(70, 116);
            this.mara.Name = "mara";
            this.mara.Size = new System.Drawing.Size(34, 13);
            this.mara.TabIndex = 10;
            this.mara.Text = "Мара";
            this.mara.Click += new System.EventHandler(this.Type_Click);
            // 
            // demon
            // 
            this.demon.AutoSize = true;
            this.demon.Cursor = System.Windows.Forms.Cursors.Help;
            this.demon.Location = new System.Drawing.Point(70, 92);
            this.demon.Name = "demon";
            this.demon.Size = new System.Drawing.Size(42, 13);
            this.demon.TabIndex = 9;
            this.demon.Text = "Демон";
            this.demon.Click += new System.EventHandler(this.Type_Click);
            // 
            // polterheist
            // 
            this.polterheist.AutoSize = true;
            this.polterheist.Cursor = System.Windows.Forms.Cursors.Help;
            this.polterheist.Location = new System.Drawing.Point(70, 68);
            this.polterheist.Name = "polterheist";
            this.polterheist.Size = new System.Drawing.Size(72, 13);
            this.polterheist.TabIndex = 8;
            this.polterheist.Text = "Полтергейст";
            this.polterheist.Click += new System.EventHandler(this.Type_Click);
            // 
            // spirit
            // 
            this.spirit.AutoSize = true;
            this.spirit.Cursor = System.Windows.Forms.Cursors.Help;
            this.spirit.Location = new System.Drawing.Point(70, 44);
            this.spirit.Name = "spirit";
            this.spirit.Size = new System.Drawing.Size(26, 13);
            this.spirit.TabIndex = 7;
            this.spirit.Text = "Дух";
            this.spirit.Click += new System.EventHandler(this.Type_Click);
            // 
            // mirage
            // 
            this.mirage.AutoSize = true;
            this.mirage.Cursor = System.Windows.Forms.Cursors.Help;
            this.mirage.Location = new System.Drawing.Point(70, 21);
            this.mirage.Name = "mirage";
            this.mirage.Size = new System.Drawing.Size(42, 13);
            this.mirage.TabIndex = 6;
            this.mirage.Text = "Мираж";
            this.mirage.Click += new System.EventHandler(this.Type_Click);
            // 
            // shadow
            // 
            this.shadow.AutoSize = true;
            this.shadow.Cursor = System.Windows.Forms.Cursors.Help;
            this.shadow.Location = new System.Drawing.Point(7, 139);
            this.shadow.Name = "shadow";
            this.shadow.Size = new System.Drawing.Size(32, 13);
            this.shadow.TabIndex = 5;
            this.shadow.Text = "Тень";
            this.shadow.Click += new System.EventHandler(this.Type_Click);
            // 
            // jin
            // 
            this.jin.AutoSize = true;
            this.jin.Cursor = System.Windows.Forms.Cursors.Help;
            this.jin.Location = new System.Drawing.Point(7, 115);
            this.jin.Name = "jin";
            this.jin.Size = new System.Drawing.Size(42, 13);
            this.jin.TabIndex = 4;
            this.jin.Text = "Джинн";
            this.jin.Click += new System.EventHandler(this.Type_Click);
            // 
            // phantom
            // 
            this.phantom.AutoSize = true;
            this.phantom.BackColor = System.Drawing.SystemColors.Control;
            this.phantom.Cursor = System.Windows.Forms.Cursors.Help;
            this.phantom.Location = new System.Drawing.Point(7, 91);
            this.phantom.Name = "phantom";
            this.phantom.Size = new System.Drawing.Size(49, 13);
            this.phantom.TabIndex = 3;
            this.phantom.Text = "Фантом";
            this.phantom.Click += new System.EventHandler(this.Type_Click);
            // 
            // oni
            // 
            this.oni.AutoSize = true;
            this.oni.Cursor = System.Windows.Forms.Cursors.Help;
            this.oni.Location = new System.Drawing.Point(7, 67);
            this.oni.Name = "oni";
            this.oni.Size = new System.Drawing.Size(27, 13);
            this.oni.TabIndex = 2;
            this.oni.Text = "Óни";
            this.oni.Click += new System.EventHandler(this.Type_Click);
            // 
            // revenant
            // 
            this.revenant.AutoSize = true;
            this.revenant.Cursor = System.Windows.Forms.Cursors.Help;
            this.revenant.Location = new System.Drawing.Point(7, 43);
            this.revenant.Name = "revenant";
            this.revenant.Size = new System.Drawing.Size(55, 13);
            this.revenant.TabIndex = 1;
            this.revenant.Text = "Ревенант";
            this.revenant.Click += new System.EventHandler(this.Type_Click);
            // 
            // banshi
            // 
            this.banshi.AutoSize = true;
            this.banshi.Cursor = System.Windows.Forms.Cursors.Help;
            this.banshi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.banshi.Location = new System.Drawing.Point(7, 20);
            this.banshi.Name = "banshi";
            this.banshi.Size = new System.Drawing.Size(40, 13);
            this.banshi.TabIndex = 0;
            this.banshi.Text = "Банши";
            this.banshi.Click += new System.EventHandler(this.Type_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Location = new System.Drawing.Point(6, 21);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(270, 203);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TabStop = false;
            this.descriptionTextBox.Text = "Выберите тип призрака, и здесь появиться его описание и особенности.\n";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Controls.Add(this.descriptionTextBox);
            this.descriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionBox.Location = new System.Drawing.Point(389, 13);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(282, 230);
            this.descriptionBox.TabIndex = 4;
            this.descriptionBox.TabStop = false;
            this.descriptionBox.Text = "Описание";
            // 
            // HotkeyStrip
            // 
            this.HotkeyStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HotkeyStatusLabel1,
            this.HotkeyStatusLabel2,
            this.separator,
            this.SettingsResetLabel1,
            this.SettingsResetLabel2});
            this.HotkeyStrip.Location = new System.Drawing.Point(0, 314);
            this.HotkeyStrip.Name = "HotkeyStrip";
            this.HotkeyStrip.Size = new System.Drawing.Size(683, 22);
            this.HotkeyStrip.TabIndex = 5;
            this.HotkeyStrip.Text = "statusStrip1";
            // 
            // HotkeyStatusLabel1
            // 
            this.HotkeyStatusLabel1.Name = "HotkeyStatusLabel1";
            this.HotkeyStatusLabel1.Size = new System.Drawing.Size(112, 17);
            this.HotkeyStatusLabel1.Text = "Сочетания клавиш";
            // 
            // HotkeyStatusLabel2
            // 
            this.HotkeyStatusLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.HotkeyStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HotkeyStatusLabel2.ForeColor = System.Drawing.Color.Blue;
            this.HotkeyStatusLabel2.Name = "HotkeyStatusLabel2";
            this.HotkeyStatusLabel2.Size = new System.Drawing.Size(61, 17);
            this.HotkeyStatusLabel2.Text = "Shift + F7";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 262);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(366, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Прозрачность:";
            // 
            // SettingsResetLabel1
            // 
            this.SettingsResetLabel1.Name = "SettingsResetLabel1";
            this.SettingsResetLabel1.Size = new System.Drawing.Size(175, 17);
            this.SettingsResetLabel1.Text = "Для сброса настроек нажмите";
            // 
            // SettingsResetLabel2
            // 
            this.SettingsResetLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsResetLabel2.ForeColor = System.Drawing.Color.Blue;
            this.SettingsResetLabel2.Name = "SettingsResetLabel2";
            this.SettingsResetLabel2.Size = new System.Drawing.Size(61, 17);
            this.SettingsResetLabel2.Text = "Sihft + F6";
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(10, 17);
            this.separator.Text = "|";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCopyright.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCopyright.Location = new System.Drawing.Point(512, 291);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(159, 16);
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "Copyright © 2021, sq1blank";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 336);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.HotkeyStrip);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.evidenceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Phasmophobia Helper";
            this.TopMost = true;
            this.evidenceBox.ResumeLayout(false);
            this.evidenceBox.PerformLayout();
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.descriptionBox.ResumeLayout(false);
            this.HotkeyStrip.ResumeLayout(false);
            this.HotkeyStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox evidenceBox;
        private System.Windows.Forms.CheckBox orb;
        private System.Windows.Forms.CheckBox notes;
        private System.Windows.Forms.CheckBox radio;
        private System.Windows.Forms.CheckBox term;
        private System.Windows.Forms.CheckBox print;
        private System.Windows.Forms.CheckBox emp;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.Label urei;
        private System.Windows.Forms.Label mara;
        private System.Windows.Forms.Label demon;
        private System.Windows.Forms.Label polterheist;
        private System.Windows.Forms.Label spirit;
        private System.Windows.Forms.Label mirage;
        private System.Windows.Forms.Label shadow;
        private System.Windows.Forms.Label jin;
        private System.Windows.Forms.Label phantom;
        private System.Windows.Forms.Label oni;
        private System.Windows.Forms.Label revenant;
        private System.Windows.Forms.Label banshi;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.GroupBox descriptionBox;
        private System.Windows.Forms.Label emp_key;
        private System.Windows.Forms.Label print_key;
        private System.Windows.Forms.Label radio_key;
        private System.Windows.Forms.Label term_key;
        private System.Windows.Forms.Label notes_key;
        private System.Windows.Forms.Label reset_key;
        private System.Windows.Forms.Label orb_key;
        private System.Windows.Forms.StatusStrip HotkeyStrip;
        private System.Windows.Forms.ToolStripStatusLabel HotkeyStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel HotkeyStatusLabel2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel separator;
        private System.Windows.Forms.ToolStripStatusLabel SettingsResetLabel1;
        private System.Windows.Forms.ToolStripStatusLabel SettingsResetLabel2;
        private System.Windows.Forms.Label labelCopyright;
    }
}

