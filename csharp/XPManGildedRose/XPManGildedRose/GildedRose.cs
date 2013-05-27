using System.Collections.Generic;

namespace GildedRose
{
	class GildedRose
	{
		IList<Item> Items;
		public GildedRose(IList<Item> Items) 
		{
			this.Items = Items;
		}
		
		public void UpdateQuality()
		{
            foreach(var item in Items)
			{
                item.AgeByOneDay();
			}
		}
	}	
}
