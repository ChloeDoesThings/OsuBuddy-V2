﻿using System;
using OsuParsers.Enums;

namespace OsuParsers.Database.Objects
{
	// Token: 0x0200006D RID: 109
	public class Score
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0000333A File Offset: 0x0000333A
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003342 File Offset: 0x00003342
		public Ruleset Ruleset { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000334B File Offset: 0x0000334B
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003353 File Offset: 0x00003353
		public int OsuVersion { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000335C File Offset: 0x0000335C
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003364 File Offset: 0x00003364
		public string BeatmapMD5Hash { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000336D File Offset: 0x0000336D
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003375 File Offset: 0x00003375
		public string PlayerName { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000337E File Offset: 0x0000337E
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003386 File Offset: 0x00003386
		public string ReplayMD5Hash { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0000338F File Offset: 0x0000338F
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003397 File Offset: 0x00003397
		public ushort Count300 { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600028F RID: 655 RVA: 0x000033A0 File Offset: 0x000033A0
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000033A8 File Offset: 0x000033A8
		public ushort Count100 { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000291 RID: 657 RVA: 0x000033B1 File Offset: 0x000033B1
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000033B9 File Offset: 0x000033B9
		public ushort Count50 { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000033C2 File Offset: 0x000033C2
		// (set) Token: 0x06000294 RID: 660 RVA: 0x000033CA File Offset: 0x000033CA
		public ushort CountGeki { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000033D3 File Offset: 0x000033D3
		// (set) Token: 0x06000296 RID: 662 RVA: 0x000033DB File Offset: 0x000033DB
		public ushort CountKatu { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000297 RID: 663 RVA: 0x000033E4 File Offset: 0x000033E4
		// (set) Token: 0x06000298 RID: 664 RVA: 0x000033EC File Offset: 0x000033EC
		public ushort CountMiss { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000033F5 File Offset: 0x000033F5
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000033FD File Offset: 0x000033FD
		public int ReplayScore { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00003406 File Offset: 0x00003406
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0000340E File Offset: 0x0000340E
		public ushort Combo { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00003417 File Offset: 0x00003417
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0000341F File Offset: 0x0000341F
		public bool PerfectCombo { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00003428 File Offset: 0x00003428
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00003430 File Offset: 0x00003430
		public Mods Mods { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00003439 File Offset: 0x00003439
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00003441 File Offset: 0x00003441
		public DateTime ScoreTimestamp { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000344A File Offset: 0x0000344A
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003452 File Offset: 0x00003452
		public long ScoreId { get; set; }
	}
}
