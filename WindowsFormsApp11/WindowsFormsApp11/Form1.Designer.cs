namespace WindowsFormsApp11
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatCheckBox1 = new FlatUI.FlatCheckBox();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatButton17 = new FlatUI.FlatButton();
            this.flatButton16 = new FlatUI.FlatButton();
            this.flatButton7 = new FlatUI.FlatButton();
            this.flatButton6 = new FlatUI.FlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtIsInjected = new System.Windows.Forms.Label();
            this.flatButton5 = new FlatUI.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.inputTPTo = new System.Windows.Forms.TextBox();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatButton15 = new FlatUI.FlatButton();
            this.flatButton14 = new FlatUI.FlatButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.flatButton13 = new FlatUI.FlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.flatButton12 = new FlatUI.FlatButton();
            this.flatButton11 = new FlatUI.FlatButton();
            this.flatButton10 = new FlatUI.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flatButton9 = new FlatUI.FlatButton();
            this.flatButton8 = new FlatUI.FlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flatTextBox2 = new FlatUI.FlatTextBox();
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.InjectedChecker = new System.Windows.Forms.Timer(this.components);
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.flatCheckBox1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.Maroon;
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(754, 354);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Big Boom";
            // 
            // flatCheckBox1
            // 
            this.flatCheckBox1.BackColor = System.Drawing.Color.Maroon;
            this.flatCheckBox1.BaseColor = System.Drawing.Color.Silver;
            this.flatCheckBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatCheckBox1.Checked = false;
            this.flatCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatCheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatCheckBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flatCheckBox1.Location = new System.Drawing.Point(573, 4);
            this.flatCheckBox1.Name = "flatCheckBox1";
            this.flatCheckBox1.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.flatCheckBox1.Size = new System.Drawing.Size(112, 22);
            this.flatCheckBox1.TabIndex = 13;
            this.flatCheckBox1.Text = "Top Most";
            this.flatCheckBox1.CheckedChanged += new FlatUI.FlatCheckBox.CheckedChangedEventHandler(this.FlatCheckBox1_CheckedChanged);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(732, 4);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 12;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(708, 3);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 11;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(851, 304);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.flatButton17);
            this.tabPage1.Controls.Add(this.flatButton16);
            this.tabPage1.Controls.Add(this.flatButton7);
            this.tabPage1.Controls.Add(this.flatButton6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.txtIsInjected);
            this.tabPage1.Controls.Add(this.flatButton5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inputTPTo);
            this.tabPage1.Controls.Add(this.fastColoredTextBox1);
            this.tabPage1.Controls.Add(this.flatButton4);
            this.tabPage1.Controls.Add(this.flatButton3);
            this.tabPage1.Controls.Add(this.flatButton2);
            this.tabPage1.Controls.Add(this.flatButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(843, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Executor";
            // 
            // flatButton17
            // 
            this.flatButton17.BackColor = System.Drawing.Color.Transparent;
            this.flatButton17.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton17.Location = new System.Drawing.Point(120, 215);
            this.flatButton17.Name = "flatButton17";
            this.flatButton17.Rounded = false;
            this.flatButton17.Size = new System.Drawing.Size(106, 32);
            this.flatButton17.TabIndex = 14;
            this.flatButton17.Text = "Open";
            this.flatButton17.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton17.Click += new System.EventHandler(this.FlatButton17_Click);
            // 
            // flatButton16
            // 
            this.flatButton16.BackColor = System.Drawing.Color.Transparent;
            this.flatButton16.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton16.Location = new System.Drawing.Point(271, 216);
            this.flatButton16.Name = "flatButton16";
            this.flatButton16.Rounded = false;
            this.flatButton16.Size = new System.Drawing.Size(106, 32);
            this.flatButton16.TabIndex = 13;
            this.flatButton16.Text = "Clear";
            this.flatButton16.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton16.Click += new System.EventHandler(this.FlatButton16_Click);
            // 
            // flatButton7
            // 
            this.flatButton7.BackColor = System.Drawing.Color.Transparent;
            this.flatButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton7.Location = new System.Drawing.Point(495, 112);
            this.flatButton7.Name = "flatButton7";
            this.flatButton7.Rounded = false;
            this.flatButton7.Size = new System.Drawing.Size(106, 32);
            this.flatButton7.TabIndex = 12;
            this.flatButton7.Text = "Forcefield";
            this.flatButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton7.Click += new System.EventHandler(this.FlatButton7_Click);
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(640, 112);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(106, 32);
            this.flatButton6.TabIndex = 11;
            this.flatButton6.Text = "Infinite Jump";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.Click += new System.EventHandler(this.FlatButton6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(495, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 24);
            this.textBox1.TabIndex = 10;
            // 
            // txtIsInjected
            // 
            this.txtIsInjected.AutoSize = true;
            this.txtIsInjected.BackColor = System.Drawing.Color.Transparent;
            this.txtIsInjected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsInjected.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIsInjected.Location = new System.Drawing.Point(491, 227);
            this.txtIsInjected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIsInjected.Name = "txtIsInjected";
            this.txtIsInjected.Size = new System.Drawing.Size(125, 20);
            this.txtIsInjected.TabIndex = 10;
            this.txtIsInjected.Text = "Is Injected: false";
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(628, 215);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(121, 32);
            this.flatButton5.TabIndex = 9;
            this.flatButton5.Text = "GO";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.FlatButton5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(565, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "TP To:";
            // 
            // inputTPTo
            // 
            this.inputTPTo.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTPTo.ForeColor = System.Drawing.Color.Gray;
            this.inputTPTo.Location = new System.Drawing.Point(628, 186);
            this.inputTPTo.Margin = new System.Windows.Forms.Padding(2);
            this.inputTPTo.Name = "inputTPTo";
            this.inputTPTo.Size = new System.Drawing.Size(118, 24);
            this.inputTPTo.TabIndex = 7;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(219, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(9, 6);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(480, 204);
            this.fastColoredTextBox1.TabIndex = 5;
            this.fastColoredTextBox1.Text = "--paste your script here";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(641, 18);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(106, 32);
            this.flatButton4.TabIndex = 4;
            this.flatButton4.Text = "Btools";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.FlatButton4_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(495, 18);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(106, 32);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "Walk Speed";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.FlatButton3_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(383, 216);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(106, 32);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Attach";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.FlatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(8, 216);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 0;
            this.flatButton1.Text = "Execute";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.FlatButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatButton15);
            this.tabPage2.Controls.Add(this.flatButton14);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.flatButton13);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.flatButton12);
            this.tabPage2.Controls.Add(this.flatButton11);
            this.tabPage2.Controls.Add(this.flatButton10);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.flatButton9);
            this.tabPage2.Controls.Add(this.flatButton8);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(843, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Games";
            // 
            // flatButton15
            // 
            this.flatButton15.BackColor = System.Drawing.Color.Transparent;
            this.flatButton15.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton15.Location = new System.Drawing.Point(584, 218);
            this.flatButton15.Name = "flatButton15";
            this.flatButton15.Rounded = false;
            this.flatButton15.Size = new System.Drawing.Size(154, 32);
            this.flatButton15.TabIndex = 13;
            this.flatButton15.Text = "Infinite Money";
            this.flatButton15.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton15.Click += new System.EventHandler(this.FlatButton15_Click);
            // 
            // flatButton14
            // 
            this.flatButton14.BackColor = System.Drawing.Color.Transparent;
            this.flatButton14.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton14.Location = new System.Drawing.Point(585, 166);
            this.flatButton14.Name = "flatButton14";
            this.flatButton14.Rounded = false;
            this.flatButton14.Size = new System.Drawing.Size(154, 46);
            this.flatButton14.TabIndex = 12;
            this.flatButton14.Text = "Granny Bring All Item";
            this.flatButton14.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton14.Click += new System.EventHandler(this.FlatButton14_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(585, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 154);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // flatButton13
            // 
            this.flatButton13.BackColor = System.Drawing.Color.Transparent;
            this.flatButton13.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton13.Location = new System.Drawing.Point(419, 166);
            this.flatButton13.Name = "flatButton13";
            this.flatButton13.Rounded = false;
            this.flatButton13.Size = new System.Drawing.Size(154, 32);
            this.flatButton13.TabIndex = 10;
            this.flatButton13.Text = "Inf Gems";
            this.flatButton13.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton13.Click += new System.EventHandler(this.FlatButton13_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(420, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 150);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Gray;
            this.textBox2.Location = new System.Drawing.Point(337, 217);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 24);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Money";
            // 
            // flatButton12
            // 
            this.flatButton12.BackColor = System.Drawing.Color.Transparent;
            this.flatButton12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton12.Location = new System.Drawing.Point(178, 220);
            this.flatButton12.Name = "flatButton12";
            this.flatButton12.Rounded = false;
            this.flatButton12.Size = new System.Drawing.Size(154, 21);
            this.flatButton12.TabIndex = 7;
            this.flatButton12.Text = "Unlimited Money";
            this.flatButton12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton12.Click += new System.EventHandler(this.FlatButton12_Click);
            // 
            // flatButton11
            // 
            this.flatButton11.BackColor = System.Drawing.Color.Transparent;
            this.flatButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton11.Location = new System.Drawing.Point(178, 193);
            this.flatButton11.Name = "flatButton11";
            this.flatButton11.Rounded = false;
            this.flatButton11.Size = new System.Drawing.Size(154, 21);
            this.flatButton11.TabIndex = 6;
            this.flatButton11.Text = "Painting Spawner";
            this.flatButton11.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton11.Click += new System.EventHandler(this.FlatButton11_Click);
            // 
            // flatButton10
            // 
            this.flatButton10.BackColor = System.Drawing.Color.Transparent;
            this.flatButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton10.Location = new System.Drawing.Point(178, 166);
            this.flatButton10.Name = "flatButton10";
            this.flatButton10.Rounded = false;
            this.flatButton10.Size = new System.Drawing.Size(154, 21);
            this.flatButton10.TabIndex = 5;
            this.flatButton10.Text = "Furniture Spawner GUI";
            this.flatButton10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton10.Click += new System.EventHandler(this.FlatButton10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(178, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 154);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // flatButton9
            // 
            this.flatButton9.BackColor = System.Drawing.Color.Transparent;
            this.flatButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton9.Location = new System.Drawing.Point(8, 204);
            this.flatButton9.Name = "flatButton9";
            this.flatButton9.Rounded = false;
            this.flatButton9.Size = new System.Drawing.Size(154, 32);
            this.flatButton9.TabIndex = 3;
            this.flatButton9.Text = "Titanium Blocks";
            this.flatButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton9.Click += new System.EventHandler(this.FlatButton9_Click);
            // 
            // flatButton8
            // 
            this.flatButton8.BackColor = System.Drawing.Color.Transparent;
            this.flatButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.flatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton8.Location = new System.Drawing.Point(8, 166);
            this.flatButton8.Name = "flatButton8";
            this.flatButton8.Rounded = false;
            this.flatButton8.Size = new System.Drawing.Size(154, 32);
            this.flatButton8.TabIndex = 2;
            this.flatButton8.Text = "Teleport To The End";
            this.flatButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton8.Click += new System.EventHandler(this.FlatButton8_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 154);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.flatTextBox2);
            this.tabPage3.Controls.Add(this.flatTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(843, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Credits";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 212);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // flatTextBox2
            // 
            this.flatTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox2.FocusOnHover = false;
            this.flatTextBox2.Location = new System.Drawing.Point(560, 3);
            this.flatTextBox2.MaxLength = 32767;
            this.flatTextBox2.Multiline = false;
            this.flatTextBox2.Name = "flatTextBox2";
            this.flatTextBox2.ReadOnly = false;
            this.flatTextBox2.Size = new System.Drawing.Size(190, 29);
            this.flatTextBox2.TabIndex = 1;
            this.flatTextBox2.Text = "Owner Of The Program: floppy";
            this.flatTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox2.UseSystemPasswordChar = false;
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Location = new System.Drawing.Point(3, 6);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = false;
            this.flatTextBox1.Size = new System.Drawing.Size(182, 29);
            this.flatTextBox1.TabIndex = 0;
            this.flatTextBox1.Text = "Created By: TomerGamerTv";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            // 
            // InjectedChecker
            // 
            this.InjectedChecker.Interval = 3000;
            this.InjectedChecker.Tick += new System.EventHandler(this.InjectedChecker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 354);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatTabControl flatTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private FlatUI.FlatButton flatButton1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatTextBox flatTextBox2;
        private FlatUI.FlatTextBox flatTextBox1;
        private FlatUI.FlatButton flatButton2;
        private System.Windows.Forms.Timer InjectedChecker;
        private System.Windows.Forms.Label txtIsInjected;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private FlatUI.FlatButton flatButton4;
        private FlatUI.FlatButton flatButton3;
        private FlatUI.FlatButton flatButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputTPTo;
        private System.Windows.Forms.TextBox textBox1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatCheckBox flatCheckBox1;
        private FlatUI.FlatButton flatButton7;
        private FlatUI.FlatButton flatButton6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FlatUI.FlatButton flatButton8;
        private FlatUI.FlatButton flatButton9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FlatUI.FlatButton flatButton12;
        private FlatUI.FlatButton flatButton11;
        private FlatUI.FlatButton flatButton10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FlatUI.FlatButton flatButton13;
        private System.Windows.Forms.PictureBox pictureBox5;
        private FlatUI.FlatButton flatButton15;
        private FlatUI.FlatButton flatButton14;
        private FlatUI.FlatButton flatButton16;
        private FlatUI.FlatButton flatButton17;
    }
}

