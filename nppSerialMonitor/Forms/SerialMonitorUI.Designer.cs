namespace Kbg.NppPluginNET
{
    partial class SerialMonitorUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBoxPort = new System.Windows.Forms.ComboBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ComboBoxBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.ComboBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.97102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.02898F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonOpen, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxParity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxStopBits, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxDataBits, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxBaud, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ComboBoxPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 191);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ComboBoxPort
            // 
            this.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ComboBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxPort.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxPort.FormattingEnabled = true;
            this.ComboBoxPort.Location = new System.Drawing.Point(92, 1);
            this.ComboBoxPort.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBoxPort.Name = "ComboBoxPort";
            this.ComboBoxPort.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxPort.Sorted = true;
            this.ComboBoxPort.TabIndex = 0;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOpen.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpen.Location = new System.Drawing.Point(94, 164);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(179, 24);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ComboBoxBaud
            // 
            this.ComboBoxBaud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ComboBoxBaud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxBaud.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxBaud.FormattingEnabled = true;
            this.ComboBoxBaud.Location = new System.Drawing.Point(92, 24);
            this.ComboBoxBaud.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBoxBaud.Name = "ComboBoxBaud";
            this.ComboBoxBaud.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxBaud.Sorted = true;
            this.ComboBoxBaud.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Baud:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxDataBits
            // 
            this.ComboBoxDataBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ComboBoxDataBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxDataBits.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxDataBits.FormattingEnabled = true;
            this.ComboBoxDataBits.Location = new System.Drawing.Point(92, 47);
            this.ComboBoxDataBits.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBoxDataBits.Name = "ComboBoxDataBits";
            this.ComboBoxDataBits.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxDataBits.Sorted = true;
            this.ComboBoxDataBits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data bits:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComboBoxStopBits
            // 
            this.ComboBoxStopBits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ComboBoxStopBits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxStopBits.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxStopBits.FormattingEnabled = true;
            this.ComboBoxStopBits.Location = new System.Drawing.Point(92, 93);
            this.ComboBoxStopBits.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBoxStopBits.Name = "ComboBoxStopBits";
            this.ComboBoxStopBits.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxStopBits.Sorted = true;
            this.ComboBoxStopBits.TabIndex = 6;
            // 
            // ComboBoxParity
            // 
            this.ComboBoxParity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ComboBoxParity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBoxParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxParity.ForeColor = System.Drawing.Color.Gainsboro;
            this.ComboBoxParity.FormattingEnabled = true;
            this.ComboBoxParity.Location = new System.Drawing.Point(92, 70);
            this.ComboBoxParity.Margin = new System.Windows.Forms.Padding(1);
            this.ComboBoxParity.Name = "ComboBoxParity";
            this.ComboBoxParity.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxParity.Sorted = true;
            this.ComboBoxParity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop bits:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Parity:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialMonitorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(276, 192);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 231);
            this.Name = "SerialMonitorUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Serial Monitor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ComboBoxPort;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxBaud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxParity;
        private System.Windows.Forms.ComboBox ComboBoxStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxDataBits;
    }
}