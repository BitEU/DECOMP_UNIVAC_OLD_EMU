namespace mk152
{
	// Token: 0x0200000B RID: 11
	public partial class UNIVAC1532 : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00152564 File Offset: 0x00150964
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x001525B4 File Offset: 0x001509B4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.REG_OUTPUT = new global::System.Windows.Forms.TextBox();
			this.REG_INPUT = new global::System.Windows.Forms.TextBox();
			this.KSR35 = new global::System.Windows.Forms.RichTextBox();
			this.CHANNEL = new global::System.Windows.Forms.ListBox();
			this.PRINTER = new global::System.Windows.Forms.Button();
			this.PUNCH = new global::System.Windows.Forms.Button();
			this.KEYBOARD = new global::System.Windows.Forms.Button();
			this.READER = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.FILE = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			this.REG_OUTPUT.BackColor = global::System.Drawing.Color.Black;
			this.REG_OUTPUT.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.REG_OUTPUT.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			global::System.Windows.Forms.Control reg_OUTPUT = this.REG_OUTPUT;
			global::System.Drawing.Point point = new global::System.Drawing.Point(344, 12);
			reg_OUTPUT.Location = point;
			this.REG_OUTPUT.Name = "REG_OUTPUT";
			global::System.Windows.Forms.Control reg_OUTPUT2 = this.REG_OUTPUT;
			global::System.Drawing.Size size = new global::System.Drawing.Size(100, 29);
			reg_OUTPUT2.Size = size;
			this.REG_OUTPUT.TabIndex = 0;
			this.REG_OUTPUT.TabStop = false;
			this.REG_OUTPUT.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.REG_INPUT.BackColor = global::System.Drawing.Color.Black;
			this.REG_INPUT.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.REG_INPUT.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			global::System.Windows.Forms.Control reg_INPUT = this.REG_INPUT;
			point = new global::System.Drawing.Point(213, 12);
			reg_INPUT.Location = point;
			this.REG_INPUT.Name = "REG_INPUT";
			global::System.Windows.Forms.Control reg_INPUT2 = this.REG_INPUT;
			size = new global::System.Drawing.Size(100, 29);
			reg_INPUT2.Size = size;
			this.REG_INPUT.TabIndex = 1;
			this.REG_INPUT.TabStop = false;
			this.REG_INPUT.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Right;
			this.KSR35.AcceptsTab = true;
			this.KSR35.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.KSR35.DetectUrls = false;
			this.KSR35.Font = new global::System.Drawing.Font("Times New Roman", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control ksr = this.KSR35;
			point = new global::System.Drawing.Point(6, 149);
			ksr.Location = point;
			this.KSR35.Name = "KSR35";
			global::System.Windows.Forms.Control ksr2 = this.KSR35;
			size = new global::System.Drawing.Size(451, 461);
			ksr2.Size = size;
			this.KSR35.TabIndex = 0;
			this.KSR35.Text = "";
			this.CHANNEL.BackColor = global::System.Drawing.Color.Black;
			this.CHANNEL.ForeColor = global::System.Drawing.Color.White;
			this.CHANNEL.FormattingEnabled = true;
			this.CHANNEL.Items.AddRange(new object[]
			{
				"00", "01", "02", "03", "04", "05", "06", "07", "10", "11",
				"12", "13", "14", "15", "16", "17"
			});
			global::System.Windows.Forms.Control channel = this.CHANNEL;
			point = new global::System.Drawing.Point(27, 73);
			channel.Location = point;
			this.CHANNEL.Name = "CHANNEL";
			global::System.Windows.Forms.Control channel2 = this.CHANNEL;
			size = new global::System.Drawing.Size(52, 43);
			channel2.Size = size;
			this.CHANNEL.TabIndex = 3;
			this.CHANNEL.TabStop = false;
			this.PRINTER.BackColor = global::System.Drawing.Color.LightGray;
			global::System.Windows.Forms.Control printer = this.PRINTER;
			point = new global::System.Drawing.Point(375, 82);
			printer.Location = point;
			this.PRINTER.Name = "PRINTER";
			global::System.Windows.Forms.Control printer2 = this.PRINTER;
			size = new global::System.Drawing.Size(75, 23);
			printer2.Size = size;
			this.PRINTER.TabIndex = 5;
			this.PRINTER.TabStop = false;
			this.PRINTER.Text = "PRINTER";
			this.PRINTER.UseVisualStyleBackColor = false;
			this.PUNCH.BackColor = global::System.Drawing.Color.LightGray;
			global::System.Windows.Forms.Control punch = this.PUNCH;
			point = new global::System.Drawing.Point(294, 82);
			punch.Location = point;
			this.PUNCH.Name = "PUNCH";
			global::System.Windows.Forms.Control punch2 = this.PUNCH;
			size = new global::System.Drawing.Size(75, 23);
			punch2.Size = size;
			this.PUNCH.TabIndex = 6;
			this.PUNCH.TabStop = false;
			this.PUNCH.Text = "PUNCH";
			this.PUNCH.UseVisualStyleBackColor = false;
			this.KEYBOARD.BackColor = global::System.Drawing.Color.LightGray;
			global::System.Windows.Forms.Control keyboard = this.KEYBOARD;
			point = new global::System.Drawing.Point(213, 82);
			keyboard.Location = point;
			this.KEYBOARD.Name = "KEYBOARD";
			global::System.Windows.Forms.Control keyboard2 = this.KEYBOARD;
			size = new global::System.Drawing.Size(75, 23);
			keyboard2.Size = size;
			this.KEYBOARD.TabIndex = 7;
			this.KEYBOARD.TabStop = false;
			this.KEYBOARD.Text = "KEYBOARD";
			this.KEYBOARD.UseVisualStyleBackColor = false;
			this.READER.BackColor = global::System.Drawing.Color.LightGray;
			global::System.Windows.Forms.Control reader = this.READER;
			point = new global::System.Drawing.Point(132, 82);
			reader.Location = point;
			this.READER.Name = "READER";
			global::System.Windows.Forms.Control reader2 = this.READER;
			size = new global::System.Drawing.Size(75, 23);
			reader2.Size = size;
			this.READER.TabIndex = 8;
			this.READER.TabStop = false;
			this.READER.Text = "READER";
			this.READER.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			point = new global::System.Drawing.Point(24, 119);
			label.Location = point;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(51, 13);
			label2.Size = size;
			this.Label1.TabIndex = 9;
			this.Label1.Text = "I/O Chan";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
			point = new global::System.Drawing.Point(348, 44);
			label3.Location = point;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(96, 13);
			label4.Size = size;
			this.Label2.TabIndex = 10;
			this.Label2.Text = "   Computer Output";
			this.Label3.AutoSize = true;
			global::System.Windows.Forms.Control label5 = this.Label3;
			point = new global::System.Drawing.Point(224, 44);
			label5.Location = point;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(79, 13);
			label6.Size = size;
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Computer Input";
			this.FILE.BackColor = global::System.Drawing.Color.Black;
			this.FILE.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FILE.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			global::System.Windows.Forms.Control file = this.FILE;
			point = new global::System.Drawing.Point(27, 15);
			file.Location = point;
			this.FILE.Name = "FILE";
			global::System.Windows.Forms.Control file2 = this.FILE;
			size = new global::System.Drawing.Size(150, 26);
			file2.Size = size;
			this.FILE.TabIndex = 12;
			this.Label4.AutoSize = true;
			global::System.Windows.Forms.Control label7 = this.Label4;
			point = new global::System.Drawing.Point(37, 44);
			label7.Location = point;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(140, 13);
			label8.Size = size;
			this.Label4.TabIndex = 13;
			this.Label4.Text = "File Name for Punch / Read";
			this.Timer1.Enabled = true;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Checked = true;
			this.CheckBox1.CheckState = global::System.Windows.Forms.CheckState.Checked;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			point = new global::System.Drawing.Point(375, 118);
			checkBox.Location = point;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new global::System.Drawing.Size(74, 17);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 14;
			this.CheckBox1.Text = "Ignore CR";
			this.CheckBox1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF sizeF = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = sizeF;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(463, 617);
			this.ClientSize = size;
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.FILE);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.READER);
			this.Controls.Add(this.KEYBOARD);
			this.Controls.Add(this.PUNCH);
			this.Controls.Add(this.PRINTER);
			this.Controls.Add(this.CHANNEL);
			this.Controls.Add(this.KSR35);
			this.Controls.Add(this.REG_INPUT);
			this.Controls.Add(this.REG_OUTPUT);
			this.Name = "UNIVAC1532";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UNIVAC 1532 ";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000084 RID: 132
		private global::System.ComponentModel.IContainer components;
	}
}
