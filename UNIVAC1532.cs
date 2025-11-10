using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;

namespace mk152
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class UNIVAC1532 : Form
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x001524F8 File Offset: 0x001508F8
		[DebuggerNonUserCode]
		public UNIVAC1532()
		{
			base.Load += this.UNIVAC1532_Load;
			List<WeakReference> _ENCList = UNIVAC1532.__ENCList;
			lock (_ENCList)
			{
				UNIVAC1532.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x001530AC File Offset: 0x001514AC
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x001530C4 File Offset: 0x001514C4
		internal virtual RichTextBox KSR35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KSR35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.KSR35_KeyPress);
				bool flag = this._KSR35 != null;
				if (flag)
				{
					this._KSR35.KeyPress -= keyPressEventHandler;
				}
				this._KSR35 = value;
				flag = this._KSR35 != null;
				if (flag)
				{
					this._KSR35.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00153124 File Offset: 0x00151524
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0015313C File Offset: 0x0015153C
		public virtual TextBox REG_OUTPUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_OUTPUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._REG_OUTPUT = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00153148 File Offset: 0x00151548
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00153160 File Offset: 0x00151560
		public virtual TextBox REG_INPUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_INPUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._REG_INPUT = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0015316C File Offset: 0x0015156C
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00153184 File Offset: 0x00151584
		public virtual ListBox CHANNEL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CHANNEL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CHANNEL_SelectedIndexChanged);
				MouseEventHandler mouseEventHandler = new MouseEventHandler(this.CHANNEL_MouseClick);
				bool flag = this._CHANNEL != null;
				if (flag)
				{
					this._CHANNEL.SelectedIndexChanged -= eventHandler;
					this._CHANNEL.MouseClick -= mouseEventHandler;
				}
				this._CHANNEL = value;
				flag = this._CHANNEL != null;
				if (flag)
				{
					this._CHANNEL.SelectedIndexChanged += eventHandler;
					this._CHANNEL.MouseClick += mouseEventHandler;
				}
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0015320C File Offset: 0x0015160C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00153224 File Offset: 0x00151624
		public virtual Button PRINTER
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PRINTER;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PRINTER_Click);
				bool flag = this._PRINTER != null;
				if (flag)
				{
					this._PRINTER.Click -= eventHandler;
				}
				this._PRINTER = value;
				flag = this._PRINTER != null;
				if (flag)
				{
					this._PRINTER.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00153284 File Offset: 0x00151684
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0015329C File Offset: 0x0015169C
		public virtual Button PUNCH
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PUNCH;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PUNCH_Click);
				bool flag = this._PUNCH != null;
				if (flag)
				{
					this._PUNCH.Click -= eventHandler;
				}
				this._PUNCH = value;
				flag = this._PUNCH != null;
				if (flag)
				{
					this._PUNCH.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x001532FC File Offset: 0x001516FC
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00153314 File Offset: 0x00151714
		public virtual Button KEYBOARD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KEYBOARD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.KEYBOARD_Click);
				bool flag = this._KEYBOARD != null;
				if (flag)
				{
					this._KEYBOARD.Click -= eventHandler;
				}
				this._KEYBOARD = value;
				flag = this._KEYBOARD != null;
				if (flag)
				{
					this._KEYBOARD.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00153374 File Offset: 0x00151774
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0015338C File Offset: 0x0015178C
		public virtual Button READER
		{
			[DebuggerNonUserCode]
			get
			{
				return this._READER;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.READER_Click);
				bool flag = this._READER != null;
				if (flag)
				{
					this._READER.Click -= eventHandler;
				}
				this._READER = value;
				flag = this._READER != null;
				if (flag)
				{
					this._READER.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x001533EC File Offset: 0x001517EC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00153404 File Offset: 0x00151804
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00153410 File Offset: 0x00151810
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00153428 File Offset: 0x00151828
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00153434 File Offset: 0x00151834
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0015344C File Offset: 0x0015184C
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00153458 File Offset: 0x00151858
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00153470 File Offset: 0x00151870
		internal virtual TextBox FILE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FILE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.FILE_TextChanged);
				bool flag = this._FILE != null;
				if (flag)
				{
					this._FILE.TextChanged -= eventHandler;
				}
				this._FILE = value;
				flag = this._FILE != null;
				if (flag)
				{
					this._FILE.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000BE RID: 190 RVA: 0x001534D0 File Offset: 0x001518D0
		// (set) Token: 0x060000BF RID: 191 RVA: 0x001534E8 File Offset: 0x001518E8
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x001534F4 File Offset: 0x001518F4
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0015350C File Offset: 0x0015190C
		public virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0015356C File Offset: 0x0015196C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00153584 File Offset: 0x00151984
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00153590 File Offset: 0x00151990
		private void CHANNEL_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00153594 File Offset: 0x00151994
		private void CHANNEL_SelectedIndexChanged(object sender, EventArgs e)
		{
			checked
			{
				Module1.CONSOLE_CHAN = (byte)Math.Round(Conversion.Val("&O" + this.CHANNEL.Text));
				bool flag = Module1.CONSOLE_CHAN > 7;
				if (flag)
				{
					Module1.UPPER = 200;
				}
				else
				{
					Module1.UPPER = 0;
				}
				Module1.IN_IACW = (byte)(Module1.UPPER + 49 + 2 * Module1.CONSOLE_CHAN);
				Module1.OUT_IACW = (byte)(Module1.UPPER + 33 + 2 * Module1.CONSOLE_CHAN);
				Module1.EXF_IACW = (byte)(Module1.UPPER + 17 + 2 * Module1.CONSOLE_CHAN);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0015362C File Offset: 0x00151A2C
		public void PRINTER_OUT()
		{
			bool flag = Module1.OUT_ACTIVE[(int)Module1.CONSOLE_CHAN];
			checked
			{
				if (flag)
				{
					Module1.D2 = (uint)Module1.MEM[Module1.MEM[(int)Module1.OUT_IACW]];
					Module1.D2 = (uint)(unchecked((ulong)Module1.D2) & (ulong)Conversions.ToLong("&O377"));
					flag = (unchecked((ulong)Module1.D2) == 13UL) & this.CheckBox1.Checked;
					if (flag)
					{
						Module1.D2 = 32U;
					}
					Module1.LETTER = Strings.Chr((int)Module1.D2);
					this.KSR35.Text = this.KSR35.Text + Conversions.ToString(Module1.LETTER);
					this.KSR35.Select(this.KSR35.Text.Length, 0);
					Module1.D2 = Conversions.ToUInteger(Conversion.Oct(Module1.D2));
					this.REG_OUTPUT.Text = Support.Format(Module1.D2, "000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
					flag = Module1.MEM[(int)Module1.OUT_IACW] == Module1.MEM[(int)(Module1.OUT_IACW - 1)];
					if (flag)
					{
						Module1.OUT_ACTIVE[(int)Module1.CONSOLE_CHAN] = false;
					}
					Module1.MEM[(int)Module1.OUT_IACW] = Module1.MEM[(int)Module1.OUT_IACW] + 1;
				}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0015376C File Offset: 0x00151B6C
		private void KEYBOARD_IN()
		{
			bool flag = Module1.IN_ACTIVE[(int)Module1.CONSOLE_CHAN] & Module1.NEW_BYTE;
			checked
			{
				if (flag)
				{
					this.KSR35.Select(this.KSR35.Text.Length, 0);
					Module1.MEM[Module1.MEM[(int)Module1.IN_IACW]] = (int)Module1.IN_BYTE;
					Module1.D2 = Conversions.ToUInteger(Conversion.Oct(Module1.IN_BYTE));
					Module1.NEW_BYTE = false;
					this.REG_INPUT.Text = Support.Format(Module1.D2, "000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
					flag = Module1.MEM[(int)Module1.IN_IACW] == Module1.MEM[(int)(Module1.IN_IACW - 1)];
					if (flag)
					{
						Module1.IN_ACTIVE[(int)Module1.CONSOLE_CHAN] = false;
					}
					Module1.MEM[(int)Module1.IN_IACW] = Module1.MEM[(int)Module1.IN_IACW] + 1;
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00153848 File Offset: 0x00151C48
		public void READER_IN()
		{
			bool flag = Module1.IN_ACTIVE[(int)Module1.CONSOLE_CHAN];
			checked
			{
				if (flag)
				{
					bool flag2 = Module1.NEW_FILE & !Module1.OLD_FUNCTION_READ;
					if (flag2)
					{
						FileSystem.FileOpen(1, Module1.TAPE_FILE, OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
						Module1.NEW_FILE = false;
					}
				// Process multiple bytes per tick for faster loading (10 bytes per 3ms = ~3,333 bytes/sec)
				int bytesToProcess = 10;
				for (int i = 0; i < bytesToProcess; i++)
				{
					if (!Module1.IN_ACTIVE[(int)Module1.CONSOLE_CHAN])
					{
						break; // Stop if transfer completed
					}
					flag2 = FileSystem.EOF(1);
					if (flag2)
					{
						this.FILE.Text = "Tape Error";
					}
					else
					{
						FileSystem.Input(1, ref Module1.IN_BYTE);
					}
					Module1.MEM[Module1.MEM[(int)Module1.IN_IACW]] = (int)Module1.IN_BYTE;
					Module1.D2 = Conversions.ToUInteger(Conversion.Oct(Module1.IN_BYTE));
					flag2 = Module1.MEM[(int)Module1.IN_IACW] == Module1.MEM[(int)(Module1.IN_IACW - 1)];
					if (flag2)
					{
						Module1.IN_ACTIVE[(int)Module1.CONSOLE_CHAN] = false;
					}
					Module1.MEM[(int)Module1.IN_IACW] = Module1.MEM[(int)Module1.IN_IACW] + 1;
				}
				// Update UI with last byte read
				this.REG_INPUT.Text = Support.Format(Module1.D2, "000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				}
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00153950 File Offset: 0x00151D50
		private void ONLINE()
		{
			this.CONTROL();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0015395C File Offset: 0x00151D5C
		public void CONTROL()
		{
			bool flag = Module1.EXF_ACTIVE[(int)Module1.CONSOLE_CHAN];
			checked
			{
				bool flag2;
				if (flag)
				{
					Module1.OUT_BYTE = (byte)Module1.MEM[Module1.MEM[(int)Module1.EXF_IACW]];
					Module1.D2 = Conversions.ToUInteger(Conversion.Oct(Module1.OUT_BYTE));
					Module1.D2 = (uint)(unchecked((ulong)Module1.D2) & (ulong)Conversions.ToLong("&O377"));
					this.REG_OUTPUT.Text = Support.Format(Module1.D2, "000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
					flag = Module1.MEM[(int)Module1.EXF_IACW] == Module1.MEM[(int)(Module1.EXF_IACW - 1)];
					if (flag)
					{
						Module1.EXF_ACTIVE[(int)Module1.CONSOLE_CHAN] = false;
					}
					Module1.MEM[(int)Module1.EXF_IACW] = Module1.MEM[(int)Module1.EXF_IACW] + 1;
					flag = this.READER.BackColor == Color.OrangeRed;
					if (flag)
					{
						Module1.OLD_FUNCTION_READ = true;
					}
					this.READER.BackColor = Color.LightGray;
					this.PUNCH.BackColor = Color.LightGray;
					this.KEYBOARD.BackColor = Color.LightGray;
					this.PRINTER.BackColor = Color.LightGray;
					flag = Module1.OUT_BYTE == 9;
					if (flag)
					{
						Module1.NEW_FILE = false;
					}
					flag = Module1.OUT_BYTE == 13;
					if (flag)
					{
						this.PUNCH.BackColor = Color.OrangeRed;
					}
					flag = Module1.OUT_BYTE == 11;
					if (flag)
					{
						this.PRINTER.BackColor = Color.OrangeRed;
						this.PRINTER_OUT();
					}
					flag = (Module1.OUT_BYTE == 105) | (Module1.OUT_BYTE == 104);
					if (flag)
					{
						flag2 = Operators.CompareString(this.FILE.Text, "", false) == 0;
						if (flag2)
						{
							Interaction.MsgBox("mount Tape and select Reader", MsgBoxStyle.OkOnly, null);
						}
						else
						{
							this.READER.BackColor = Color.OrangeRed;
							Module1.TAPE_FILE += ".76";
							Module1.NEW_FILE = true;
						}
					}
					flag2 = (Module1.OUT_BYTE == 25) | (Module1.OUT_BYTE == 27);
					if (flag2)
					{
						this.KEYBOARD.BackColor = Color.OrangeRed;
						this.PRINTER.BackColor = Color.OrangeRed;
					}
				}
				flag2 = this.KEYBOARD.BackColor == Color.OrangeRed;
				if (flag2)
				{
					this.Timer1.Interval = 100;
					this.KEYBOARD_IN();
				}
				flag2 = this.PRINTER.BackColor == Color.OrangeRed;
				if (flag2)
				{
					this.Timer1.Interval = 100;
					this.PRINTER_OUT();
				}
				flag2 = this.READER.BackColor == Color.OrangeRed;
				if (flag2)
				{
					this.Timer1.Interval = 3;
					this.READER_IN();
				}
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00153C1C File Offset: 0x0015201C
		private void UNIVAC1532_Load(object sender, EventArgs e)
		{
			this.KSR35.Focus();
			Module1.CONSOLE_CHAN = 0;
			bool flag = Module1.CONSOLE_CHAN > 7;
			if (flag)
			{
				Module1.UPPER = 200;
			}
			else
			{
				Module1.UPPER = 0;
			}
			checked
			{
				Module1.IN_IACW = (byte)(Module1.UPPER + 49 + 2 * Module1.CONSOLE_CHAN);
				Module1.OUT_IACW = (byte)(Module1.UPPER + 33 + 2 * Module1.CONSOLE_CHAN);
				Module1.EXF_IACW = (byte)(Module1.UPPER + 17 + 2 * Module1.CONSOLE_CHAN);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00153CA0 File Offset: 0x001520A0
		private void PRINTER_Click(object sender, EventArgs e)
		{
			bool flag = this.PRINTER.BackColor == Color.LightGray;
			if (flag)
			{
				this.PRINTER.BackColor = Color.OrangeRed;
			}
			else
			{
				this.PRINTER.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00153CF0 File Offset: 0x001520F0
		private void PUNCH_Click(object sender, EventArgs e)
		{
			bool flag = this.PUNCH.BackColor == Color.LightGray;
			if (flag)
			{
				this.PUNCH.BackColor = Color.OrangeRed;
			}
			else
			{
				this.PUNCH.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00153D40 File Offset: 0x00152140
		private void KEYBOARD_Click(object sender, EventArgs e)
		{
			bool flag = this.KEYBOARD.BackColor == Color.LightGray;
			if (flag)
			{
				this.KEYBOARD.BackColor = Color.OrangeRed;
			}
			else
			{
				this.KEYBOARD.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00153D90 File Offset: 0x00152190
		private void READER_Click(object sender, EventArgs e)
		{
			bool flag = this.READER.BackColor == Color.LightGray;
			if (flag)
			{
				this.READER.BackColor = Color.OrangeRed;
				Module1.TAPE_FILE += ".76";
				Module1.NEW_FILE = true;
			}
			else
			{
				this.READER.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00153DF8 File Offset: 0x001521F8
		private void KSR35_KeyPress(object sender, KeyPressEventArgs e)
		{
			Module1.IN_BYTE = checked((byte)Strings.Asc(e.KeyChar));
			Module1.NEW_BYTE = true;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00153E14 File Offset: 0x00152214
		private void FILE_TextChanged(object sender, EventArgs e)
		{
			Module1.TAPE_FILE = this.FILE.Text;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00153E28 File Offset: 0x00152228
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.CONTROL();
		}

		// Token: 0x04000083 RID: 131
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("KSR35")]
		private RichTextBox _KSR35;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("REG_OUTPUT")]
		private TextBox _REG_OUTPUT;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("REG_INPUT")]
		private TextBox _REG_INPUT;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("CHANNEL")]
		private ListBox _CHANNEL;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("PRINTER")]
		private Button _PRINTER;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("PUNCH")]
		private Button _PUNCH;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("KEYBOARD")]
		private Button _KEYBOARD;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("READER")]
		private Button _READER;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("FILE")]
		private TextBox _FILE;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;
	}
}
