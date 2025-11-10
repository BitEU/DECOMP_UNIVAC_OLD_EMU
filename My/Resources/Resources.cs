using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace mk152.My.Resources
{
	// Token: 0x02000009 RID: 9
	[HideModuleName]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[DebuggerNonUserCode]
	[StandardModule]
	internal sealed class Resources
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x0014A688 File Offset: 0x00148A88
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = object.ReferenceEquals(Resources.resourceMan, null);
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("mk152.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0014A6D0 File Offset: 0x00148AD0
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0014A6E8 File Offset: 0x00148AE8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000056 RID: 86
		private static ResourceManager resourceMan;

		// Token: 0x04000057 RID: 87
		private static CultureInfo resourceCulture;
	}
}
