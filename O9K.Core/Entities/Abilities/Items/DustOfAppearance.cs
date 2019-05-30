﻿using System;
using Ensage;
using O9K.Core.Entities.Abilities.Base;
using O9K.Core.Entities.Metadata;
using O9K.Core.Helpers;

namespace O9K.Core.Entities.Abilities.Items
{
	// Token: 0x0200016E RID: 366
	[AbilityId(AbilityId.item_dust)]
	public class DustOfAppearance : AreaOfEffectAbility
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00006612 File Offset: 0x00004812
		public DustOfAppearance(Ability baseAbility) : base(baseAbility)
		{
			this.RadiusData = new SpecialData(baseAbility, "radius");
		}
	}
}
