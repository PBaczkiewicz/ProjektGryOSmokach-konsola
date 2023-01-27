namespace Smoki
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.smokname = new System.Windows.Forms.Label();
            this.smoknameinput = new System.Windows.Forms.TextBox();
            this.smoktypeinput = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.smoktype = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.vitality = new System.Windows.Forms.Label();
            this.agility = new System.Windows.Forms.Label();
            this.charisma = new System.Windows.Forms.Label();
            this.strength = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.growth = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.special = new System.Windows.Forms.Label();
            this.damage = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.hitpoints = new System.Windows.Forms.Label();
            this.skill = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.skilldesc = new System.Windows.Forms.Label();
            this.opis = new System.Windows.Forms.RichTextBox();
            this.feed = new System.Windows.Forms.Button();
            this.strfood = new System.Windows.Forms.Button();
            this.chafood = new System.Windows.Forms.Button();
            this.agifood = new System.Windows.Forms.Button();
            this.witfood = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Button();
            this.strup = new System.Windows.Forms.Button();
            this.chaup = new System.Windows.Forms.Button();
            this.agiup = new System.Windows.Forms.Button();
            this.witup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gold = new System.Windows.Forms.Label();
            this.strcost = new System.Windows.Forms.Label();
            this.chacost = new System.Windows.Forms.Label();
            this.witcost = new System.Windows.Forms.Label();
            this.agicost = new System.Windows.Forms.Label();
            this.wyprawy = new System.Windows.Forms.Button();
            this.wyprawa1 = new System.Windows.Forms.Button();
            this.wyprawa2 = new System.Windows.Forms.Button();
            this.wyprawa3 = new System.Windows.Forms.Button();
            this.wopis1 = new System.Windows.Forms.Label();
            this.wopis2 = new System.Windows.Forms.Label();
            this.wopis3 = new System.Windows.Forms.Label();
            this.wyprawa0 = new System.Windows.Forms.ComboBox();
            this.wopis0 = new System.Windows.Forms.Label();
            this.fight = new System.Windows.Forms.Button();
            this.eskilldesc = new System.Windows.Forms.Label();
            this.eskill = new System.Windows.Forms.Label();
            this.estat9 = new System.Windows.Forms.Label();
            this.edoublehit = new System.Windows.Forms.Label();
            this.ehitpoints = new System.Windows.Forms.Label();
            this.edmg = new System.Windows.Forms.Label();
            this.especial = new System.Windows.Forms.Label();
            this.estat8 = new System.Windows.Forms.Label();
            this.estat7 = new System.Windows.Forms.Label();
            this.estat6 = new System.Windows.Forms.Label();
            this.estat5 = new System.Windows.Forms.Label();
            this.enemyspecies = new System.Windows.Forms.Label();
            this.elvl = new System.Windows.Forms.Label();
            this.evit = new System.Windows.Forms.Label();
            this.eagi = new System.Windows.Forms.Label();
            this.echa = new System.Windows.Forms.Label();
            this.estr = new System.Windows.Forms.Label();
            this.estat4 = new System.Windows.Forms.Label();
            this.estat3 = new System.Windows.Forms.Label();
            this.estat2 = new System.Windows.Forms.Label();
            this.estat1 = new System.Windows.Forms.Label();
            this.estat0 = new System.Windows.Forms.Label();
            this.enemytype = new System.Windows.Forms.Label();
            this.enemyname = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.starcie = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nowy smok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clock
            // 
            this.clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clock.AutoSize = true;
            this.clock.Enabled = false;
            this.clock.Location = new System.Drawing.Point(738, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(64, 20);
            this.clock.TabIndex = 2;
            this.clock.Text = "TI:ME:SS";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // smokname
            // 
            this.smokname.AutoSize = true;
            this.smokname.Location = new System.Drawing.Point(9, 7);
            this.smokname.Name = "smokname";
            this.smokname.Size = new System.Drawing.Size(83, 20);
            this.smokname.TabIndex = 4;
            this.smokname.Text = "Smokname";
            this.smokname.Visible = false;
            // 
            // smoknameinput
            // 
            this.smoknameinput.Location = new System.Drawing.Point(218, 5);
            this.smoknameinput.Name = "smoknameinput";
            this.smoknameinput.Size = new System.Drawing.Size(125, 27);
            this.smoknameinput.TabIndex = 6;
            this.smoknameinput.Text = "Imię Smoka";
            this.smoknameinput.Visible = false;
            this.smoknameinput.TextChanged += new System.EventHandler(this.smoknameinput_TextChanged);
            // 
            // smoktypeinput
            // 
            this.smoktypeinput.FormattingEnabled = true;
            this.smoktypeinput.Items.AddRange(new object[] {
            "Ogień",
            "Woda",
            "Ziemia",
            "Powietrze"});
            this.smoktypeinput.Location = new System.Drawing.Point(217, 38);
            this.smoktypeinput.Name = "smoktypeinput";
            this.smoktypeinput.Size = new System.Drawing.Size(126, 28);
            this.smoktypeinput.TabIndex = 8;
            this.smoktypeinput.Text = "Typ Smoka";
            this.smoktypeinput.Visible = false;
            this.smoktypeinput.SelectedIndexChanged += new System.EventHandler(this.smoktypeinput_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Stwórz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(9, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.Black;
            this.progressBar2.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar2.Location = new System.Drawing.Point(9, 158);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(125, 10);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 14;
            this.progressBar2.Visible = false;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.Black;
            this.progressBar3.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar3.Location = new System.Drawing.Point(9, 194);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(125, 10);
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 16;
            this.progressBar3.Visible = false;
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.Black;
            this.progressBar4.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar4.Location = new System.Drawing.Point(9, 230);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(125, 10);
            this.progressBar4.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar4.TabIndex = 18;
            this.progressBar4.Visible = false;
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar5.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar5.Location = new System.Drawing.Point(9, 266);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(125, 10);
            this.progressBar5.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar5.TabIndex = 20;
            this.progressBar5.Visible = false;
            // 
            // smoktype
            // 
            this.smoktype.AutoSize = true;
            this.smoktype.Location = new System.Drawing.Point(9, 67);
            this.smoktype.Name = "smoktype";
            this.smoktype.Size = new System.Drawing.Size(75, 20);
            this.smoktype.TabIndex = 5;
            this.smoktype.Text = "Smoktype";
            this.smoktype.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Poziom";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Siła";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Charyzma";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Zręczność";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Witalność";
            this.label6.Visible = false;
            // 
            // vitality
            // 
            this.vitality.AutoSize = true;
            this.vitality.Location = new System.Drawing.Point(90, 243);
            this.vitality.Name = "vitality";
            this.vitality.Size = new System.Drawing.Size(29, 20);
            this.vitality.TabIndex = 29;
            this.vitality.Text = "wit";
            this.vitality.Visible = false;
            // 
            // agility
            // 
            this.agility.AutoSize = true;
            this.agility.Location = new System.Drawing.Point(90, 207);
            this.agility.Name = "agility";
            this.agility.Size = new System.Drawing.Size(30, 20);
            this.agility.TabIndex = 28;
            this.agility.Text = "agi";
            this.agility.Visible = false;
            // 
            // charisma
            // 
            this.charisma.AutoSize = true;
            this.charisma.Location = new System.Drawing.Point(90, 171);
            this.charisma.Name = "charisma";
            this.charisma.Size = new System.Drawing.Size(32, 20);
            this.charisma.TabIndex = 27;
            this.charisma.Text = "cha";
            this.charisma.Visible = false;
            // 
            // strength
            // 
            this.strength.AutoSize = true;
            this.strength.Location = new System.Drawing.Point(90, 135);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(25, 20);
            this.strength.TabIndex = 26;
            this.strength.Text = "str";
            this.strength.Visible = false;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Location = new System.Drawing.Point(90, 95);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(24, 20);
            this.level.TabIndex = 30;
            this.level.Text = "lvl";
            this.level.Visible = false;
            // 
            // growth
            // 
            this.growth.AutoSize = true;
            this.growth.Location = new System.Drawing.Point(9, 29);
            this.growth.Name = "growth";
            this.growth.Size = new System.Drawing.Size(103, 20);
            this.growth.TabIndex = 31;
            this.growth.Text = "Smocze piskle";
            this.growth.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(443, -2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 32;
            this.button3.Text = "XP TEST";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Obrażenia";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Specjalny atak";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Zdrowie";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Wielokrotny atak";
            this.label10.Visible = false;
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.Location = new System.Drawing.Point(136, 326);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(67, 20);
            this.special.TabIndex = 37;
            this.special.Text = "special%";
            this.special.Visible = false;
            // 
            // damage
            // 
            this.damage.AutoSize = true;
            this.damage.Location = new System.Drawing.Point(136, 290);
            this.damage.Name = "damage";
            this.damage.Size = new System.Drawing.Size(40, 20);
            this.damage.TabIndex = 38;
            this.damage.Text = "dmg";
            this.damage.Visible = false;
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(136, 362);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(41, 20);
            this.speed.TabIndex = 40;
            this.speed.Text = "atk%";
            this.speed.Visible = false;
            // 
            // hitpoints
            // 
            this.hitpoints.AutoSize = true;
            this.hitpoints.Location = new System.Drawing.Point(136, 398);
            this.hitpoints.Name = "hitpoints";
            this.hitpoints.Size = new System.Drawing.Size(26, 20);
            this.hitpoints.TabIndex = 39;
            this.hitpoints.Text = "hp";
            this.hitpoints.Visible = false;
            // 
            // skill
            // 
            this.skill.AutoSize = true;
            this.skill.Location = new System.Drawing.Point(136, 433);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(34, 20);
            this.skill.TabIndex = 42;
            this.skill.Text = "skill";
            this.skill.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "Zdolność";
            this.label12.Visible = false;
            // 
            // skilldesc
            // 
            this.skilldesc.AutoSize = true;
            this.skilldesc.Location = new System.Drawing.Point(9, 453);
            this.skilldesc.Name = "skilldesc";
            this.skilldesc.Size = new System.Drawing.Size(58, 20);
            this.skilldesc.TabIndex = 43;
            this.skilldesc.Text = "label13";
            this.skilldesc.Visible = false;
            // 
            // opis
            // 
            this.opis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opis.Location = new System.Drawing.Point(481, 54);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(288, 399);
            this.opis.TabIndex = 44;
            this.opis.Text = "";
            this.opis.Visible = false;
            // 
            // feed
            // 
            this.feed.Location = new System.Drawing.Point(183, 104);
            this.feed.Name = "feed";
            this.feed.Size = new System.Drawing.Size(94, 29);
            this.feed.TabIndex = 45;
            this.feed.Text = "Nakarm";
            this.feed.UseVisualStyleBackColor = true;
            this.feed.Visible = false;
            this.feed.Click += new System.EventHandler(this.button4_Click);
            // 
            // strfood
            // 
            this.strfood.Location = new System.Drawing.Point(183, 139);
            this.strfood.Name = "strfood";
            this.strfood.Size = new System.Drawing.Size(94, 29);
            this.strfood.TabIndex = 46;
            this.strfood.Text = "Mięso";
            this.strfood.UseVisualStyleBackColor = true;
            this.strfood.Visible = false;
            this.strfood.Click += new System.EventHandler(this.strfood_Click);
            // 
            // chafood
            // 
            this.chafood.Location = new System.Drawing.Point(183, 175);
            this.chafood.Name = "chafood";
            this.chafood.Size = new System.Drawing.Size(94, 29);
            this.chafood.TabIndex = 47;
            this.chafood.Text = "Warzywa";
            this.chafood.UseVisualStyleBackColor = true;
            this.chafood.Visible = false;
            this.chafood.Click += new System.EventHandler(this.chafood_Click);
            // 
            // agifood
            // 
            this.agifood.Location = new System.Drawing.Point(183, 211);
            this.agifood.Name = "agifood";
            this.agifood.Size = new System.Drawing.Size(94, 29);
            this.agifood.TabIndex = 48;
            this.agifood.Text = "Owoce";
            this.agifood.UseVisualStyleBackColor = true;
            this.agifood.Visible = false;
            this.agifood.Click += new System.EventHandler(this.agifood_Click);
            // 
            // witfood
            // 
            this.witfood.Location = new System.Drawing.Point(183, 247);
            this.witfood.Name = "witfood";
            this.witfood.Size = new System.Drawing.Size(94, 29);
            this.witfood.TabIndex = 49;
            this.witfood.Text = "Nabiał";
            this.witfood.UseVisualStyleBackColor = true;
            this.witfood.Visible = false;
            this.witfood.Click += new System.EventHandler(this.witfood_Click);
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(283, 104);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(94, 29);
            this.train.TabIndex = 50;
            this.train.Text = "Trenuj";
            this.train.UseVisualStyleBackColor = true;
            this.train.Visible = false;
            this.train.Click += new System.EventHandler(this.button9_Click);
            // 
            // strup
            // 
            this.strup.Location = new System.Drawing.Point(283, 139);
            this.strup.Name = "strup";
            this.strup.Size = new System.Drawing.Size(94, 29);
            this.strup.TabIndex = 51;
            this.strup.Text = "Siłę";
            this.strup.UseVisualStyleBackColor = true;
            this.strup.Visible = false;
            this.strup.Click += new System.EventHandler(this.strup_Click);
            // 
            // chaup
            // 
            this.chaup.Location = new System.Drawing.Point(283, 175);
            this.chaup.Name = "chaup";
            this.chaup.Size = new System.Drawing.Size(94, 29);
            this.chaup.TabIndex = 52;
            this.chaup.Text = "Charyzmę";
            this.chaup.UseVisualStyleBackColor = true;
            this.chaup.Visible = false;
            this.chaup.Click += new System.EventHandler(this.chaup_Click);
            // 
            // agiup
            // 
            this.agiup.Location = new System.Drawing.Point(283, 211);
            this.agiup.Name = "agiup";
            this.agiup.Size = new System.Drawing.Size(94, 29);
            this.agiup.TabIndex = 53;
            this.agiup.Text = "Zręczność";
            this.agiup.UseVisualStyleBackColor = true;
            this.agiup.Visible = false;
            this.agiup.Click += new System.EventHandler(this.agiup_Click);
            // 
            // witup
            // 
            this.witup.Location = new System.Drawing.Point(283, 247);
            this.witup.Name = "witup";
            this.witup.Size = new System.Drawing.Size(94, 29);
            this.witup.TabIndex = 54;
            this.witup.Text = "Witalność";
            this.witup.UseVisualStyleBackColor = true;
            this.witup.Visible = false;
            this.witup.Click += new System.EventHandler(this.witup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Złoto";
            this.label1.Visible = false;
            // 
            // gold
            // 
            this.gold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gold.AutoSize = true;
            this.gold.Location = new System.Drawing.Point(564, 31);
            this.gold.Name = "gold";
            this.gold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gold.Size = new System.Drawing.Size(40, 20);
            this.gold.TabIndex = 56;
            this.gold.Text = "gold";
            this.gold.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.gold.Visible = false;
            // 
            // strcost
            // 
            this.strcost.AutoSize = true;
            this.strcost.Location = new System.Drawing.Point(383, 148);
            this.strcost.Name = "strcost";
            this.strcost.Size = new System.Drawing.Size(36, 20);
            this.strcost.TabIndex = 57;
            this.strcost.Text = "cost";
            this.strcost.Visible = false;
            // 
            // chacost
            // 
            this.chacost.AutoSize = true;
            this.chacost.Location = new System.Drawing.Point(383, 184);
            this.chacost.Name = "chacost";
            this.chacost.Size = new System.Drawing.Size(36, 20);
            this.chacost.TabIndex = 58;
            this.chacost.Text = "cost";
            this.chacost.Visible = false;
            // 
            // witcost
            // 
            this.witcost.AutoSize = true;
            this.witcost.Location = new System.Drawing.Point(383, 256);
            this.witcost.Name = "witcost";
            this.witcost.Size = new System.Drawing.Size(36, 20);
            this.witcost.TabIndex = 60;
            this.witcost.Text = "cost";
            this.witcost.Visible = false;
            // 
            // agicost
            // 
            this.agicost.AutoSize = true;
            this.agicost.Location = new System.Drawing.Point(383, 220);
            this.agicost.Name = "agicost";
            this.agicost.Size = new System.Drawing.Size(36, 20);
            this.agicost.TabIndex = 59;
            this.agicost.Text = "cost";
            this.agicost.Visible = false;
            // 
            // wyprawy
            // 
            this.wyprawy.Location = new System.Drawing.Point(359, 3);
            this.wyprawy.Name = "wyprawy";
            this.wyprawy.Size = new System.Drawing.Size(94, 29);
            this.wyprawy.TabIndex = 61;
            this.wyprawy.Text = "Wyprawy";
            this.wyprawy.UseVisualStyleBackColor = true;
            this.wyprawy.Click += new System.EventHandler(this.menuwypraw_Click_1);
            // 
            // wyprawa1
            // 
            this.wyprawa1.Location = new System.Drawing.Point(149, 17);
            this.wyprawa1.Name = "wyprawa1";
            this.wyprawa1.Size = new System.Drawing.Size(94, 29);
            this.wyprawa1.TabIndex = 62;
            this.wyprawa1.Text = "Polana";
            this.wyprawa1.UseVisualStyleBackColor = true;
            this.wyprawa1.Visible = false;
            this.wyprawa1.Click += new System.EventHandler(this.wyprawa1_Click);
            // 
            // wyprawa2
            // 
            this.wyprawa2.Enabled = false;
            this.wyprawa2.Location = new System.Drawing.Point(148, 53);
            this.wyprawa2.Name = "wyprawa2";
            this.wyprawa2.Size = new System.Drawing.Size(94, 29);
            this.wyprawa2.TabIndex = 63;
            this.wyprawa2.Text = "Wzgórza";
            this.wyprawa2.UseVisualStyleBackColor = true;
            this.wyprawa2.Visible = false;
            this.wyprawa2.Click += new System.EventHandler(this.wyprawa2_Click);
            // 
            // wyprawa3
            // 
            this.wyprawa3.Enabled = false;
            this.wyprawa3.Location = new System.Drawing.Point(149, 88);
            this.wyprawa3.Name = "wyprawa3";
            this.wyprawa3.Size = new System.Drawing.Size(94, 29);
            this.wyprawa3.TabIndex = 64;
            this.wyprawa3.Text = "Góry";
            this.wyprawa3.UseVisualStyleBackColor = true;
            this.wyprawa3.Visible = false;
            this.wyprawa3.Click += new System.EventHandler(this.wyprawa3_Click);
            // 
            // wopis1
            // 
            this.wopis1.AutoSize = true;
            this.wopis1.Location = new System.Drawing.Point(249, 26);
            this.wopis1.Name = "wopis1";
            this.wopis1.Size = new System.Drawing.Size(80, 20);
            this.wopis1.TabIndex = 65;
            this.wopis1.Text = "Poziom 1+";
            this.wopis1.Visible = false;
            // 
            // wopis2
            // 
            this.wopis2.AutoSize = true;
            this.wopis2.Location = new System.Drawing.Point(250, 62);
            this.wopis2.Name = "wopis2";
            this.wopis2.Size = new System.Drawing.Size(80, 20);
            this.wopis2.TabIndex = 66;
            this.wopis2.Text = "Poziom 5+";
            this.wopis2.Visible = false;
            // 
            // wopis3
            // 
            this.wopis3.AutoSize = true;
            this.wopis3.Location = new System.Drawing.Point(250, 97);
            this.wopis3.Name = "wopis3";
            this.wopis3.Size = new System.Drawing.Size(88, 20);
            this.wopis3.TabIndex = 67;
            this.wopis3.Text = "Poziom 10+";
            this.wopis3.Visible = false;
            // 
            // wyprawa0
            // 
            this.wyprawa0.FormattingEnabled = true;
            this.wyprawa0.Items.AddRange(new object[] {
            "15 minut",
            "30 minut",
            "60 minut",
            "120 minut"});
            this.wyprawa0.Location = new System.Drawing.Point(13, 53);
            this.wyprawa0.Name = "wyprawa0";
            this.wyprawa0.Size = new System.Drawing.Size(125, 28);
            this.wyprawa0.TabIndex = 68;
            this.wyprawa0.Visible = false;
            this.wyprawa0.SelectedIndexChanged += new System.EventHandler(this.wyprawa0_SelectedIndexChanged);
            // 
            // wopis0
            // 
            this.wopis0.AutoSize = true;
            this.wopis0.Location = new System.Drawing.Point(13, 21);
            this.wopis0.Name = "wopis0";
            this.wopis0.Size = new System.Drawing.Size(125, 20);
            this.wopis0.TabIndex = 69;
            this.wopis0.Text = "Długość wyprawy";
            this.wopis0.Visible = false;
            // 
            // fight
            // 
            this.fight.Location = new System.Drawing.Point(359, 38);
            this.fight.Name = "fight";
            this.fight.Size = new System.Drawing.Size(94, 29);
            this.fight.TabIndex = 70;
            this.fight.Text = "Walka";
            this.fight.UseVisualStyleBackColor = true;
            this.fight.Click += new System.EventHandler(this.Fight_Click);
            // 
            // eskilldesc
            // 
            this.eskilldesc.AutoSize = true;
            this.eskilldesc.Location = new System.Drawing.Point(543, 453);
            this.eskilldesc.Name = "eskilldesc";
            this.eskilldesc.Size = new System.Drawing.Size(0, 20);
            this.eskilldesc.TabIndex = 95;
            this.eskilldesc.Visible = false;
            // 
            // eskill
            // 
            this.eskill.AutoSize = true;
            this.eskill.Location = new System.Drawing.Point(670, 433);
            this.eskill.Name = "eskill";
            this.eskill.Size = new System.Drawing.Size(0, 20);
            this.eskill.TabIndex = 94;
            this.eskill.Visible = false;
            // 
            // estat9
            // 
            this.estat9.AutoSize = true;
            this.estat9.Location = new System.Drawing.Point(543, 433);
            this.estat9.Name = "estat9";
            this.estat9.Size = new System.Drawing.Size(70, 20);
            this.estat9.TabIndex = 93;
            this.estat9.Text = "Zdolność";
            this.estat9.Visible = false;
            // 
            // edoublehit
            // 
            this.edoublehit.AutoSize = true;
            this.edoublehit.Location = new System.Drawing.Point(670, 362);
            this.edoublehit.Name = "edoublehit";
            this.edoublehit.Size = new System.Drawing.Size(41, 20);
            this.edoublehit.TabIndex = 92;
            this.edoublehit.Text = "atk%";
            this.edoublehit.Visible = false;
            // 
            // ehitpoints
            // 
            this.ehitpoints.AutoSize = true;
            this.ehitpoints.Location = new System.Drawing.Point(670, 398);
            this.ehitpoints.Name = "ehitpoints";
            this.ehitpoints.Size = new System.Drawing.Size(26, 20);
            this.ehitpoints.TabIndex = 91;
            this.ehitpoints.Text = "hp";
            this.ehitpoints.Visible = false;
            // 
            // edmg
            // 
            this.edmg.AutoSize = true;
            this.edmg.Location = new System.Drawing.Point(670, 290);
            this.edmg.Name = "edmg";
            this.edmg.Size = new System.Drawing.Size(40, 20);
            this.edmg.TabIndex = 90;
            this.edmg.Text = "dmg";
            this.edmg.Visible = false;
            // 
            // especial
            // 
            this.especial.AutoSize = true;
            this.especial.Location = new System.Drawing.Point(670, 326);
            this.especial.Name = "especial";
            this.especial.Size = new System.Drawing.Size(67, 20);
            this.especial.TabIndex = 89;
            this.especial.Text = "special%";
            this.especial.Visible = false;
            // 
            // estat8
            // 
            this.estat8.AutoSize = true;
            this.estat8.Location = new System.Drawing.Point(544, 398);
            this.estat8.Name = "estat8";
            this.estat8.Size = new System.Drawing.Size(64, 20);
            this.estat8.TabIndex = 88;
            this.estat8.Text = "Zdrowie";
            this.estat8.Visible = false;
            // 
            // estat7
            // 
            this.estat7.AutoSize = true;
            this.estat7.Location = new System.Drawing.Point(544, 362);
            this.estat7.Name = "estat7";
            this.estat7.Size = new System.Drawing.Size(121, 20);
            this.estat7.TabIndex = 87;
            this.estat7.Text = "Wielokrotny atak";
            this.estat7.Visible = false;
            // 
            // estat6
            // 
            this.estat6.AutoSize = true;
            this.estat6.Location = new System.Drawing.Point(544, 326);
            this.estat6.Name = "estat6";
            this.estat6.Size = new System.Drawing.Size(104, 20);
            this.estat6.TabIndex = 86;
            this.estat6.Text = "Specjalny atak";
            this.estat6.Visible = false;
            // 
            // estat5
            // 
            this.estat5.AutoSize = true;
            this.estat5.Location = new System.Drawing.Point(544, 290);
            this.estat5.Name = "estat5";
            this.estat5.Size = new System.Drawing.Size(77, 20);
            this.estat5.TabIndex = 85;
            this.estat5.Text = "Obrażenia";
            this.estat5.Visible = false;
            // 
            // enemyspecies
            // 
            this.enemyspecies.AutoSize = true;
            this.enemyspecies.Location = new System.Drawing.Point(543, 29);
            this.enemyspecies.Name = "enemyspecies";
            this.enemyspecies.Size = new System.Drawing.Size(101, 20);
            this.enemyspecies.TabIndex = 84;
            this.enemyspecies.Text = "Enemyspecies";
            this.enemyspecies.Visible = false;
            // 
            // elvl
            // 
            this.elvl.AutoSize = true;
            this.elvl.Location = new System.Drawing.Point(624, 99);
            this.elvl.Name = "elvl";
            this.elvl.Size = new System.Drawing.Size(24, 20);
            this.elvl.TabIndex = 83;
            this.elvl.Text = "lvl";
            this.elvl.Visible = false;
            // 
            // evit
            // 
            this.evit.AutoSize = true;
            this.evit.Location = new System.Drawing.Point(624, 243);
            this.evit.Name = "evit";
            this.evit.Size = new System.Drawing.Size(29, 20);
            this.evit.TabIndex = 82;
            this.evit.Text = "wit";
            this.evit.Visible = false;
            // 
            // eagi
            // 
            this.eagi.AutoSize = true;
            this.eagi.Location = new System.Drawing.Point(624, 207);
            this.eagi.Name = "eagi";
            this.eagi.Size = new System.Drawing.Size(30, 20);
            this.eagi.TabIndex = 81;
            this.eagi.Text = "agi";
            this.eagi.Visible = false;
            // 
            // echa
            // 
            this.echa.AutoSize = true;
            this.echa.Location = new System.Drawing.Point(624, 171);
            this.echa.Name = "echa";
            this.echa.Size = new System.Drawing.Size(32, 20);
            this.echa.TabIndex = 80;
            this.echa.Text = "cha";
            this.echa.Visible = false;
            // 
            // estr
            // 
            this.estr.AutoSize = true;
            this.estr.Location = new System.Drawing.Point(624, 135);
            this.estr.Name = "estr";
            this.estr.Size = new System.Drawing.Size(25, 20);
            this.estr.TabIndex = 79;
            this.estr.Text = "str";
            this.estr.Visible = false;
            // 
            // estat4
            // 
            this.estat4.AutoSize = true;
            this.estat4.Location = new System.Drawing.Point(543, 243);
            this.estat4.Name = "estat4";
            this.estat4.Size = new System.Drawing.Size(74, 20);
            this.estat4.TabIndex = 78;
            this.estat4.Text = "Witalność";
            this.estat4.Visible = false;
            // 
            // estat3
            // 
            this.estat3.AutoSize = true;
            this.estat3.Location = new System.Drawing.Point(543, 207);
            this.estat3.Name = "estat3";
            this.estat3.Size = new System.Drawing.Size(75, 20);
            this.estat3.TabIndex = 77;
            this.estat3.Text = "Zręczność";
            this.estat3.Visible = false;
            // 
            // estat2
            // 
            this.estat2.AutoSize = true;
            this.estat2.Location = new System.Drawing.Point(543, 171);
            this.estat2.Name = "estat2";
            this.estat2.Size = new System.Drawing.Size(74, 20);
            this.estat2.TabIndex = 76;
            this.estat2.Text = "Charyzma";
            this.estat2.Visible = false;
            // 
            // estat1
            // 
            this.estat1.AutoSize = true;
            this.estat1.Location = new System.Drawing.Point(543, 135);
            this.estat1.Name = "estat1";
            this.estat1.Size = new System.Drawing.Size(33, 20);
            this.estat1.TabIndex = 75;
            this.estat1.Text = "Siła";
            this.estat1.Visible = false;
            // 
            // estat0
            // 
            this.estat0.AutoSize = true;
            this.estat0.Location = new System.Drawing.Point(543, 95);
            this.estat0.Name = "estat0";
            this.estat0.Size = new System.Drawing.Size(58, 20);
            this.estat0.TabIndex = 74;
            this.estat0.Text = "Poziom";
            this.estat0.Visible = false;
            // 
            // enemytype
            // 
            this.enemytype.AutoSize = true;
            this.enemytype.Location = new System.Drawing.Point(514, 585);
            this.enemytype.Name = "enemytype";
            this.enemytype.Size = new System.Drawing.Size(0, 20);
            this.enemytype.TabIndex = 73;
            this.enemytype.Visible = false;
            // 
            // enemyname
            // 
            this.enemyname.AutoSize = true;
            this.enemyname.Location = new System.Drawing.Point(543, 7);
            this.enemyname.Name = "enemyname";
            this.enemyname.Size = new System.Drawing.Size(90, 20);
            this.enemyname.TabIndex = 72;
            this.enemyname.Text = "Enemyname";
            this.enemyname.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 96;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // starcie
            // 
            this.starcie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.starcie.Location = new System.Drawing.Point(226, 54);
            this.starcie.Name = "starcie";
            this.starcie.Size = new System.Drawing.Size(288, 399);
            this.starcie.TabIndex = 97;
            this.starcie.Text = "";
            this.starcie.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(325, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 98;
            this.button6.Text = "Powrót";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.eskilldesc);
            this.Controls.Add(this.eskill);
            this.Controls.Add(this.estat9);
            this.Controls.Add(this.edoublehit);
            this.Controls.Add(this.ehitpoints);
            this.Controls.Add(this.edmg);
            this.Controls.Add(this.especial);
            this.Controls.Add(this.estat8);
            this.Controls.Add(this.estat7);
            this.Controls.Add(this.estat6);
            this.Controls.Add(this.estat5);
            this.Controls.Add(this.elvl);
            this.Controls.Add(this.evit);
            this.Controls.Add(this.eagi);
            this.Controls.Add(this.echa);
            this.Controls.Add(this.estr);
            this.Controls.Add(this.estat4);
            this.Controls.Add(this.estat3);
            this.Controls.Add(this.estat2);
            this.Controls.Add(this.estat1);
            this.Controls.Add(this.estat0);
            this.Controls.Add(this.enemytype);
            this.Controls.Add(this.enemyname);
            this.Controls.Add(this.fight);
            this.Controls.Add(this.wyprawy);
            this.Controls.Add(this.witcost);
            this.Controls.Add(this.agicost);
            this.Controls.Add(this.chacost);
            this.Controls.Add(this.strcost);
            this.Controls.Add(this.gold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.witup);
            this.Controls.Add(this.agiup);
            this.Controls.Add(this.chaup);
            this.Controls.Add(this.strup);
            this.Controls.Add(this.train);
            this.Controls.Add(this.witfood);
            this.Controls.Add(this.agifood);
            this.Controls.Add(this.chafood);
            this.Controls.Add(this.strfood);
            this.Controls.Add(this.feed);
            this.Controls.Add(this.skilldesc);
            this.Controls.Add(this.skill);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.hitpoints);
            this.Controls.Add(this.damage);
            this.Controls.Add(this.special);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.growth);
            this.Controls.Add(this.level);
            this.Controls.Add(this.vitality);
            this.Controls.Add(this.agility);
            this.Controls.Add(this.charisma);
            this.Controls.Add(this.strength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar5);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.smoktype);
            this.Controls.Add(this.smokname);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.smoktypeinput);
            this.Controls.Add(this.smoknameinput);
            this.Controls.Add(this.starcie);
            this.Controls.Add(this.enemyspecies);
            this.Controls.Add(this.wopis0);
            this.Controls.Add(this.wyprawa0);
            this.Controls.Add(this.wyprawa1);
            this.Controls.Add(this.wopis3);
            this.Controls.Add(this.wopis2);
            this.Controls.Add(this.wopis1);
            this.Controls.Add(this.wyprawa3);
            this.Controls.Add(this.wyprawa2);
            this.Controls.Add(this.opis);
            this.Name = "Form1";
            this.Text = "Smoki rpg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        public TextBox smoknameinput;
        public ComboBox smoktypeinput;
        public Button button1;
        public Label clock;
        public Label smokname;
        public Button button2;
        public ProgressBar progressBar1;
        public ProgressBar progressBar2;
        public ProgressBar progressBar3;
        public ProgressBar progressBar4;
        public ProgressBar progressBar5;
        public Label smoktype;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label vitality;
        public Label agility;
        public Label charisma;
        public Label strength;
        public Label level;
        private Label growth;
        private Button button3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label special;
        private Label damage;
        private Label speed;
        private Label hitpoints;
        private Label skill;
        private Label label12;
        private Label skilldesc;
        private Button feed;
        private Button strfood;
        private Button chafood;
        private Button agifood;
        private Button witfood;
        private Button train;
        private Button strup;
        private Button chaup;
        private Button agiup;
        private Button witup;
        private Label label1;
        private Label gold;
        private Label strcost;
        private Label chacost;
        private Label witcost;
        private Label agicost;
        private Button wyprawy;
        private Button wyprawa1;
        private Button wyprawa2;
        private Button wyprawa3;
        private Label wopis1;
        private Label wopis2;
        private Label wopis3;
        private ComboBox wyprawa0;
        public Label wopis0;
        private Button fight;
        public RichTextBox opis;
        private Label eskilldesc;
        private Label eskill;
        private Label estat9;
        private Label edoublehit;
        private Label ehitpoints;
        private Label edmg;
        private Label especial;
        private Label estat8;
        private Label estat7;
        private Label estat6;
        private Label estat5;
        private Label enemyspecies;
        public Label elvl;
        public Label evit;
        public Label eagi;
        public Label echa;
        public Label estr;
        public Label estat4;
        public Label estat3;
        public Label estat2;
        public Label estat1;
        public Label estat0;
        public Label enemytype;
        public Label enemyname;
        private Button button4;
        public RichTextBox starcie;
        private Button button6;
    }
}