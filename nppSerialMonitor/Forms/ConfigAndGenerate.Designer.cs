﻿namespace Kbg.NppPluginNET
{
    partial class ConfigAndGenerate
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
            this.NumericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.CheckboxNumbers = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckboxLowercase = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckboxUppercase = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckboxBeginLetter = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckboxSimilar = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckboxDuplicate = new System.Windows.Forms.CheckBox();
            this.TextboxSymbols = new System.Windows.Forms.TextBox();
            this.CheckboxSymbols = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CheckboxSequential = new System.Windows.Forms.CheckBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.RadioButtonNew = new System.Windows.Forms.RadioButton();
            this.RadioButtonInline = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RadioButtonCurrent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TextboxSeperator = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TextboxPrefix = new System.Windows.Forms.TextBox();
            this.bLimitRemove = new System.Windows.Forms.Button();
            this.CheckboxCloseNoMessage = new System.Windows.Forms.CheckBox();
            this.CheckboxSaveOnClose = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CheckboxDoRandom = new System.Windows.Forms.CheckBox();
            this.NumericUpDownRandomMin = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownRandomMax = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRandomMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRandomMax)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericUpDownLength
            // 
            this.NumericUpDownLength.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownLength.Location = new System.Drawing.Point(174, 6);
            this.NumericUpDownLength.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumericUpDownLength.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownLength.Name = "NumericUpDownLength";
            this.NumericUpDownLength.Size = new System.Drawing.Size(77, 22);
            this.NumericUpDownLength.TabIndex = 0;
            this.NumericUpDownLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownLength.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String length:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity:";
            // 
            // NumericUpDownQuantity
            // 
            this.NumericUpDownQuantity.Increment = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Location = new System.Drawing.Point(174, 52);
            this.NumericUpDownQuantity.Maximum = new decimal(new int[] {
            10240,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownQuantity.Name = "NumericUpDownQuantity";
            this.NumericUpDownQuantity.Size = new System.Drawing.Size(77, 22);
            this.NumericUpDownQuantity.TabIndex = 2;
            this.NumericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownQuantity.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownQuantity.ValueChanged += new System.EventHandler(this.NumericUpDownQuantity_ValueChanged);
            // 
            // CheckboxNumbers
            // 
            this.CheckboxNumbers.AutoSize = true;
            this.CheckboxNumbers.Checked = true;
            this.CheckboxNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxNumbers.Location = new System.Drawing.Point(174, 77);
            this.CheckboxNumbers.Name = "CheckboxNumbers";
            this.CheckboxNumbers.Size = new System.Drawing.Size(96, 17);
            this.CheckboxNumbers.TabIndex = 4;
            this.CheckboxNumbers.Text = "( e.g. 123456 )";
            this.CheckboxNumbers.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Include numbers:";
            // 
            // CheckboxLowercase
            // 
            this.CheckboxLowercase.AutoSize = true;
            this.CheckboxLowercase.Checked = true;
            this.CheckboxLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxLowercase.Location = new System.Drawing.Point(174, 99);
            this.CheckboxLowercase.Name = "CheckboxLowercase";
            this.CheckboxLowercase.Size = new System.Drawing.Size(109, 17);
            this.CheckboxLowercase.TabIndex = 6;
            this.CheckboxLowercase.Text = "( e.g. abcdefgh )";
            this.CheckboxLowercase.UseVisualStyleBackColor = true;
            this.CheckboxLowercase.CheckedChanged += new System.EventHandler(this.CheckboxLowercase_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Include Lowercase Characters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Include Uppercase Characters:";
            // 
            // CheckboxUppercase
            // 
            this.CheckboxUppercase.AutoSize = true;
            this.CheckboxUppercase.Checked = true;
            this.CheckboxUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxUppercase.Location = new System.Drawing.Point(174, 121);
            this.CheckboxUppercase.Name = "CheckboxUppercase";
            this.CheckboxUppercase.Size = new System.Drawing.Size(116, 17);
            this.CheckboxUppercase.TabIndex = 8;
            this.CheckboxUppercase.Text = "( e.g. ABCDEFGH )";
            this.CheckboxUppercase.UseVisualStyleBackColor = true;
            this.CheckboxUppercase.CheckedChanged += new System.EventHandler(this.CheckboxUppercase_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Begin With A Letter:";
            // 
            // CheckboxBeginLetter
            // 
            this.CheckboxBeginLetter.AutoSize = true;
            this.CheckboxBeginLetter.Checked = true;
            this.CheckboxBeginLetter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxBeginLetter.Location = new System.Drawing.Point(174, 142);
            this.CheckboxBeginLetter.Name = "CheckboxBeginLetter";
            this.CheckboxBeginLetter.Size = new System.Drawing.Size(230, 17);
            this.CheckboxBeginLetter.TabIndex = 10;
            this.CheckboxBeginLetter.Text = "( don\'t begin with a number or symbol )";
            this.CheckboxBeginLetter.UseVisualStyleBackColor = true;
            this.CheckboxBeginLetter.CheckedChanged += new System.EventHandler(this.CheckboxBeginLetter_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "No Similar Characters:";
            // 
            // CheckboxSimilar
            // 
            this.CheckboxSimilar.AutoSize = true;
            this.CheckboxSimilar.Checked = true;
            this.CheckboxSimilar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSimilar.Location = new System.Drawing.Point(174, 186);
            this.CheckboxSimilar.Name = "CheckboxSimilar";
            this.CheckboxSimilar.Size = new System.Drawing.Size(265, 17);
            this.CheckboxSimilar.TabIndex = 12;
            this.CheckboxSimilar.Text = "( don\'t use characters like i, l, 1, L, o, 0, O, etc. )";
            this.CheckboxSimilar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "No Duplicate Characters:";
            // 
            // CheckboxDuplicate
            // 
            this.CheckboxDuplicate.AutoSize = true;
            this.CheckboxDuplicate.Checked = true;
            this.CheckboxDuplicate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxDuplicate.Location = new System.Drawing.Point(174, 207);
            this.CheckboxDuplicate.Name = "CheckboxDuplicate";
            this.CheckboxDuplicate.Size = new System.Drawing.Size(255, 17);
            this.CheckboxDuplicate.TabIndex = 14;
            this.CheckboxDuplicate.TabStop = false;
            this.CheckboxDuplicate.Text = "( don\'t use same characters, e.g.  aabb, 9955)";
            this.CheckboxDuplicate.UseVisualStyleBackColor = true;
            // 
            // TextboxSymbols
            // 
            this.TextboxSymbols.Location = new System.Drawing.Point(192, 161);
            this.TextboxSymbols.Name = "TextboxSymbols";
            this.TextboxSymbols.Size = new System.Drawing.Size(186, 22);
            this.TextboxSymbols.TabIndex = 16;
            this.TextboxSymbols.Text = "!\"#$%&\'()*+,-./:;<=>?@[]^_`{|}~";
            // 
            // CheckboxSymbols
            // 
            this.CheckboxSymbols.AutoSize = true;
            this.CheckboxSymbols.Checked = true;
            this.CheckboxSymbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSymbols.Location = new System.Drawing.Point(174, 164);
            this.CheckboxSymbols.Name = "CheckboxSymbols";
            this.CheckboxSymbols.Size = new System.Drawing.Size(15, 14);
            this.CheckboxSymbols.TabIndex = 17;
            this.CheckboxSymbols.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Include Symbols:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "No Sequential Characters:";
            // 
            // CheckboxSequential
            // 
            this.CheckboxSequential.AutoSize = true;
            this.CheckboxSequential.Checked = true;
            this.CheckboxSequential.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSequential.Location = new System.Drawing.Point(174, 229);
            this.CheckboxSequential.Name = "CheckboxSequential";
            this.CheckboxSequential.Size = new System.Drawing.Size(269, 17);
            this.CheckboxSequential.TabIndex = 19;
            this.CheckboxSequential.TabStop = false;
            this.CheckboxSequential.Text = "( don\'t use sequential characters, e.g. abc, 789 )";
            this.CheckboxSequential.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate.Location = new System.Drawing.Point(291, 346);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(144, 25);
            this.ButtonGenerate.TabIndex = 23;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // RadioButtonNew
            // 
            this.RadioButtonNew.AutoSize = true;
            this.RadioButtonNew.Checked = true;
            this.RadioButtonNew.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonNew.Name = "RadioButtonNew";
            this.RadioButtonNew.Size = new System.Drawing.Size(103, 17);
            this.RadioButtonNew.TabIndex = 25;
            this.RadioButtonNew.TabStop = true;
            this.RadioButtonNew.Text = "New document";
            this.RadioButtonNew.UseVisualStyleBackColor = true;
            // 
            // RadioButtonInline
            // 
            this.RadioButtonInline.AutoSize = true;
            this.RadioButtonInline.Location = new System.Drawing.Point(11, 57);
            this.RadioButtonInline.Name = "RadioButtonInline";
            this.RadioButtonInline.Size = new System.Drawing.Size(122, 17);
            this.RadioButtonInline.TabIndex = 26;
            this.RadioButtonInline.Text = "Current document,";
            this.RadioButtonInline.UseVisualStyleBackColor = true;
            this.RadioButtonInline.CheckedChanged += new System.EventHandler(this.RadioButtonInline_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Orange;
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(309, 302);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 12);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Save on close";
            this.toolTip1.SetToolTip(this.linkLabel1, "Click here to reset to default settings");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "(min:2, max:256)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "(min:1, max:10240)";
            // 
            // RadioButtonCurrent
            // 
            this.RadioButtonCurrent.AutoSize = true;
            this.RadioButtonCurrent.Location = new System.Drawing.Point(11, 38);
            this.RadioButtonCurrent.Name = "RadioButtonCurrent";
            this.RadioButtonCurrent.Size = new System.Drawing.Size(200, 17);
            this.RadioButtonCurrent.TabIndex = 29;
            this.RadioButtonCurrent.Text = "Current document, add to bottom";
            this.RadioButtonCurrent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TextboxSeperator);
            this.groupBox1.Controls.Add(this.RadioButtonNew);
            this.groupBox1.Controls.Add(this.RadioButtonCurrent);
            this.groupBox1.Controls.Add(this.RadioButtonInline);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 98);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate to:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "append to each line with seperator:";
            // 
            // TextboxSeperator
            // 
            this.TextboxSeperator.Enabled = false;
            this.TextboxSeperator.Location = new System.Drawing.Point(218, 70);
            this.TextboxSeperator.Margin = new System.Windows.Forms.Padding(1);
            this.TextboxSeperator.MaxLength = 1;
            this.TextboxSeperator.Name = "TextboxSeperator";
            this.TextboxSeperator.Size = new System.Drawing.Size(23, 22);
            this.TextboxSeperator.TabIndex = 30;
            this.TextboxSeperator.Text = ";";
            this.TextboxSeperator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Prefix:";
            // 
            // TextboxPrefix
            // 
            this.TextboxPrefix.Location = new System.Drawing.Point(174, 248);
            this.TextboxPrefix.Name = "TextboxPrefix";
            this.TextboxPrefix.Size = new System.Drawing.Size(265, 22);
            this.TextboxPrefix.TabIndex = 31;
            // 
            // bLimitRemove
            // 
            this.bLimitRemove.BackColor = System.Drawing.SystemColors.Control;
            this.bLimitRemove.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.bLimitRemove.Location = new System.Drawing.Point(356, 51);
            this.bLimitRemove.Margin = new System.Windows.Forms.Padding(0);
            this.bLimitRemove.Name = "bLimitRemove";
            this.bLimitRemove.Size = new System.Drawing.Size(73, 21);
            this.bLimitRemove.TabIndex = 33;
            this.bLimitRemove.Text = "Remove limit";
            this.bLimitRemove.UseVisualStyleBackColor = false;
            this.bLimitRemove.Click += new System.EventHandler(this.bLimitRemove_Click);
            // 
            // CheckboxCloseNoMessage
            // 
            this.CheckboxCloseNoMessage.AutoSize = true;
            this.CheckboxCloseNoMessage.Checked = true;
            this.CheckboxCloseNoMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxCloseNoMessage.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxCloseNoMessage.Location = new System.Drawing.Point(291, 318);
            this.CheckboxCloseNoMessage.Name = "CheckboxCloseNoMessage";
            this.CheckboxCloseNoMessage.Size = new System.Drawing.Size(135, 16);
            this.CheckboxCloseNoMessage.TabIndex = 34;
            this.CheckboxCloseNoMessage.Text = "Close form when completed";
            this.CheckboxCloseNoMessage.UseVisualStyleBackColor = true;
            // 
            // CheckboxSaveOnClose
            // 
            this.CheckboxSaveOnClose.AutoSize = true;
            this.CheckboxSaveOnClose.Checked = true;
            this.CheckboxSaveOnClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckboxSaveOnClose.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckboxSaveOnClose.Location = new System.Drawing.Point(291, 302);
            this.CheckboxSaveOnClose.Name = "CheckboxSaveOnClose";
            this.CheckboxSaveOnClose.Size = new System.Drawing.Size(15, 14);
            this.CheckboxSaveOnClose.TabIndex = 35;
            this.CheckboxSaveOnClose.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Random length:";
            // 
            // CheckboxDoRandom
            // 
            this.CheckboxDoRandom.AutoSize = true;
            this.CheckboxDoRandom.Location = new System.Drawing.Point(174, 31);
            this.CheckboxDoRandom.Name = "CheckboxDoRandom";
            this.CheckboxDoRandom.Size = new System.Drawing.Size(71, 17);
            this.CheckboxDoRandom.TabIndex = 37;
            this.CheckboxDoRandom.Text = "between";
            this.CheckboxDoRandom.UseVisualStyleBackColor = true;
            this.CheckboxDoRandom.CheckedChanged += new System.EventHandler(this.doRandom_CheckedChanged);
            // 
            // NumericUpDownRandomMin
            // 
            this.NumericUpDownRandomMin.Enabled = false;
            this.NumericUpDownRandomMin.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownRandomMin.Location = new System.Drawing.Point(244, 29);
            this.NumericUpDownRandomMin.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumericUpDownRandomMin.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownRandomMin.Name = "NumericUpDownRandomMin";
            this.NumericUpDownRandomMin.Size = new System.Drawing.Size(77, 22);
            this.NumericUpDownRandomMin.TabIndex = 39;
            this.NumericUpDownRandomMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownRandomMin.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDownRandomMin.Validating += new System.ComponentModel.CancelEventHandler(this.nudRandomMin_Validating);
            // 
            // NumericUpDownRandomMax
            // 
            this.NumericUpDownRandomMax.Enabled = false;
            this.NumericUpDownRandomMax.Increment = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownRandomMax.Location = new System.Drawing.Point(352, 29);
            this.NumericUpDownRandomMax.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NumericUpDownRandomMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericUpDownRandomMax.Name = "NumericUpDownRandomMax";
            this.NumericUpDownRandomMax.Size = new System.Drawing.Size(77, 22);
            this.NumericUpDownRandomMax.TabIndex = 40;
            this.NumericUpDownRandomMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownRandomMax.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.NumericUpDownRandomMax.Validating += new System.ComponentModel.CancelEventHandler(this.nudRandomMax_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "and";
            // 
            // toolTip2
            // 
            this.toolTip2.BackColor = System.Drawing.Color.LightCoral;
            this.toolTip2.ForeColor = System.Drawing.Color.Black;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            // 
            // ConfigAndGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(447, 378);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.NumericUpDownRandomMax);
            this.Controls.Add(this.NumericUpDownRandomMin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CheckboxDoRandom);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.CheckboxSaveOnClose);
            this.Controls.Add(this.CheckboxCloseNoMessage);
            this.Controls.Add(this.bLimitRemove);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TextboxPrefix);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CheckboxSequential);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CheckboxSymbols);
            this.Controls.Add(this.TextboxSymbols);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CheckboxDuplicate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckboxSimilar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckboxBeginLetter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CheckboxUppercase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckboxLowercase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckboxNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumericUpDownQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownLength);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigAndGenerate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate Random Strings";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownQuantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRandomMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRandomMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericUpDownLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownQuantity;
        private System.Windows.Forms.CheckBox CheckboxNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckboxLowercase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckboxUppercase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckboxBeginLetter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CheckboxSimilar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckboxDuplicate;
        private System.Windows.Forms.TextBox TextboxSymbols;
        private System.Windows.Forms.CheckBox CheckboxSymbols;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CheckboxSequential;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.RadioButton RadioButtonNew;
        private System.Windows.Forms.RadioButton RadioButtonInline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton RadioButtonCurrent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TextboxSeperator;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TextboxPrefix;
        private System.Windows.Forms.Button bLimitRemove;
        private System.Windows.Forms.CheckBox CheckboxCloseNoMessage;
        private System.Windows.Forms.CheckBox CheckboxSaveOnClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CheckboxDoRandom;
        private System.Windows.Forms.NumericUpDown NumericUpDownRandomMin;
        private System.Windows.Forms.NumericUpDown NumericUpDownRandomMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}