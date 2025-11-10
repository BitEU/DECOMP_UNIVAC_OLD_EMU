using System;
using Microsoft.VisualBasic.CompilerServices;

namespace mk152
{
	// Token: 0x02000008 RID: 8
	[StandardModule]
	internal sealed class Module1
	{
		// Token: 0x0400000B RID: 11
		public static int[] MEM = new int[32769];

		// Token: 0x0400000C RID: 12
		public static int[] REG_INDEX = new int[9];

		// Token: 0x0400000D RID: 13
		public static long REG_D;

		// Token: 0x0400000E RID: 14
		public static long REG_X;

		// Token: 0x0400000F RID: 15
		public static long XplusD;

		// Token: 0x04000010 RID: 16
		public static bool[] IN_ACTIVE = new bool[17];

		// Token: 0x04000011 RID: 17
		public static bool[] OUT_ACTIVE = new bool[17];

		// Token: 0x04000012 RID: 18
		public static bool[] EXF_ACTIVE = new bool[17];

		// Token: 0x04000013 RID: 19
		public static bool DESIG_COMPARE;

		// Token: 0x04000014 RID: 20
		public static bool DESIG_LT;

		// Token: 0x04000015 RID: 21
		public static bool DESIG_EQUAL;

		// Token: 0x04000016 RID: 22
		public static bool DESIG_OVERFLOW;

		// Token: 0x04000017 RID: 23
		public static bool DESIG_BORROW;

		// Token: 0x04000018 RID: 24
		public static bool DESIG_ALIKE;

		// Token: 0x04000019 RID: 25
		public static bool ANEGATIVE;

		// Token: 0x0400001A RID: 26
		public static bool AL_NEG;

		// Token: 0x0400001B RID: 27
		public static bool MEM_NEG;

		// Token: 0x0400001C RID: 28
		public static bool RUN_MODE;

		// Token: 0x0400001D RID: 29
		public static bool DISCONECT_P;

		// Token: 0x0400001E RID: 30
		public static bool FUNCTION_REP;

		// Token: 0x0400001F RID: 31
		public static long A;

		// Token: 0x04000020 RID: 32
		public static int AU;

		// Token: 0x04000021 RID: 33
		public static int AL;

		// Token: 0x04000022 RID: 34
		public static int ICR;

		// Token: 0x04000023 RID: 35
		public static int P;

		// Token: 0x04000024 RID: 36
		public static int FUNC;

		// Token: 0x04000025 RID: 37
		public static int SR;

		// Token: 0x04000026 RID: 38
		public static int ADD_USR;

		// Token: 0x04000027 RID: 39
		public static int ADD_UP;

		// Token: 0x04000028 RID: 40
		public static int f;

		// Token: 0x04000029 RID: 41
		public static int m;

		// Token: 0x0400002A RID: 42
		public static int k;

		// Token: 0x0400002B RID: 43
		public static int u;

		// Token: 0x0400002C RID: 44
		public static int INDEX;

		// Token: 0x0400002D RID: 45
		public static int INS;

		// Token: 0x0400002E RID: 46
		public static bool ACTIVE;

		// Token: 0x0400002F RID: 47
		public static int ADDRESS;

		// Token: 0x04000030 RID: 48
		public static int CODE;

		// Token: 0x04000031 RID: 49
		public static int SEXT;

		// Token: 0x04000032 RID: 50
		public static int uSEXT;

		// Token: 0x04000033 RID: 51
		public static int SEXT_LONG;

		// Token: 0x04000034 RID: 52
		public static int PART;

		// Token: 0x04000035 RID: 53
		public static int PART2;

		// Token: 0x04000036 RID: 54
		public static int MASK;

		// Token: 0x04000037 RID: 55
		public static int D;

		// Token: 0x04000038 RID: 56
		public static int N;

		// Token: 0x04000039 RID: 57
		public static int X;

		// Token: 0x0400003A RID: 58
		public static int ONES;

		// Token: 0x0400003B RID: 59
		public static int COUNT;

		// Token: 0x0400003C RID: 60
		public static string DSTRING;

		// Token: 0x0400003D RID: 61
		public static string TEMP;

		// Token: 0x0400003E RID: 62
		public static int CMEM_LOK;

		// Token: 0x0400003F RID: 63
		public static bool BUSY;

		// Token: 0x04000040 RID: 64
		public static bool RUNNING;

		// Token: 0x04000041 RID: 65
		public static bool SIGNS_NEG;

		// Token: 0x04000042 RID: 66
		public static bool SIGNS_POS;

		// Token: 0x04000043 RID: 67
		public static int LOOPS;

		// Token: 0x04000044 RID: 68
		public static int KOUNT;

		// Performance optimization: Pre-computed constant values
		public const int CONST_OCT_10 = 8;        // &O10 in octal = 8 in decimal
		public const long CONST_OCT_17 = 15L;      // &O17 in octal = 15 in decimal
		public const long CONST_OCT_770000 = 258048L; // &O770000 in octal = 258048 in decimal

		// Token: 0x04000045 RID: 69
		public static byte CONSOLE_CHAN;

		// Token: 0x04000046 RID: 70
		public static byte UPPER;

		// Token: 0x04000047 RID: 71
		public static byte IN_IACW;

		// Token: 0x04000048 RID: 72
		public static byte OUT_IACW;

		// Token: 0x04000049 RID: 73
		public static byte EXF_IACW;

		// Token: 0x0400004A RID: 74
		public static uint IN_WD;

		// Token: 0x0400004B RID: 75
		public static uint OUT_WD;

		// Token: 0x0400004C RID: 76
		public static uint D2;

		// Token: 0x0400004D RID: 77
		public static bool CON_MODE_IN;

		// Token: 0x0400004E RID: 78
		public static bool CON_MODE_OUT;

		// Token: 0x0400004F RID: 79
		public static char LETTER;

		// Token: 0x04000050 RID: 80
		public static byte OUT_BYTE;

		// Token: 0x04000051 RID: 81
		public static byte IN_BYTE;

		// Token: 0x04000052 RID: 82
		public static bool NEW_BYTE;

		// Token: 0x04000053 RID: 83
		public static string TAPE_FILE;

		// Token: 0x04000054 RID: 84
		public static bool NEW_FILE;

		// Token: 0x04000055 RID: 85
		public static bool OLD_FUNCTION_READ;
	}
}
