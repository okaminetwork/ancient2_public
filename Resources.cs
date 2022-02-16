using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Patcher.Properties
{
	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x0600004B RID: 75 RVA: 0x00003C51 File Offset: 0x00001E51
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003C5C File Offset: 0x00001E5C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("Patcher.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003C9B File Offset: 0x00001E9B
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00003CA2 File Offset: 0x00001EA2
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

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003CAC File Offset: 0x00001EAC
		internal static Bitmap bg
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("bg", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003CD4 File Offset: 0x00001ED4
		internal static Bitmap close
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("close", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00003CFC File Offset: 0x00001EFC
		internal static Bitmap config
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("config", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003D24 File Offset: 0x00001F24
		internal static Bitmap minimise
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("minimise", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003D4C File Offset: 0x00001F4C
		internal static Bitmap start
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("start", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000034 RID: 52
		private static ResourceManager resourceMan;

		// Token: 0x04000035 RID: 53
		private static CultureInfo resourceCulture;
	}
}
