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
using mk152.My;

namespace mk152
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	internal partial class Univac1219 : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0014AC78 File Offset: 0x00149078
		[STAThread]
		public static void Main()
		{
			Application.Run(MyProject.Forms.Univac1219);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0014AC8C File Offset: 0x0014908C
		[DebuggerNonUserCode]
		public Univac1219()
		{
			base.Load += this.Form1_Load;
			List<WeakReference> _ENCList = Univac1219.__ENCList;
			lock (_ENCList)
			{
				Univac1219.__ENCList.Add(new WeakReference(this));
			}
			this.InitializeComponent();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0014AD34 File Offset: 0x00149134
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0014AD4C File Offset: 0x0014914C
		public virtual Button BUTTON_LOAD
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BUTTON_LOAD;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BUTTON_LOAD_Click);
				bool flag = this._BUTTON_LOAD != null;
				if (flag)
				{
					this._BUTTON_LOAD.Click -= eventHandler;
				}
				this._BUTTON_LOAD = value;
				flag = this._BUTTON_LOAD != null;
				if (flag)
				{
					this._BUTTON_LOAD.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0014ADAC File Offset: 0x001491AC
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0014ADC4 File Offset: 0x001491C4
		public virtual Button Button_DIS_P
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button_DIS_P;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button_DIS_P_Click);
				bool flag = this._Button_DIS_P != null;
				if (flag)
				{
					this._Button_DIS_P.Click -= eventHandler;
				}
				this._Button_DIS_P = value;
				flag = this._Button_DIS_P != null;
				if (flag)
				{
					this._Button_DIS_P.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0014AE24 File Offset: 0x00149224
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0014AE3C File Offset: 0x0014923C
		public virtual Button SKIP4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SKIP4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SKIP4_Click);
				bool flag = this._SKIP4 != null;
				if (flag)
				{
					this._SKIP4.Click -= eventHandler;
				}
				this._SKIP4 = value;
				flag = this._SKIP4 != null;
				if (flag)
				{
					this._SKIP4.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0014AE9C File Offset: 0x0014929C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0014AEB4 File Offset: 0x001492B4
		public virtual Button SKIP3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SKIP3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SKIP3_Click);
				bool flag = this._SKIP3 != null;
				if (flag)
				{
					this._SKIP3.Click -= eventHandler;
				}
				this._SKIP3 = value;
				flag = this._SKIP3 != null;
				if (flag)
				{
					this._SKIP3.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0014AF14 File Offset: 0x00149314
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0014AF2C File Offset: 0x0014932C
		public virtual Button SKIP2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SKIP2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SKIP2_Click);
				bool flag = this._SKIP2 != null;
				if (flag)
				{
					this._SKIP2.Click -= eventHandler;
				}
				this._SKIP2 = value;
				flag = this._SKIP2 != null;
				if (flag)
				{
					this._SKIP2.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0014AF8C File Offset: 0x0014938C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0014AFA4 File Offset: 0x001493A4
		public virtual Button SKIP1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SKIP1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SKIP1_Click);
				bool flag = this._SKIP1 != null;
				if (flag)
				{
					this._SKIP1.Click -= eventHandler;
				}
				this._SKIP1 = value;
				flag = this._SKIP1 != null;
				if (flag)
				{
					this._SKIP1.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0014B004 File Offset: 0x00149404
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0014B01C File Offset: 0x0014941C
		public virtual Button SKIP0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SKIP0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this._Command2_0_Click);
				bool flag = this._SKIP0 != null;
				if (flag)
				{
					this._SKIP0.Click -= eventHandler;
				}
				this._SKIP0 = value;
				flag = this._SKIP0 != null;
				if (flag)
				{
					this._SKIP0.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0014B07C File Offset: 0x0014947C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0014B094 File Offset: 0x00149494
		public virtual GroupBox Frame2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Frame2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Frame2 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0014B0A0 File Offset: 0x001494A0
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0014B0B8 File Offset: 0x001494B8
		public virtual Button START
		{
			[DebuggerNonUserCode]
			get
			{
				return this._START;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Start_Click);
				bool flag = this._START != null;
				if (flag)
				{
					this._START.Click -= eventHandler;
				}
				this._START = value;
				flag = this._START != null;
				if (flag)
				{
					this._START.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0014B118 File Offset: 0x00149518
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0014B130 File Offset: 0x00149530
		public virtual Button BUTTON_FII
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BUTTON_FII;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.BUTTON_FII_Click);
				bool flag = this._BUTTON_FII != null;
				if (flag)
				{
					this._BUTTON_FII.Click -= eventHandler;
				}
				this._BUTTON_FII = value;
				flag = this._BUTTON_FII != null;
				if (flag)
				{
					this._BUTTON_FII.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0014B190 File Offset: 0x00149590
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0014B1A8 File Offset: 0x001495A8
		public virtual TextBox REG_FUNC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_FUNC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_FUNC_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.REG_FUNC_KeyPress);
				bool flag = this._REG_FUNC != null;
				if (flag)
				{
					this._REG_FUNC.TextChanged -= eventHandler;
					this._REG_FUNC.KeyPress -= keyPressEventHandler;
				}
				this._REG_FUNC = value;
				flag = this._REG_FUNC != null;
				if (flag)
				{
					this._REG_FUNC.TextChanged += eventHandler;
					this._REG_FUNC.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0014B230 File Offset: 0x00149630
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0014B248 File Offset: 0x00149648
		public virtual Button SWITCH_FUNC
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SWITCH_FUNC;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SWITCH_FUNC_Click);
				bool flag = this._SWITCH_FUNC != null;
				if (flag)
				{
					this._SWITCH_FUNC.Click -= eventHandler;
				}
				this._SWITCH_FUNC = value;
				flag = this._SWITCH_FUNC != null;
				if (flag)
				{
					this._SWITCH_FUNC.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0014B2A8 File Offset: 0x001496A8
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0014B2C0 File Offset: 0x001496C0
		public virtual Button Stop_Renamed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Stop_Renamed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Stop_Click);
				bool flag = this._Stop_Renamed != null;
				if (flag)
				{
					this._Stop_Renamed.Click -= eventHandler;
				}
				this._Stop_Renamed = value;
				flag = this._Stop_Renamed != null;
				if (flag)
				{
					this._Stop_Renamed.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0014B320 File Offset: 0x00149720
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0014B338 File Offset: 0x00149738
		public virtual TextBox REG_SR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_SR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_SR_TextChanged);
				bool flag = this._REG_SR != null;
				if (flag)
				{
					this._REG_SR.TextChanged -= eventHandler;
				}
				this._REG_SR = value;
				flag = this._REG_SR != null;
				if (flag)
				{
					this._REG_SR.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0014B398 File Offset: 0x00149798
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0014B3B0 File Offset: 0x001497B0
		public virtual TextBox REG_AU
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_AU;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_AU_TextChanged);
				EventHandler eventHandler2 = new EventHandler(this.REG_AU_Leave);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.REG_AU_KeyPress);
				bool flag = this._REG_AU != null;
				if (flag)
				{
					this._REG_AU.TextChanged -= eventHandler;
					this._REG_AU.Leave -= eventHandler2;
					this._REG_AU.KeyPress -= keyPressEventHandler;
				}
				this._REG_AU = value;
				flag = this._REG_AU != null;
				if (flag)
				{
					this._REG_AU.TextChanged += eventHandler;
					this._REG_AU.Leave += eventHandler2;
					this._REG_AU.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0014B460 File Offset: 0x00149860
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0014B478 File Offset: 0x00149878
		public virtual TextBox REG_ICR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_ICR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_ICR_TextChanged);
				bool flag = this._REG_ICR != null;
				if (flag)
				{
					this._REG_ICR.TextChanged -= eventHandler;
				}
				this._REG_ICR = value;
				flag = this._REG_ICR != null;
				if (flag)
				{
					this._REG_ICR.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0014B4D8 File Offset: 0x001498D8
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0014B4F0 File Offset: 0x001498F0
		public virtual TextBox REG_PROG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_PROG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_PROG_Leave);
				EventHandler eventHandler2 = new EventHandler(this.REG_PROG_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.REG_PROG_KeyPress);
				bool flag = this._REG_PROG != null;
				if (flag)
				{
					this._REG_PROG.Leave -= eventHandler;
					this._REG_PROG.TextChanged -= eventHandler2;
					this._REG_PROG.KeyPress -= keyPressEventHandler;
				}
				this._REG_PROG = value;
				flag = this._REG_PROG != null;
				if (flag)
				{
					this._REG_PROG.Leave += eventHandler;
					this._REG_PROG.TextChanged += eventHandler2;
					this._REG_PROG.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0014B5A0 File Offset: 0x001499A0
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0014B5B8 File Offset: 0x001499B8
		public virtual TextBox REG_AL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._REG_AL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.REG_AL_Leave);
				EventHandler eventHandler2 = new EventHandler(this.REG_AL_TextChanged);
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.REG_AL_KeyPress);
				bool flag = this._REG_AL != null;
				if (flag)
				{
					this._REG_AL.Leave -= eventHandler;
					this._REG_AL.TextChanged -= eventHandler2;
					this._REG_AL.KeyPress -= keyPressEventHandler;
				}
				this._REG_AL = value;
				flag = this._REG_AL != null;
				if (flag)
				{
					this._REG_AL.Leave += eventHandler;
					this._REG_AL.TextChanged += eventHandler2;
					this._REG_AL.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0014B668 File Offset: 0x00149A68
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0014B680 File Offset: 0x00149A80
		public virtual Button SWITCH_CLEAR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SWITCH_CLEAR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SWITCH_CLEAR_Click);
				bool flag = this._SWITCH_CLEAR != null;
				if (flag)
				{
					this._SWITCH_CLEAR.Click -= eventHandler;
				}
				this._SWITCH_CLEAR = value;
				flag = this._SWITCH_CLEAR != null;
				if (flag)
				{
					this._SWITCH_CLEAR.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0014B6E0 File Offset: 0x00149AE0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0014B6F8 File Offset: 0x00149AF8
		public virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0014B704 File Offset: 0x00149B04
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0014B71C File Offset: 0x00149B1C
		public virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0014B728 File Offset: 0x00149B28
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0014B740 File Offset: 0x00149B40
		public virtual Label FII
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FII;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FII = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0014B74C File Offset: 0x00149B4C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0014B764 File Offset: 0x00149B64
		public virtual Label _Label3_2
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Label3_2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Label3_2 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0014B770 File Offset: 0x00149B70
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0014B788 File Offset: 0x00149B88
		public virtual Label _Label3_1
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Label3_1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Label3_1 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0014B794 File Offset: 0x00149B94
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0014B7AC File Offset: 0x00149BAC
		public virtual Label Label4
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0014B7B8 File Offset: 0x00149BB8
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0014B7D0 File Offset: 0x00149BD0
		public virtual Label _Label3_0
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__Label3_0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__Label3_0 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0014B7DC File Offset: 0x00149BDC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0014B7F4 File Offset: 0x00149BF4
		public virtual Label Label2
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0014B800 File Offset: 0x00149C00
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0014B818 File Offset: 0x00149C18
		public virtual Label Label1
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0014DCD0 File Offset: 0x0014C0D0
		// (set) Token: 0x06000062 RID: 98 RVA: 0x0014DCE8 File Offset: 0x0014C0E8
		public virtual GroupBox STOPS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOPS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._STOPS = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0014DCF4 File Offset: 0x0014C0F4
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0014DD0C File Offset: 0x0014C10C
		public virtual Button STOP4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOP4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.STOP4_Click);
				bool flag = this._STOP4 != null;
				if (flag)
				{
					this._STOP4.Click -= eventHandler;
				}
				this._STOP4 = value;
				flag = this._STOP4 != null;
				if (flag)
				{
					this._STOP4.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0014DD6C File Offset: 0x0014C16C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0014DD84 File Offset: 0x0014C184
		public virtual Button STOP3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOP3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this._Command1_3_Click);
				bool flag = this._STOP3 != null;
				if (flag)
				{
					this._STOP3.Click -= eventHandler;
				}
				this._STOP3 = value;
				flag = this._STOP3 != null;
				if (flag)
				{
					this._STOP3.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0014DDE4 File Offset: 0x0014C1E4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x0014DDFC File Offset: 0x0014C1FC
		public virtual Button STOP2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOP2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this._Command1_2_Click);
				bool flag = this._STOP2 != null;
				if (flag)
				{
					this._STOP2.Click -= eventHandler;
				}
				this._STOP2 = value;
				flag = this._STOP2 != null;
				if (flag)
				{
					this._STOP2.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0014DE5C File Offset: 0x0014C25C
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0014DE74 File Offset: 0x0014C274
		public virtual Button STOP1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOP1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this._Command1_1_Click);
				bool flag = this._STOP1 != null;
				if (flag)
				{
					this._STOP1.Click -= eventHandler;
				}
				this._STOP1 = value;
				flag = this._STOP1 != null;
				if (flag)
				{
					this._STOP1.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0014DED4 File Offset: 0x0014C2D4
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0014DEEC File Offset: 0x0014C2EC
		public virtual Button STOP0
		{
			[DebuggerNonUserCode]
			get
			{
				return this._STOP0;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this._Command1_0_Click);
				bool flag = this._STOP0 != null;
				if (flag)
				{
					this._STOP0.Click -= eventHandler;
				}
				this._STOP0 = value;
				flag = this._STOP0 != null;
				if (flag)
				{
					this._STOP0.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0014DF4C File Offset: 0x0014C34C
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0014DF64 File Offset: 0x0014C364
		public virtual Button SWITCH_MODE
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SWITCH_MODE;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.SWITCH_MODE_Click);
				bool flag = this._SWITCH_MODE != null;
				if (flag)
				{
					this._SWITCH_MODE.Click -= eventHandler;
				}
				this._SWITCH_MODE = value;
				flag = this._SWITCH_MODE != null;
				if (flag)
				{
					this._SWITCH_MODE.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0014DFC4 File Offset: 0x0014C3C4
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0014DFDC File Offset: 0x0014C3DC
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0014E03C File Offset: 0x0014C43C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0014E054 File Offset: 0x0014C454
		public virtual Timer Timer2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
				bool flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick -= eventHandler;
				}
				this._Timer2 = value;
				flag = this._Timer2 != null;
				if (flag)
				{
					this._Timer2.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0014E0B4 File Offset: 0x0014C4B4
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0014E0CC File Offset: 0x0014C4CC
		public virtual Label Label3
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

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0014E0D8 File Offset: 0x0014C4D8
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0014E0F0 File Offset: 0x0014C4F0
		internal virtual TextBox INS_SECOND
		{
			[DebuggerNonUserCode]
			get
			{
				return this._INS_SECOND;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._INS_SECOND = value;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0014E0FC File Offset: 0x0014C4FC
		private void Button_DIS_P_Click(object eventSender, EventArgs eventArgs)
		{
			bool flag = this.Button_DIS_P.BackColor == Color.WhiteSmoke;
			if (flag)
			{
				this.Button_DIS_P.BackColor = Color.Red;
				Module1.DISCONECT_P = true;
			}
			else
			{
				this.Button_DIS_P.BackColor = Color.WhiteSmoke;
				Module1.DISCONECT_P = false;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0014E158 File Offset: 0x0014C558
		private void BUTTON_LOAD_Click(object eventSender, EventArgs eventArgs)
		{
			Module1.P = Conversions.ToInteger("&O" + this.REG_PROG.Text);
			Module1.AL = Conversions.ToInteger("&O" + this.REG_AL.Text);
			bool flag = (Module1.P != 0) & (Module1.P < 3);
			checked
			{
				if (flag)
				{
					Module1.D = Conversions.ToInteger(Strings.Right(this.REG_AL.Text, 3));
					object obj = "MEMORY." + Conversions.ToString(Module1.D);
					Interaction.MsgBox(RuntimeHelpers.GetObjectValue(obj), MsgBoxStyle.OkOnly, null);
					switch (Module1.P)
					{
					case 1:
					{
						FileSystem.FileOpen(5, Conversions.ToString(obj), OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
						Module1.X = 0;
						int x;
						int num;
						do
						{
							FileSystem.Input(5, ref Module1.MEM[Module1.X]);
							Module1.X++;
							x = Module1.X;
							num = 32767;
						}
						while (x <= num);
						FileSystem.FileClose(new int[] { 5 });
						break;
					}
					case 2:
					{
						FileSystem.FileOpen(5, Conversions.ToString(obj), OpenMode.Output, OpenAccess.Default, OpenShare.Default, -1);
						Module1.X = 0;
						int num;
						int x2;
						do
						{
							FileSystem.PrintLine(5, new object[] { Module1.MEM[Module1.X] });
							Module1.X++;
							x2 = Module1.X;
							num = 32767;
						}
						while (x2 <= num);
						FileSystem.FileClose(new int[] { 5 });
						break;
					}
					}
				}
				else
				{
					Module1.P = 320;
					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
					this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0014E32C File Offset: 0x0014C72C
		public void Form1_Load(object eventSender, EventArgs eventArgs)
		{
			this.SWITCH_FUNC.BackColor = Color.WhiteSmoke;
			this.CLEAR();
			MyProject.Forms.UNIVAC1532.Show();
			this.Show();
			object obj = "MEMORY.0";
			FileSystem.FileOpen(5, Conversions.ToString(obj), OpenMode.Input, OpenAccess.Default, OpenShare.Default, -1);
			Module1.X = 0;
			checked
			{
				int x;
				int num;
				do
				{
					FileSystem.Input(5, ref Module1.MEM[Module1.X]);
					Module1.X++;
					x = Module1.X;
					num = 32767;
				}
				while (x <= num);
				FileSystem.FileClose(new int[] { 5 });
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0014E3CC File Offset: 0x0014C7CC
		private void REG_AL_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !Versioned.IsNumeric(e.KeyChar);
			if (flag)
			{
				switch (e.KeyChar)
				{
				case '\b':
				case '\r':
					goto IL_004E;
				}
				e.Handled = true;
				IL_004E:;
			}
			else
			{
				flag = (e.KeyChar == '8') | (e.KeyChar == '9');
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0014E450 File Offset: 0x0014C850
		private void REG_AL_TextChanged(object eventSender, EventArgs eventArgs)
		{
			this.lastREG_ALText = this.REG_AL.Text;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0014E468 File Offset: 0x0014C868
		private void REG_AL_Leave(object eventSender, EventArgs eventArgs)
		{
			Module1.D = Conversions.ToInteger(this.REG_AL.Text);
			this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0014E4A4 File Offset: 0x0014C8A4
		private void REG_AU_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !Versioned.IsNumeric(e.KeyChar);
			if (flag)
			{
				switch (e.KeyChar)
				{
				case '\b':
				case '\r':
					goto IL_004E;
				}
				e.Handled = true;
				IL_004E:;
			}
			else
			{
				flag = (e.KeyChar == '8') | (e.KeyChar == '9');
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0014E528 File Offset: 0x0014C928
		private void REG_AU_Leave(object eventSender, EventArgs eventArgs)
		{
			Module1.D = Conversions.ToInteger(this.REG_AU.Text);
			this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0014E564 File Offset: 0x0014C964
		private void REG_AU_TextChanged(object eventSender, EventArgs eventArgs)
		{
			this.lastREG_AUText = this.REG_AU.Text;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0014E57C File Offset: 0x0014C97C
		private void REG_FUNC_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !Versioned.IsNumeric(e.KeyChar);
			if (flag)
			{
				switch (e.KeyChar)
				{
				case '\b':
				case '\r':
					goto IL_004E;
				}
				e.Handled = true;
				IL_004E:;
			}
			else
			{
				flag = (e.KeyChar == '8') | (e.KeyChar == '9');
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0014E600 File Offset: 0x0014CA00
		private void REG_FUNC_TextChanged(object eventSender, EventArgs eventArgs)
		{
			this.REG_FUNC.Text = this.REG_FUNC.Text;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0014E61C File Offset: 0x0014CA1C
		private void REG_ICR_TextChanged(object eventSender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0014E620 File Offset: 0x0014CA20
		private void REG_PROG_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = !Versioned.IsNumeric(e.KeyChar);
			if (flag)
			{
				switch (e.KeyChar)
				{
				case '\b':
				case '\r':
					goto IL_004E;
				}
				e.Handled = true;
				IL_004E:;
			}
			else
			{
				flag = (e.KeyChar == '8') | (e.KeyChar == '9');
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0014E6A4 File Offset: 0x0014CAA4
		private void REG_PROG_TextChanged(object eventSender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0014E6A8 File Offset: 0x0014CAA8
		private void REG_PROG_Leave(object eventSender, EventArgs eventArgs)
		{
			Module1.D = Conversions.ToInteger(this.REG_PROG.Text);
			this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0014E6E4 File Offset: 0x0014CAE4
		private void REG_SR_TextChanged(object eventSender, EventArgs eventArgs)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0014E6E8 File Offset: 0x0014CAE8
		private void CLEAR()
		{
			this.REG_ICR.Text = Support.Format(0, "0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.REG_SR.Text = Support.Format(0, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.REG_AL.Text = Support.Format(0, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.REG_AU.Text = Support.Format(0, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.REG_PROG.Text = Support.Format(0, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.REG_FUNC.Text = Support.Format(0, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
			this.BUTTON_FII.BackColor = Color.Black;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0014E7BC File Offset: 0x0014CBBC
		private void EXECUTE()
		{
			Module1.BUSY = true;
			Module1.AU = Conversions.ToInteger("&O" + this.REG_AU.Text);
			Module1.AL = Conversions.ToInteger("&O" + this.REG_AL.Text);
			Module1.FUNC = Conversions.ToInteger("&O" + this.REG_FUNC.Text);
			Module1.P = Conversions.ToInteger("&O" + this.REG_PROG.Text);
			checked
			{
				Module1.ICR = (int)Math.Round(Conversion.Val("&O" + this.REG_ICR.Text));
				bool flag = Module1.ICR == 0;
				if (flag)
				{
					Module1.ICR = Module1.CONST_OCT_10;
				}
				Module1.SR = Conversions.ToInteger("&O" + this.REG_SR.Text);
				flag = !Module1.FUNCTION_REP;
				if (flag)
				{
					Module1.INS = Module1.MEM[Module1.P];
				}
				Module1.f = (int)Math.Round(Conversion.Int((double)Module1.INS / 4096.0));
				Module1.m = (int)Math.Round(Conversion.Int((double)(Module1.INS - Module1.f * 4096) / 64.0));
				Module1.k = Module1.INS & 63;
				Module1.u = Module1.INS & 4095;
				Module1.SEXT = Module1.u;
				flag = Module1.u > 2047;
				if (flag)
				{
					Module1.SEXT = Module1.u + 258048;
				}
				Module1.CODE = Module1.FUNC;
				flag = !Module1.FUNCTION_REP;
				if (flag)
				{
					Module1.u = Module1.INS & 4095;
					flag = Module1.f == 40;
					if (flag)
					{
						this.BUTTON_FII.BackColor = Color.Orange;
						this.REG_FUNC.Text = Conversion.Oct(Support.Format(Module1.m, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
						Module1.CODE = (int)Math.Round((double)(Module1.INS & 262080) / 64.0);
					}
					else
					{
						this.BUTTON_FII.BackColor = Color.Black;
						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.f));
						this.REG_FUNC.Text = Support.Format(Module1.D, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
						Module1.CODE = Module1.f;
					}
				}
				else
				{
					Module1.u = Module1.P & 4095;
					Module1.CODE = Module1.FUNC;
				}
				Module1.ADD_UP = (int)(unchecked((long)Module1.P) & Module1.CONST_OCT_770000);
				Module1.ADD_USR = (Module1.SR & 7) * 4096;
				Module1.INDEX = Module1.MEM[Module1.ICR];
				Module1.ADDRESS = Module1.ADD_UP + Module1.u;
				flag = Module1.SR > 7;
				if (flag)
				{
					Module1.ACTIVE = true;
					Module1.ADDRESS = Module1.ADD_USR + Module1.u;
				}
				flag = !Module1.DISCONECT_P;
				if (flag)
				{
					Module1.P++;
					Module1.D = Module1.P;
					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
					this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
				}
				flag = (Module1.CODE < 48) | (Module1.CODE > 55);
				if (flag)
				{
					Module1.DESIG_COMPARE = false;
				}
				int code = Module1.CODE;
				flag = code == 28;
				if (flag)
				{
					Module1.P = Module1.ADD_UP + Module1.u;
					this.UPDATE_P();
				}
				else
				{
					flag = code == 2577;
					if (flag)
					{
						Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
						flag = !Module1.IN_ACTIVE[Module1.k];
						if (flag)
						{
							Module1.P++;
							this.UPDATE_P();
						}
					}
					else
					{
						flag = code == 2578;
						if (flag)
						{
							Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
							flag = !Module1.OUT_ACTIVE[Module1.k];
							if (flag)
							{
								Module1.P++;
								this.UPDATE_P();
							}
						}
						else
						{
							flag = code == 2579;
							if (flag)
							{
								Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
								flag = !Module1.EXF_ACTIVE[Module1.k];
								if (flag)
								{
									Module1.P++;
									this.UPDATE_P();
								}
							}
							else
							{
								flag = code == 49;
								if (flag)
								{
									bool flag2 = Module1.DESIG_COMPARE & Module1.DESIG_EQUAL;
									if (flag2)
									{
										Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
										this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
									}
									flag2 = !Module1.DESIG_COMPARE & (Module1.AL == 0);
									if (flag2)
									{
										Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
										this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
									}
								}
								else
								{
									bool flag2 = code == 10;
									if (flag2)
									{
										Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.MEM[Module1.ADDRESS]));
										this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
									}
									else
									{
										flag2 = code == 11;
										if (flag2)
										{
											Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.MEM[Module1.ADDRESS + Module1.INDEX]));
											this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
										}
										else
										{
											flag2 = code == 36;
											if (flag2)
											{
												Module1.MEM[Module1.ADDRESS] = Module1.AL;
											}
											else
											{
												flag2 = code == 37;
												if (flag2)
												{
													Module1.MEM[Module1.ADDRESS + Module1.INDEX] = Module1.AL;
												}
												else
												{
													flag2 = code == 45;
													if (flag2)
													{
														Module1.P = Module1.MEM[Module1.ADD_UP + Module1.u];
														Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
														this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
													}
													else
													{
														flag2 = code == 56;
														if (flag2)
														{
															Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.SEXT));
															this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
														}
														else
														{
															flag2 = code == 57;
															if (flag2)
															{
																unchecked
																{
																	Module1.REG_D = (long)Module1.AL;
																	Module1.REG_X = (long)Module1.SEXT;
																	this.ADDER();
																	Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.XplusD));
																	this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																}
															}
															else
															{
																flag2 = code == 39;
																if (flag2)
																{
																	Module1.MEM[Module1.ADDRESS + Module1.INDEX] = Module1.AU;
																}
																else
																{
																	flag2 = code == 41;
																	if (flag2)
																	{
																		Module1.AL |= Module1.MEM[Module1.ADD_UP + Module1.u];
																		Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																		this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																	}
																	else
																	{
																		flag2 = code == 2;
																		if (flag2)
																		{
																			Module1.DESIG_COMPARE = true;
																			Module1.DESIG_EQUAL = false;
																			Module1.DESIG_LT = false;
																			flag2 = Module1.AL == Module1.MEM[Module1.ADDRESS];
																			if (flag2)
																			{
																				Module1.DESIG_EQUAL = true;
																			}
																			flag2 = Module1.AL < Module1.MEM[Module1.ADDRESS];
																			if (flag2)
																			{
																				Module1.DESIG_LT = true;
																			}
																		}
																		else
																		{
																			flag2 = code == 3;
																			if (flag2)
																			{
																				Module1.DESIG_COMPARE = true;
																				Module1.DESIG_EQUAL = false;
																				Module1.DESIG_LT = false;
																				flag2 = Module1.AL == Module1.MEM[Module1.ADDRESS + Module1.INDEX];
																				if (flag2)
																				{
																					Module1.DESIG_EQUAL = true;
																				}
																				flag2 = Module1.AL < Module1.MEM[Module1.ADDRESS + Module1.INDEX];
																				if (flag2)
																				{
																					Module1.DESIG_LT = true;
																				}
																			}
																			else
																			{
																				flag2 = code == 4;
																				if (flag2)
																				{
																					Module1.MASK = ~Module1.AU;
																					Module1.MASK = (int)(unchecked((long)Module1.MASK) & Conversions.ToLong("&O777777"));
																					Module1.AL &= Module1.MASK;
																					Module1.D = Module1.MEM[Module1.ADDRESS] & Module1.AU;
																					Module1.D = Module1.AL + Module1.D;
																					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																					this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																				}
																				else
																				{
																					flag2 = code == 5;
																					if (flag2)
																					{
																						Module1.MASK = ~Module1.AU;
																						Module1.MASK = (int)(unchecked((long)Module1.MASK) & Conversions.ToLong("&O777777"));
																						Module1.AL &= Module1.MASK;
																						Module1.D = Module1.MEM[Module1.ADDRESS + Module1.INDEX] & Module1.AU;
																						Module1.D = Module1.AL + Module1.D;
																						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																						this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																					}
																					else
																					{
																						flag2 = code == 6;
																						if (flag2)
																						{
																							Module1.DESIG_COMPARE = true;
																							Module1.DESIG_EQUAL = false;
																							Module1.DESIG_LT = false;
																							Module1.D = Module1.AL & Module1.AU;
																							Module1.X = Module1.MEM[Module1.ADDRESS] & Module1.AU;
																							flag2 = Module1.X == Module1.D;
																							if (flag2)
																							{
																								Module1.DESIG_EQUAL = true;
																							}
																							flag2 = Module1.X < Module1.D;
																							if (flag2)
																							{
																								Module1.DESIG_LT = true;
																							}
																						}
																						else
																						{
																							flag2 = code == 7;
																							if (flag2)
																							{
																								Module1.DESIG_COMPARE = true;
																								Module1.DESIG_EQUAL = false;
																								Module1.DESIG_LT = false;
																								Module1.D = Module1.AL & Module1.AU;
																								Module1.X = Module1.MEM[Module1.ADDRESS + Module1.INDEX] & Module1.AU;
																								flag2 = Module1.X == Module1.D;
																								if (flag2)
																								{
																									Module1.DESIG_EQUAL = true;
																								}
																								flag2 = Module1.X < Module1.D;
																								if (flag2)
																								{
																									Module1.DESIG_LT = true;
																								}
																							}
																							else
																							{
																								flag2 = code == 8;
																								if (flag2)
																								{
																									Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.MEM[Module1.ADDRESS]));
																									this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																								}
																								else
																								{
																									flag2 = code == 9;
																									if (flag2)
																									{
																										Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.MEM[Module1.ADDRESS + Module1.INDEX]));
																										this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																									}
																									else
																									{
																										flag2 = code == 12;
																										if (flag2)
																										{
																											unchecked
																											{
																												Module1.REG_X = (long)Module1.AL;
																												Module1.REG_D = (long)Module1.MEM[Module1.ADDRESS];
																												this.ADDER();
																											}
																											Module1.D = (int)Module1.XplusD;
																											Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																											this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																										}
																										else
																										{
																											flag2 = code == 13;
																											if (flag2)
																											{
																												unchecked
																												{
																													Module1.REG_X = (long)Module1.AL;
																													Module1.REG_D = (long)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX)];
																													this.ADDER();
																												}
																												Module1.D = (int)Module1.XplusD;
																												Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																												this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																											}
																											else
																											{
																												flag2 = code == 14;
																												if (flag2)
																												{
																													unchecked
																													{
																														Module1.REG_X = (long)Module1.AL;
																														Module1.REG_D = (long)Module1.MEM[Module1.ADDRESS];
																														Module1.REG_D = ~Module1.REG_D;
																														Module1.REG_D &= Conversions.ToLong("&O777777");
																														this.ADDER();
																													}
																													Module1.D = (int)Module1.XplusD;
																													Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																													this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																												}
																												else
																												{
																													flag2 = code == 15;
																													if (flag2)
																													{
																														unchecked
																														{
																															Module1.REG_X = (long)Module1.AL;
																															Module1.REG_D = (long)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX)];
																															Module1.REG_D = ~Module1.REG_D;
																															Module1.REG_D &= Conversions.ToLong("&O777777");
																															this.ADDER();
																														}
																														Module1.D = (int)Module1.XplusD;
																														Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																														this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																													}
																													else
																													{
																														flag2 = code == 16;
																														if (flag2)
																														{
																															Module1.REG_X = (long)Math.Round(unchecked((double)Module1.AU * Conversions.ToDouble("&O1000000") + (double)Module1.AL));
																															Module1.REG_D = (long)Math.Round(unchecked((double)Module1.MEM[checked(Module1.ADDRESS + 1)] * Conversions.ToDouble("&O1000000") + (double)Module1.MEM[Module1.ADDRESS]));
																															Module1.XplusD = Module1.REG_X + Module1.REG_D;
																															Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.XplusD / Conversions.ToDouble("&O1000000")));
																															Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																															this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																															Module1.AL = (int)(Module1.XplusD & Conversions.ToLong("&O777777"));
																															Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																															this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																														}
																														else
																														{
																															flag2 = code == 17;
																															if (flag2)
																															{
																																Module1.REG_X = (long)Math.Round(unchecked((double)Module1.AU * Conversions.ToDouble("&O1000000") + (double)Module1.AL));
																																Module1.REG_D = (long)Math.Round(unchecked((double)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX + 1)] * Conversions.ToDouble("&O1000000") + (double)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX)]));
																																Module1.XplusD = Module1.REG_X + Module1.REG_D;
																																Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.XplusD / Conversions.ToDouble("&O1000000")));
																																Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																Module1.AL = (int)(Module1.XplusD & Conversions.ToLong("&O777777"));
																																Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																															}
																															else
																															{
																																flag2 = code == 18;
																																if (flag2)
																																{
																																	Module1.REG_X = (long)Math.Round(unchecked((double)Module1.AU * Conversions.ToDouble("&O1000000") + (double)Module1.AL));
																																	Module1.REG_D = (long)Math.Round(unchecked((double)Module1.MEM[checked(Module1.ADDRESS + 1)] * Conversions.ToDouble("&O1000000") + (double)Module1.MEM[Module1.ADDRESS]));
																																	Module1.REG_D = ~Module1.REG_D;
																																	Module1.REG_D &= Conversions.ToLong("&O777777777777");
																																	Module1.XplusD = Module1.REG_X + Module1.REG_D;
																																	Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.XplusD / Conversions.ToDouble("&O1000000")));
																																	Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																	this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																	Module1.AL = (int)(Module1.XplusD & Conversions.ToLong("&O777777"));
																																	Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																	this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																}
																																else
																																{
																																	flag2 = code == 19;
																																	if (flag2)
																																	{
																																		Module1.REG_X = (long)Math.Round(unchecked((double)Module1.AU * Conversions.ToDouble("&O1000000") + (double)Module1.AL));
																																		Module1.REG_D = (long)Math.Round(unchecked((double)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX + 1)] * Conversions.ToDouble("&O1000000") + (double)Module1.MEM[checked(Module1.ADDRESS + Module1.INDEX)]));
																																		Module1.REG_D = ~Module1.REG_D;
																																		Module1.REG_D &= Conversions.ToLong("&O777777777777");
																																		Module1.XplusD = Module1.REG_X + Module1.REG_D;
																																		Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.XplusD / Conversions.ToDouble("&O1000000")));
																																		Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																		this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																		Module1.AL = (int)(Module1.XplusD & Conversions.ToLong("&O777777"));
																																		Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																		this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																	}
																																	else
																																	{
																																		flag2 = code == 20;
																																		if (flag2)
																																		{
																																			flag = Module1.AL > 131071;
																																			if (flag)
																																			{
																																				Module1.AL_NEG = true;
																																				Module1.AL = (int)(unchecked((long)(~(long)Module1.AL)) & Conversions.ToLong("&O777777"));
																																			}
																																			else
																																			{
																																				Module1.AL_NEG = false;
																																			}
																																			Module1.D = Module1.MEM[Module1.ADDRESS];
																																			flag2 = Module1.D > 131071;
																																			if (flag2)
																																			{
																																				Module1.MEM_NEG = true;
																																				Module1.D = (int)(unchecked((long)(~(long)Module1.D)) & Conversions.ToLong("&O777777"));
																																			}
																																			else
																																			{
																																				Module1.MEM_NEG = false;
																																			}
																																			unchecked
																																			{
																																				Module1.A = (long)(checked(Module1.AL * Module1.D));
																																				flag2 = Module1.AL_NEG;
																																				if (flag2)
																																				{
																																					Module1.A = ~Module1.A;
																																				}
																																				flag2 = Module1.MEM_NEG;
																																				if (flag2)
																																				{
																																					Module1.A = ~Module1.A;
																																				}
																																				Module1.A &= Conversions.ToLong("&O777777777777");
																																			}
																																			Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.A / Conversions.ToDouble("&O1000000")));
																																			Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																			this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																			Module1.AL = (int)(Module1.A & Conversions.ToLong("&O777777"));
																																			Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																			this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																		}
																																		else
																																		{
																																			flag2 = code == 21;
																																			if (flag2)
																																			{
																																				flag = Module1.AL > 131071;
																																				if (flag)
																																				{
																																					Module1.AL_NEG = true;
																																					Module1.AL = (int)(unchecked((long)(~(long)Module1.AL)) & Conversions.ToLong("&O777777"));
																																				}
																																				else
																																				{
																																					Module1.AL_NEG = false;
																																				}
																																				Module1.D = Module1.MEM[Module1.ADDRESS + Module1.INDEX];
																																				flag2 = Module1.D > 131071;
																																				if (flag2)
																																				{
																																					Module1.MEM_NEG = true;
																																					Module1.D = (int)(unchecked((long)(~(long)Module1.D)) & Conversions.ToLong("&O777777"));
																																				}
																																				else
																																				{
																																					Module1.MEM_NEG = false;
																																				}
																																				unchecked
																																				{
																																					Module1.A = (long)(checked(Module1.AL * Module1.D));
																																					flag2 = Module1.AL_NEG;
																																					if (flag2)
																																					{
																																						Module1.A = ~Module1.A;
																																					}
																																					flag2 = Module1.MEM_NEG;
																																					if (flag2)
																																					{
																																						Module1.A = ~Module1.A;
																																					}
																																					Module1.A &= Conversions.ToLong("&O777777777777");
																																				}
																																				Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.A / Conversions.ToDouble("&O1000000")));
																																				Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																				this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																				Module1.AL = (int)(Module1.A & Conversions.ToLong("&O777777"));
																																				Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																				this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																			}
																																			else
																																			{
																																				flag2 = code == 22;
																																				if (flag2)
																																				{
																																					unchecked
																																					{
																																						Module1.A = (long)Module1.AU;
																																						Module1.A = (long)(checked((Module1.AU << 18) + Module1.AL));
																																						Interaction.MsgBox(Module1.A, MsgBoxStyle.OkOnly, null);
																																					}
																																					Module1.AL = (int)Math.Round((double)Module1.A / (double)Module1.MEM[Module1.ADDRESS]);
																																					Module1.AU = (int)(Module1.A - unchecked((long)(checked(Module1.AL * Module1.MEM[Module1.ADDRESS]))));
																																					Module1.AU = (int)(unchecked((long)Module1.AU) & Conversions.ToLong("&O777777"));
																																					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																					this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																					this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																				}
																																				else
																																				{
																																					flag2 = code == 22;
																																					if (flag2)
																																					{
																																						unchecked
																																						{
																																							Module1.A = (long)Module1.AU;
																																							Module1.A = (long)(checked((Module1.AU << 18) + Module1.AL));
																																							Interaction.MsgBox(Module1.A, MsgBoxStyle.OkOnly, null);
																																						}
																																						Module1.AL = (int)Math.Round((double)Module1.A / (double)Module1.MEM[Module1.ADDRESS + Module1.INDEX]);
																																						Module1.AU = (int)(Module1.A - unchecked((long)(checked(Module1.AL * Module1.MEM[Module1.ADDRESS + Module1.INDEX]))));
																																						Module1.AU = (int)(unchecked((long)Module1.AU) & Conversions.ToLong("&O777777"));
																																						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																						this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																						this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																					}
																																					else
																																					{
																																						flag2 = code == 24;
																																						if (flag2)
																																						{
																																							Module1.D = Module1.MEM[Module1.ADD_UP + Module1.u];
																																							Module1.MEM[Module1.D] = Module1.P;
																																							Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D + 1));
																																							this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																						}
																																						else
																																						{
																																							flag2 = code == 25;
																																							if (flag2)
																																							{
																																								Module1.D = Module1.MEM[Module1.ADD_UP + Module1.u + Module1.INDEX];
																																								Module1.MEM[Module1.D] = Module1.P;
																																								Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D + 1));
																																								this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																							}
																																							else
																																							{
																																								flag2 = code == 26;
																																								if (flag2)
																																								{
																																									Module1.MEM[Module1.ICR] = Module1.MEM[Module1.ADDRESS];
																																								}
																																								else
																																								{
																																									flag2 = code == 27;
																																									if (flag2)
																																									{
																																										Module1.MEM[Module1.ICR] = Module1.MEM[Module1.ADDRESS + Module1.INDEX];
																																									}
																																									else
																																									{
																																										flag2 = code == 29;
																																										if (flag2)
																																										{
																																											Module1.P = Module1.ADD_UP + Module1.u + Module1.INDEX;
																																											Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																											this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																										}
																																										else
																																										{
																																											flag2 = code == 30;
																																											if (flag2)
																																											{
																																												Module1.MEM[Module1.ICR] = Module1.SEXT;
																																											}
																																											else
																																											{
																																												flag2 = code == 31;
																																												if (flag2)
																																												{
																																													unchecked
																																													{
																																														Module1.REG_D = (long)Module1.MEM[Module1.ICR];
																																														Module1.REG_X = (long)Module1.SEXT;
																																														this.ADDER();
																																													}
																																													Module1.MEM[Module1.ICR] = (int)Module1.XplusD;
																																												}
																																												else
																																												{
																																													flag2 = code == 32;
																																													if (flag2)
																																													{
																																														Module1.MEM[Module1.ADDRESS] = 0;
																																													}
																																													else
																																													{
																																														flag2 = code == 33;
																																														if (flag2)
																																														{
																																															Module1.MEM[Module1.ADDRESS + Module1.INDEX] = 0;
																																														}
																																														else
																																														{
																																															flag2 = code == 34;
																																															if (flag2)
																																															{
																																																Module1.MEM[Module1.ADDRESS] = Module1.INDEX;
																																															}
																																															else
																																															{
																																																flag2 = code == 35;
																																																if (flag2)
																																																{
																																																	Module1.MEM[Module1.ADDRESS + Module1.INDEX] = Module1.INDEX;
																																																}
																																																else
																																																{
																																																	flag2 = code == 38;
																																																	if (flag2)
																																																	{
																																																		Module1.MEM[Module1.ADDRESS] = Module1.AU;
																																																	}
																																																	else
																																																	{
																																																		flag2 = code == 42;
																																																		if (flag2)
																																																		{
																																																			Module1.AL &= Module1.MEM[Module1.ADD_UP + Module1.u];
																																																			Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																																			this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																		}
																																																		else
																																																		{
																																																			flag2 = code == 43;
																																																			if (flag2)
																																																			{
																																																				Module1.AL ^= Module1.MEM[Module1.ADD_UP + Module1.u];
																																																				Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																																				this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																			}
																																																			else
																																																			{
																																																				flag2 = code == 46;
																																																				if (flag2)
																																																				{
																																																					flag = Module1.MEM[Module1.ICR] == Module1.MEM[Module1.ADD_UP + Module1.u];
																																																					if (flag)
																																																					{
																																																						Module1.P++;
																																																						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																						this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																					}
																																																					else
																																																					{
																																																						Module1.MEM[Module1.ICR] = Module1.MEM[Module1.ICR] + 1;
																																																					}
																																																				}
																																																				else
																																																				{
																																																					flag2 = code == 47;
																																																					if (flag2)
																																																					{
																																																						flag = Module1.MEM[Module1.ADD_UP + Module1.u] == 0;
																																																						if (flag)
																																																						{
																																																							Module1.P++;
																																																							Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																							this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																						}
																																																						else
																																																						{
																																																							Module1.MEM[Module1.ADD_UP + Module1.u] = Module1.MEM[Module1.ADD_UP + Module1.u] - 1;
																																																						}
																																																					}
																																																					else
																																																					{
																																																						flag2 = code == 48;
																																																						unchecked
																																																						{
																																																							if (flag2)
																																																							{
																																																								flag = Module1.DESIG_COMPARE & Module1.DESIG_EQUAL;
																																																								if (flag)
																																																								{
																																																									Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																									this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																								}
																																																								flag2 = !Module1.DESIG_COMPARE & (Module1.AU == 0);
																																																								if (flag2)
																																																								{
																																																									Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																									this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																								}
																																																							}
																																																							else
																																																							{
																																																								flag2 = code == 49;
																																																								if (flag2)
																																																								{
																																																									flag = Module1.DESIG_COMPARE & Module1.DESIG_EQUAL;
																																																									if (flag)
																																																									{
																																																										Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																										this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																									}
																																																									flag2 = !Module1.DESIG_COMPARE & (Module1.AL == 0);
																																																									if (flag2)
																																																									{
																																																										Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																										this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																									}
																																																								}
																																																								else
																																																								{
																																																									flag2 = code == 50;
																																																									if (flag2)
																																																									{
																																																										flag = Module1.DESIG_COMPARE & !Module1.DESIG_EQUAL;
																																																										if (flag)
																																																										{
																																																											Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																											this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																										}
																																																										flag2 = !Module1.DESIG_COMPARE & (Module1.AU != 0);
																																																										if (flag2)
																																																										{
																																																											Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																											this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																										}
																																																									}
																																																									else
																																																									{
																																																										flag2 = code == 51;
																																																										if (flag2)
																																																										{
																																																											flag = Module1.DESIG_COMPARE & !Module1.DESIG_EQUAL;
																																																											if (flag)
																																																											{
																																																												Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																												this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																											}
																																																											flag2 = !Module1.DESIG_COMPARE & (Module1.AL != 0);
																																																											if (flag2)
																																																											{
																																																												Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																												this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																											}
																																																										}
																																																										else
																																																										{
																																																											flag2 = code == 52;
																																																											if (flag2)
																																																											{
																																																												flag = Module1.DESIG_COMPARE & !Module1.DESIG_LT;
																																																												if (flag)
																																																												{
																																																													Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																													this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																												}
																																																												flag2 = ((long)Module1.AU & Conversions.ToLong("&O400000")) == 0L;
																																																												if (flag2)
																																																												{
																																																													Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																													this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																												}
																																																											}
																																																											else
																																																											{
																																																												flag2 = code == 53;
																																																												if (flag2)
																																																												{
																																																													flag = Module1.DESIG_COMPARE & !Module1.DESIG_LT;
																																																													if (flag)
																																																													{
																																																														Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																														this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																													}
																																																													else
																																																													{
																																																														flag2 = ((long)Module1.AL & Conversions.ToLong("&O400000")) == 0L;
																																																														if (flag2)
																																																														{
																																																															Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																															this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																														}
																																																													}
																																																												}
																																																												else
																																																												{
																																																													flag2 = code == 54;
																																																													if (flag2)
																																																													{
																																																														flag = Module1.DESIG_COMPARE & Module1.DESIG_LT;
																																																														if (flag)
																																																														{
																																																															Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																															this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																														}
																																																														flag2 = ((long)Module1.AU & Conversions.ToLong("&O400000")) != 0L;
																																																														if (flag2)
																																																														{
																																																															Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																															this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																														}
																																																													}
																																																													else
																																																													{
																																																														flag2 = code == 55;
																																																														if (flag2)
																																																														{
																																																															flag = Module1.DESIG_COMPARE & Module1.DESIG_LT;
																																																															if (flag)
																																																															{
																																																																Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																																this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																															}
																																																															else
																																																															{
																																																																flag2 = ((long)Module1.AL & Conversions.ToLong("&O400000")) != 0L;
																																																																if (flag2)
																																																																{
																																																																	Module1.P = Conversions.ToInteger(Conversion.Oct(Module1.ADDRESS));
																																																																	this.REG_PROG.Text = Support.Format(Module1.P, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																}
																																																															}
																																																														}
																																																														else
																																																														{
																																																															flag2 = code == 58;
																																																															checked
																																																															{
																																																																if (flag2)
																																																																{
																																																																	Module1.MEM[Module1.ADD_UP + Module1.u] = (int)((unchecked((long)Module1.MEM[checked(Module1.ADD_UP + Module1.u)]) & Conversions.ToLong("&O777700")) + unchecked((long)Module1.ICR));
																																																																}
																																																																else
																																																																{
																																																																	flag2 = code == 59;
																																																																	if (flag2)
																																																																	{
																																																																		flag = Module1.MEM[Module1.ICR] != 0;
																																																																		if (flag)
																																																																		{
																																																																			Interaction.MsgBox(Module1.MEM[Module1.INDEX], MsgBoxStyle.OkOnly, null);
																																																																			Module1.MEM[Module1.ICR] = Module1.MEM[Module1.ICR] - 1;
																																																																			Module1.P = Module1.ADD_UP + Module1.u;
																																																																			Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																			this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																		}
																																																																	}
																																																																	else
																																																																	{
																																																																		flag2 = code == 60;
																																																																		if (flag2)
																																																																		{
																																																																			Module1.MEM[Module1.ADD_UP + Module1.u] = (int)((unchecked((long)Module1.MEM[checked(Module1.ADD_UP + Module1.u)]) & Module1.CONST_OCT_770000) + unchecked((long)(Module1.AL & 4095)));
																																																																		}
																																																																		else
																																																																		{
																																																																			flag2 = code == 61;
																																																																			if (flag2)
																																																																			{
																																																																				Module1.MEM[Module1.ADD_UP + Module1.u] = (int)((unchecked((long)Module1.MEM[checked(Module1.ADD_UP + Module1.u)]) & Conversions.ToLong("&O777700")) + unchecked((long)Module1.SR));
																																																																			}
																																																																			else
																																																																			{
																																																																				flag2 = code == 62;
																																																																				if (flag2)
																																																																				{
																																																																					Module1.MEM[Module1.ADD_UP + Module1.u] = Module1.P;
																																																																					Module1.P = Module1.ADD_UP + Module1.u + 1;
																																																																					Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																					this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																				}
																																																																				else
																																																																				{
																																																																					flag2 = code == 2561;
																																																																					if (flag2)
																																																																					{
																																																																						Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																						Module1.IN_ACTIVE[Module1.k] = true;
																																																																					}
																																																																					else
																																																																					{
																																																																						flag2 = code == 2562;
																																																																						if (flag2)
																																																																						{
																																																																							Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																							Module1.OUT_ACTIVE[Module1.k] = true;
																																																																						}
																																																																						else
																																																																						{
																																																																							flag2 = code == 2563;
																																																																							if (flag2)
																																																																							{
																																																																								Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																								Module1.EXF_ACTIVE[Module1.k] = true;
																																																																							}
																																																																							else
																																																																							{
																																																																								flag2 = code == 2569;
																																																																								if (flag2)
																																																																								{
																																																																									Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																									flag2 = Module1.k > 7;
																																																																									if (flag2)
																																																																									{
																																																																										Module1.D = Conversions.ToInteger("&O200");
																																																																									}
																																																																									else
																																																																									{
																																																																										Module1.D = 0;
																																																																									}
																																																																									Module1.CMEM_LOK = Module1.D + 48 + Module1.k * 2;
																																																																									Module1.MEM[Module1.CMEM_LOK] = Module1.MEM[Module1.P];
																																																																									Module1.MEM[Module1.CMEM_LOK + 1] = Module1.MEM[Module1.P + 1];
																																																																									Module1.IN_ACTIVE[Module1.k] = true;
																																																																									Module1.P += 2;
																																																																									Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																									this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																								}
																																																																								else
																																																																								{
																																																																									flag2 = code == 2570;
																																																																									if (flag2)
																																																																									{
																																																																										Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																										flag2 = Module1.k > 7;
																																																																										if (flag2)
																																																																										{
																																																																											Module1.D = Conversions.ToInteger("&O200");
																																																																										}
																																																																										else
																																																																										{
																																																																											Module1.D = 0;
																																																																										}
																																																																										Module1.CMEM_LOK = Module1.D + 32 + Module1.k * 2;
																																																																										Module1.MEM[Module1.CMEM_LOK] = Module1.MEM[Module1.P];
																																																																										Module1.MEM[Module1.CMEM_LOK + 1] = Module1.MEM[Module1.P + 1];
																																																																										Module1.OUT_ACTIVE[Module1.k] = true;
																																																																										Module1.P += 2;
																																																																										Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																										this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																									}
																																																																									else
																																																																									{
																																																																										flag2 = code == 2571;
																																																																										if (flag2)
																																																																										{
																																																																											Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																											flag2 = Module1.k > 7;
																																																																											if (flag2)
																																																																											{
																																																																												Module1.D = Conversions.ToInteger("&O200");
																																																																											}
																																																																											else
																																																																											{
																																																																												Module1.D = 0;
																																																																											}
																																																																											Module1.CMEM_LOK = Module1.D + 16 + Module1.k * 2;
																																																																											Module1.MEM[Module1.CMEM_LOK] = Module1.MEM[Module1.P];
																																																																											Module1.MEM[Module1.CMEM_LOK + 1] = Module1.MEM[Module1.P + 1];
																																																																											Module1.EXF_ACTIVE[Module1.k] = true;
																																																																											Module1.P += 2;
																																																																											Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																											this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																										}
																																																																										else
																																																																										{
																																																																											flag2 = code == 2573;
																																																																											if (flag2)
																																																																											{
																																																																												Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																												Module1.IN_ACTIVE[Module1.k] = false;
																																																																											}
																																																																											else
																																																																											{
																																																																												flag2 = code == 2574;
																																																																												if (flag2)
																																																																												{
																																																																													Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																													Module1.OUT_ACTIVE[Module1.k] = false;
																																																																												}
																																																																												else
																																																																												{
																																																																													flag2 = code == 2575;
																																																																													if (flag2)
																																																																													{
																																																																														Module1.k = (int)(unchecked((long)Module1.k) & Module1.CONST_OCT_17);
																																																																														Module1.EXF_ACTIVE[Module1.k] = false;
																																																																													}
																																																																													else
																																																																													{
																																																																														flag2 = code == 2593;
																																																																														if (flag2)
																																																																														{
																																																																															Module1.D = (int)Math.Round(Conversion.Int((double)Module1.AU / Math.Pow(2.0, (double)Module1.k)));
																																																																															Module1.N = Module1.AU & 131072;
																																																																															flag2 = Module1.N != 0;
																																																																															if (flag2)
																																																																															{
																																																																																Module1.MASK = (int)Math.Round(unchecked((Math.Pow(2.0, (double)Module1.k) - 1.0) * Math.Pow(2.0, (double)(checked(18 - Module1.k)))));
																																																																																Module1.D |= Module1.MASK;
																																																																															}
																																																																															Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																																																																															this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																														}
																																																																														else
																																																																														{
																																																																															flag2 = code == 2594;
																																																																															if (flag2)
																																																																															{
																																																																																Module1.D = (int)Math.Round(Conversion.Int((double)Module1.AL / Math.Pow(2.0, (double)Module1.k)));
																																																																																Module1.N = Module1.AL & 131072;
																																																																																flag2 = Module1.N != 0;
																																																																																if (flag2)
																																																																																{
																																																																																	Module1.MASK = (int)Math.Round(unchecked((Math.Pow(2.0, (double)Module1.k) - 1.0) * Math.Pow(2.0, (double)(checked(18 - Module1.k)))));
																																																																																	Module1.D |= Module1.MASK;
																																																																																}
																																																																																Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																																																																																this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																															}
																																																																															else
																																																																															{
																																																																																flag2 = code == 2595;
																																																																																if (flag2)
																																																																																{
																																																																																	Module1.A = (long)Math.Round(unchecked((double)Module1.AU * Conversions.ToDouble("&O1000000") + (double)Module1.AL));
																																																																																	int num = 0;
																																																																																	int num2 = Module1.k - 1;
																																																																																	Module1.COUNT = num;
																																																																																	for (;;)
																																																																																	{
																																																																																		int count = Module1.COUNT;
																																																																																		int num3 = num2;
																																																																																		if (count > num3)
																																																																																		{
																																																																																			break;
																																																																																		}
																																																																																		Module1.ANEGATIVE = (Module1.A & Conversions.ToLong("&O400000000000")) != 0L;
																																																																																		Module1.A >>= 1;
																																																																																		flag2 = Module1.ANEGATIVE;
																																																																																		if (flag2)
																																																																																		{
																																																																																			Module1.A |= Conversions.ToLong("&O400000000000");
																																																																																		}
																																																																																		Module1.COUNT++;
																																																																																	}
																																																																																	Module1.AU = (int)Math.Round(Conversion.Int((double)Module1.A / Conversions.ToDouble("&O1000000")));
																																																																																	Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																																																																	this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																	Module1.AL = (int)(Module1.A & Conversions.ToLong("&O777777"));
																																																																																	Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																																																																	this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																}
																																																																																else
																																																																																{
																																																																																	flag2 = code == 2597;
																																																																																	if (flag2)
																																																																																	{
																																																																																		Module1.PART = (int)Math.Round(Conversion.Int((double)Module1.AU / Math.Pow(2.0, (double)(18 - Module1.k))));
																																																																																		Module1.MASK = (int)Math.Round(unchecked(Math.Pow(2.0, (double)(checked(18 - Module1.k))) - 1.0));
																																																																																		Module1.D = (int)Math.Round(unchecked((double)(Module1.AU & Module1.MASK) * Math.Pow(2.0, (double)Module1.k) + (double)Module1.PART));
																																																																																		Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																																																																																		this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																	}
																																																																																	else
																																																																																	{
																																																																																		flag2 = code == 2598;
																																																																																		if (flag2)
																																																																																		{
																																																																																			int num4 = 0;
																																																																																			int num5 = Module1.k - 1;
																																																																																			Module1.COUNT = num4;
																																																																																			for (;;)
																																																																																			{
																																																																																				int count2 = Module1.COUNT;
																																																																																				int num3 = num5;
																																																																																				if (count2 > num3)
																																																																																				{
																																																																																					break;
																																																																																				}
																																																																																				Module1.N = Module1.AL & 131072;
																																																																																				Module1.AL <<= 1;
																																																																																				flag2 = Module1.AL > 262143;
																																																																																				if (flag2)
																																																																																				{
																																																																																					Module1.AL -= 262144;
																																																																																				}
																																																																																				flag2 = Module1.N != 0;
																																																																																				if (flag2)
																																																																																				{
																																																																																					Module1.AL++;
																																																																																				}
																																																																																				Module1.COUNT++;
																																																																																			}
																																																																																			Module1.DSTRING = Convert.ToString(Module1.AL, 8);
																																																																																			this.REG_AL.Text = Support.Format(Module1.DSTRING, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																		}
																																																																																		else
																																																																																		{
																																																																																			flag2 = code == 2599;
																																																																																			if (flag2)
																																																																																			{
																																																																																				flag = Module1.k > 17;
																																																																																				if (flag)
																																																																																				{
																																																																																					Module1.k -= 18;
																																																																																					Module1.D = Module1.AU;
																																																																																					Module1.AU = Module1.AL;
																																																																																					Module1.AL = Module1.D;
																																																																																				}
																																																																																				Module1.MASK = (int)Math.Round(unchecked(Math.Pow(2.0, (double)(checked(18 - Module1.k))) - 1.0));
																																																																																				Module1.PART = (int)Math.Round(Conversion.Int((double)Module1.AU / Math.Pow(2.0, (double)(18 - Module1.k))));
																																																																																				Module1.PART2 = (int)Math.Round(Conversion.Int((double)Module1.AL / Math.Pow(2.0, (double)(18 - Module1.k))));
																																																																																				Module1.D = (int)Math.Round(unchecked((double)(Module1.AU & Module1.MASK) * Math.Pow(2.0, (double)Module1.k) + (double)Module1.PART2));
																																																																																				Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																																																																																				this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																				Module1.D = (int)Math.Round(unchecked((double)(Module1.AL & Module1.MASK) * Math.Pow(2.0, (double)Module1.k) + (double)Module1.PART));
																																																																																				Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.D));
																																																																																				this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																			}
																																																																																			else
																																																																																			{
																																																																																				flag2 = code == 2600;
																																																																																				if (flag2)
																																																																																				{
																																																																																					Module1.D = 0;
																																																																																					flag2 = this.SKIP0.BackColor == Color.LightGreen;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.D++;
																																																																																					}
																																																																																					flag2 = this.SKIP1.BackColor == Color.LightGreen;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.D += 2;
																																																																																					}
																																																																																					flag2 = this.SKIP2.BackColor == Color.LightGreen;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.D += 4;
																																																																																					}
																																																																																					flag2 = this.SKIP3.BackColor == Color.LightGreen;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.D += 8;
																																																																																					}
																																																																																					flag2 = this.SKIP4.BackColor == Color.LightGreen;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.D += 16;
																																																																																					}
																																																																																					flag2 = (Module1.D & unchecked(-((Module1.k != 0) ? 1 : 0))) != 0;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.P++;
																																																																																						Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.P));
																																																																																						this.REG_PROG.Text = Support.Format(Module1.D, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																					}
																																																																																				}
																																																																																				else
																																																																																				{
																																																																																					flag2 = code == 2601;
																																																																																					if (flag2)
																																																																																					{
																																																																																						Module1.P++;
																																																																																						this.UPDATE_P();
																																																																																					}
																																																																																					else
																																																																																					{
																																																																																						flag2 = code == 2602;
																																																																																						if (flag2)
																																																																																						{
																																																																																							flag = Module1.DESIG_OVERFLOW;
																																																																																							if (flag)
																																																																																							{
																																																																																								Module1.P++;
																																																																																								this.UPDATE_P();
																																																																																							}
																																																																																						}
																																																																																						else
																																																																																						{
																																																																																							flag2 = code == 2603;
																																																																																							if (flag2)
																																																																																							{
																																																																																								flag = !Module1.DESIG_OVERFLOW;
																																																																																								if (flag)
																																																																																								{
																																																																																									Module1.P++;
																																																																																									this.UPDATE_P();
																																																																																								}
																																																																																							}
																																																																																							else
																																																																																							{
																																																																																								flag2 = code == 2604;
																																																																																								if (flag2)
																																																																																								{
																																																																																									Module1.D = Module1.AL & Module1.AU;
																																																																																									Module1.ONES = 0;
																																																																																									Module1.D <<= 14;
																																																																																									Module1.X = 0;
																																																																																									int num3;
																																																																																									int x;
																																																																																									do
																																																																																									{
																																																																																										flag2 = Module1.D < 0;
																																																																																										if (flag2)
																																																																																										{
																																																																																											Module1.ONES++;
																																																																																										}
																																																																																										Module1.D <<= 1;
																																																																																										Module1.X++;
																																																																																										x = Module1.X;
																																																																																										num3 = 17;
																																																																																									}
																																																																																									while (x <= num3);
																																																																																									flag2 = Conversion.Int((double)Module1.ONES / 2.0) != (double)Module1.ONES / 2.0;
																																																																																									if (flag2)
																																																																																									{
																																																																																										Module1.P++;
																																																																																										this.UPDATE_P();
																																																																																									}
																																																																																								}
																																																																																								else
																																																																																								{
																																																																																									flag2 = code == 2605;
																																																																																									if (flag2)
																																																																																									{
																																																																																										Module1.D = Module1.AL & Module1.AU;
																																																																																										Module1.ONES = 0;
																																																																																										Module1.D <<= 14;
																																																																																										Module1.X = 0;
																																																																																										int num3;
																																																																																										int x2;
																																																																																										do
																																																																																										{
																																																																																											flag2 = Module1.D < 0;
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.ONES++;
																																																																																											}
																																																																																											Module1.D <<= 1;
																																																																																											Module1.X++;
																																																																																											x2 = Module1.X;
																																																																																											num3 = 17;
																																																																																										}
																																																																																										while (x2 <= num3);
																																																																																										flag2 = Conversion.Int((double)Module1.ONES / 2.0) == (double)Module1.ONES / 2.0;
																																																																																										if (flag2)
																																																																																										{
																																																																																											Module1.P++;
																																																																																											this.UPDATE_P();
																																																																																										}
																																																																																									}
																																																																																									else
																																																																																									{
																																																																																										flag2 = code == 2606;
																																																																																										if (flag2)
																																																																																										{
																																																																																											flag = (Module1.k & 32) != 0;
																																																																																											if (flag)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 5 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																											flag2 = (Module1.k == 1) & (this.STOP0.BackColor == Color.LightGreen);
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 0 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																											flag2 = (Module1.k == 2) & (this.STOP1.BackColor == Color.LightGreen);
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 1 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																											flag2 = (Module1.k == 4) & (this.STOP2.BackColor == Color.LightGreen);
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 2 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																											flag2 = (Module1.k == 8) & (this.STOP3.BackColor == Color.LightGreen);
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 3 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																											flag2 = (Module1.k == 16) & (this.STOP4.BackColor == Color.LightGreen);
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.RUNNING = false;
																																																																																												Interaction.MsgBox("STOP 4 ", MsgBoxStyle.OkOnly, null);
																																																																																											}
																																																																																										}
																																																																																										else
																																																																																										{
																																																																																											flag2 = code == 2609;
																																																																																											if (flag2)
																																																																																											{
																																																																																												Module1.AL = ~Module1.AL;
																																																																																												Module1.AL = (int)(unchecked((long)Module1.AL) & Conversions.ToLong("&O777777"));
																																																																																												Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																																																																												this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																											}
																																																																																											else
																																																																																											{
																																																																																												flag2 = code == 2610;
																																																																																												if (flag2)
																																																																																												{
																																																																																													Module1.AU = ~Module1.AU;
																																																																																													Module1.AU = (int)(unchecked((long)Module1.AU) & Conversions.ToLong("&O777777"));
																																																																																													Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																																																																													this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																												}
																																																																																												else
																																																																																												{
																																																																																													flag2 = code == 2611;
																																																																																													if (flag2)
																																																																																													{
																																																																																														Module1.AL = ~Module1.AL;
																																																																																														Module1.AL = (int)(unchecked((long)Module1.AL) & Conversions.ToLong("&O777777"));
																																																																																														Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AL));
																																																																																														this.REG_AL.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																														Module1.AU = ~Module1.AU;
																																																																																														Module1.AU = (int)(unchecked((long)Module1.AU) & Conversions.ToLong("&O777777"));
																																																																																														Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.AU));
																																																																																														this.REG_AU.Text = Support.Format(Module1.D, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																													}
																																																																																													else
																																																																																													{
																																																																																														flag2 = code == 2618;
																																																																																														if (flag2)
																																																																																														{
																																																																																															Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.k));
																																																																																															this.REG_ICR.Text = Support.Format(Module1.D, "0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																														}
																																																																																														else
																																																																																														{
																																																																																															flag2 = code == 2619;
																																																																																															if (flag2)
																																																																																															{
																																																																																																Module1.D = Conversions.ToInteger(Conversion.Oct(Module1.k));
																																																																																																this.REG_SR.Text = Support.Format(Module1.D, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
																																																																																															}
																																																																																															else
																																																																																															{
																																																																																																bool flag3;
																																																																																																if (code < 0 || code > 1)
																																																																																																{
																																																																																																	if (code != 63)
																																																																																																	{
																																																																																																		if (code != 2560)
																																																																																																		{
																																																																																																			if (code != 2623)
																																																																																																			{
																																																																																																				flag3 = false;
																																																																																																				goto IL_34E2;
																																																																																																			}
																																																																																																		}
																																																																																																	}
																																																																																																}
																																																																																																flag3 = true;
																																																																																																IL_34E2:
																																																																																																flag2 = flag3;
																																																																																																if (flag2)
																																																																																																{
																																																																																																	Module1.RUNNING = false;
																																																																																																	Interaction.MsgBox("PROGRAM FAULT", MsgBoxStyle.OkOnly, null);
																																																																																																}
																																																																																															}
																																																																																														}
																																																																																													}
																																																																																												}
																																																																																											}
																																																																																										}
																																																																																									}
																																																																																								}
																																																																																							}
																																																																																						}
																																																																																					}
																																																																																				}
																																																																																			}
																																																																																		}
																																																																																	}
																																																																																}
																																																																															}
																																																																														}
																																																																													}
																																																																												}
																																																																											}
																																																																										}
																																																																									}
																																																																								}
																																																																							}
																																																																						}
																																																																					}
																																																																				}
																																																																			}
																																																																		}
																																																																	}
																																																																}
																																																															}
																																																														}
																																																													}
																																																												}
																																																											}
																																																										}
																																																									}
																																																								}
																																																							}
																																																						}
																																																					}
																																																				}
																																																			}
																																																		}
																																																	}
																																																}
																																															}
																																														}
																																													}
																																												}
																																											}
																																										}
																																									}
																																								}
																																							}
																																						}
																																					}
																																				}
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Module1.KOUNT++;
				Module1.BUSY = false;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00151CD8 File Offset: 0x001500D8
		private void UPDATE_AL()
		{
			Module1.TEMP = Conversion.Oct(Module1.AL);
			this.REG_AL.Text = Support.Format(Module1.TEMP, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00151D08 File Offset: 0x00150108
		private void UPDATE_AU()
		{
			Module1.TEMP = Conversion.Oct(Module1.AU);
			this.REG_AU.Text = Support.Format(Module1.TEMP, "000000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00151D38 File Offset: 0x00150138
		private void UPDATE_P()
		{
			Module1.TEMP = Conversion.Oct(Module1.P);
			this.REG_PROG.Text = Support.Format(Module1.TEMP, "00000", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00151D68 File Offset: 0x00150168
		private void UPDATE_ICR()
		{
			Module1.TEMP = Conversion.Oct(Module1.ICR);
			this.REG_ICR.Text = Support.Format(Module1.TEMP, "0", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00151D98 File Offset: 0x00150198
		private void UPDATE_SR()
		{
			Module1.TEMP = Conversion.Oct(Module1.SR);
			this.REG_SR.Text = Support.Format(Module1.TEMP, "00", FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00151DC8 File Offset: 0x001501C8
		public void Start_Click(object eventSender, EventArgs eventArgs)
		{
			bool flag = Operators.CompareString(this.SWITCH_MODE.Text, "Run", false) == 0;
			if (flag)
			{
				Module1.RUNNING = true;
			}
			MyProject.Forms.UNIVAC1532.KSR35.Focus();
			this.EXECUTE();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00151E18 File Offset: 0x00150218
		private void SWITCH_CLEAR_Click(object eventSender, EventArgs eventArgs)
		{
			bool flag = !Module1.RUNNING;
			if (flag)
			{
				this.CLEAR();
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00151E3C File Offset: 0x0015023C
		private void SWITCH_FUNC_Click(object eventSender, EventArgs eventArgs)
		{
			bool flag = this.SWITCH_FUNC.BackColor == Color.WhiteSmoke;
			if (flag)
			{
				this.SWITCH_FUNC.BackColor = Color.Red;
				Module1.FUNCTION_REP = true;
			}
			else
			{
				this.SWITCH_FUNC.BackColor = Color.WhiteSmoke;
				Module1.FUNCTION_REP = false;
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00151E98 File Offset: 0x00150298
		private void ADDER()
		{
			Module1.SIGNS_NEG = false;
			Module1.SIGNS_POS = false;
			Module1.DESIG_OVERFLOW = false;
			bool flag = ((double)Module1.REG_X > Conversions.ToDouble("&O377777")) & ((double)Module1.REG_D > Conversions.ToDouble("&O377777"));
			if (flag)
			{
				Module1.SIGNS_NEG = true;
			}
			flag = ((double)Module1.REG_X < Conversions.ToDouble("&O400000")) & ((double)Module1.REG_D < Conversions.ToDouble("&O400000"));
			if (flag)
			{
				Module1.SIGNS_POS = true;
			}
			checked
			{
				Module1.XplusD = Module1.REG_X + Module1.REG_D;
				flag = (double)Module1.XplusD > Conversions.ToDouble("&O777777");
				if (flag)
				{
					Module1.XplusD += 1L;
				}
				Module1.XplusD &= Conversions.ToLong("&O777777");
				flag = (double)Module1.XplusD == Conversions.ToDouble("&O777777");
				if (flag)
				{
					Module1.XplusD = 0L;
				}
				flag = Module1.SIGNS_POS & ((double)Module1.XplusD > Conversions.ToDouble("&O377777"));
				if (flag)
				{
					Module1.DESIG_OVERFLOW = true;
				}
				flag = Module1.SIGNS_NEG & ((double)Module1.XplusD < Conversions.ToDouble("&O400000"));
				if (flag)
				{
					Module1.DESIG_OVERFLOW = true;
				}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00151FC8 File Offset: 0x001503C8
		private void ADDER36()
		{
			Module1.SIGNS_NEG = false;
			Module1.SIGNS_POS = false;
			Module1.DESIG_OVERFLOW = false;
			bool flag = ((double)Module1.REG_X > Conversions.ToDouble("&O3777777777")) & ((double)Module1.REG_D > Conversions.ToDouble("&O3777777777"));
			if (flag)
			{
				Module1.SIGNS_NEG = true;
			}
			flag = ((double)Module1.REG_X < Conversions.ToDouble("&O400000000000")) & ((double)Module1.REG_D < Conversions.ToDouble("&O400000000000"));
			if (flag)
			{
				Module1.SIGNS_POS = true;
			}
			checked
			{
				Module1.XplusD = Module1.REG_X + Module1.REG_D;
				flag = (double)Module1.XplusD > Conversions.ToDouble("&O777777777777");
				if (flag)
				{
					Module1.XplusD += 1L;
					Module1.DESIG_BORROW = true;
				}
				Module1.XplusD &= Conversions.ToLong("&O777777777777");
				flag = Module1.SIGNS_POS & ((double)Module1.XplusD > Conversions.ToDouble("&O377777777777"));
				if (flag)
				{
					Module1.DESIG_OVERFLOW = true;
				}
				flag = Module1.SIGNS_NEG & ((double)Module1.XplusD < Conversions.ToDouble("&O400000000000"));
				if (flag)
				{
					Module1.DESIG_OVERFLOW = true;
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x001520E0 File Offset: 0x001504E0
		private void SWITCH_MODE_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.SWITCH_MODE.Text, "Op Step", false) == 0;
			if (flag)
			{
				this.SWITCH_MODE.Text = "Run";
				Module1.RUN_MODE = true;
			}
			else
			{
				this.SWITCH_MODE.Text = "Op Step";
				Module1.RUN_MODE = false;
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00152140 File Offset: 0x00150540
		public void Stop_Click(object sender, EventArgs e)
		{
			Module1.RUNNING = false;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0015214C File Offset: 0x0015054C
		private void Timer1_Tick(object sender, EventArgs e)
		{
				this.INS_SECOND.Text = Conversions.ToString(Module1.KOUNT);
			Module1.KOUNT = 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0015217C File Offset: 0x0015057C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			Module1.LOOPS = 1;
			checked
			{
				int loops;
				int num;
				do
				{
					bool flag = Module1.RUNNING & !Module1.BUSY;
					if (flag)
					{
						this.EXECUTE();
					}
					Module1.LOOPS++;
					loops = Module1.LOOPS;
					num = 200;
			// Allow IO timer to fire every 10 instructions
			if ((loops % 10) == 0)
			{
				Application.DoEvents();
			}
				}
				while (loops <= num);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x001521C4 File Offset: 0x001505C4
		private void _Command1_0_Click(object sender, EventArgs e)
		{
			bool flag = this.STOP0.BackColor == Color.LightGray;
			if (flag)
			{
				this.STOP0.BackColor = Color.LightGreen;
			}
			else
			{
				this.STOP0.BackColor = Color.LightGray;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00152214 File Offset: 0x00150614
		private void _Command1_1_Click(object sender, EventArgs e)
		{
			bool flag = this.STOP1.BackColor == Color.LightGray;
			if (flag)
			{
				this.STOP1.BackColor = Color.LightGreen;
			}
			else
			{
				this.STOP1.BackColor = Color.LightGray;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00152264 File Offset: 0x00150664
		private void _Command1_2_Click(object sender, EventArgs e)
		{
			bool flag = this.STOP2.BackColor == Color.LightGray;
			if (flag)
			{
				this.STOP2.BackColor = Color.LightGreen;
			}
			else
			{
				this.STOP2.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x001522B4 File Offset: 0x001506B4
		private void _Command1_3_Click(object sender, EventArgs e)
		{
			bool flag = this.STOP3.BackColor == Color.LightGray;
			if (flag)
			{
				this.STOP3.BackColor = Color.LightGreen;
			}
			else
			{
				this.STOP3.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00152304 File Offset: 0x00150704
		private void STOP4_Click(object sender, EventArgs e)
		{
			bool flag = this.STOP4.BackColor == Color.LightGray;
			if (flag)
			{
				this.STOP4.BackColor = Color.LightGreen;
			}
			else
			{
				this.STOP4.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00152354 File Offset: 0x00150754
		private void _Command2_0_Click(object sender, EventArgs e)
		{
			bool flag = this.SKIP0.BackColor == Color.LightGray;
			if (flag)
			{
				this.SKIP0.BackColor = Color.LightGreen;
			}
			else
			{
				this.SKIP0.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x001523A4 File Offset: 0x001507A4
		private void SKIP1_Click(object sender, EventArgs e)
		{
			bool flag = this.SKIP1.BackColor == Color.LightGray;
			if (flag)
			{
				this.SKIP1.BackColor = Color.LightGreen;
			}
			else
			{
				this.SKIP1.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x001523F4 File Offset: 0x001507F4
		private void SKIP2_Click(object sender, EventArgs e)
		{
			bool flag = this.SKIP2.BackColor == Color.LightGray;
			if (flag)
			{
				this.SKIP2.BackColor = Color.LightGreen;
			}
			else
			{
				this.SKIP2.BackColor = Color.LightGray;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00152444 File Offset: 0x00150844
		private void SKIP3_Click(object sender, EventArgs e)
		{
			bool flag = this.SKIP3.BackColor == Color.LightGray;
			if (flag)
			{
				this.SKIP3.BackColor = Color.LightGreen;
			}
			else
			{
				this.SKIP3.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00152494 File Offset: 0x00150894
		private void SKIP4_Click(object sender, EventArgs e)
		{
			bool flag = this.SKIP4.BackColor == Color.LightGray;
			if (flag)
			{
				this.SKIP4.BackColor = Color.LightGreen;
			}
			else
			{
				this.SKIP4.BackColor = Color.LightGray;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x001524E4 File Offset: 0x001508E4
		private void BUTTON_FII_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000058 RID: 88
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("BUTTON_LOAD")]
		private Button _BUTTON_LOAD;

		// Token: 0x0400005B RID: 91
		[AccessedThroughProperty("Button_DIS_P")]
		private Button _Button_DIS_P;

		// Token: 0x0400005C RID: 92
		[AccessedThroughProperty("SKIP4")]
		private Button _SKIP4;

		// Token: 0x0400005D RID: 93
		[AccessedThroughProperty("SKIP3")]
		private Button _SKIP3;

		// Token: 0x0400005E RID: 94
		[AccessedThroughProperty("SKIP2")]
		private Button _SKIP2;

		// Token: 0x0400005F RID: 95
		[AccessedThroughProperty("SKIP1")]
		private Button _SKIP1;

		// Token: 0x04000060 RID: 96
		[AccessedThroughProperty("SKIP0")]
		private Button _SKIP0;

		// Token: 0x04000061 RID: 97
		[AccessedThroughProperty("Frame2")]
		private GroupBox _Frame2;

		// Token: 0x04000062 RID: 98
		[AccessedThroughProperty("START")]
		private Button _START;

		// Token: 0x04000063 RID: 99
		[AccessedThroughProperty("BUTTON_FII")]
		private Button _BUTTON_FII;

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("REG_FUNC")]
		private TextBox _REG_FUNC;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("SWITCH_FUNC")]
		private Button _SWITCH_FUNC;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("Stop_Renamed")]
		private Button _Stop_Renamed;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("REG_SR")]
		private TextBox _REG_SR;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("REG_AU")]
		private TextBox _REG_AU;

		// Token: 0x04000069 RID: 105
		[AccessedThroughProperty("REG_ICR")]
		private TextBox _REG_ICR;

		// Token: 0x0400006A RID: 106
		[AccessedThroughProperty("REG_PROG")]
		private TextBox _REG_PROG;

		// Token: 0x0400006B RID: 107
		[AccessedThroughProperty("REG_AL")]
		private TextBox _REG_AL;

		// Token: 0x0400006C RID: 108
		[AccessedThroughProperty("SWITCH_CLEAR")]
		private Button _SWITCH_CLEAR;

		// Token: 0x0400006D RID: 109
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("FII")]
		private Label _FII;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("_Label3_2")]
		private Label __Label3_2;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("_Label3_1")]
		private Label __Label3_1;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("_Label3_0")]
		private Label __Label3_0;

		// Token: 0x04000074 RID: 116
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000075 RID: 117
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000076 RID: 118
		[AccessedThroughProperty("STOPS")]
		private GroupBox _STOPS;

		// Token: 0x04000077 RID: 119
		[AccessedThroughProperty("STOP4")]
		private Button _STOP4;

		// Token: 0x04000078 RID: 120
		[AccessedThroughProperty("STOP3")]
		private Button _STOP3;

		// Token: 0x04000079 RID: 121
		[AccessedThroughProperty("STOP2")]
		private Button _STOP2;

		// Token: 0x0400007A RID: 122
		[AccessedThroughProperty("STOP1")]
		private Button _STOP1;

		// Token: 0x0400007B RID: 123
		[AccessedThroughProperty("STOP0")]
		private Button _STOP0;

		// Token: 0x0400007C RID: 124
		[AccessedThroughProperty("SWITCH_MODE")]
		private Button _SWITCH_MODE;

		// Token: 0x0400007D RID: 125
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("Timer2")]
		private Timer _Timer2;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("INS_SECOND")]
		private TextBox _INS_SECOND;

		// Token: 0x04000081 RID: 129
		private object lastREG_AUText;

		// Token: 0x04000082 RID: 130
		private object lastREG_ALText;
	}
}
