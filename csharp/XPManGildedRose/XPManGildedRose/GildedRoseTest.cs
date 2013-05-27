using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace GildedRose
{
	[TestFixture()]
	public class GildedRoseTest
	{
		[Test()]
		public void foo() {
			IList<Item> Items = new List<Item> { new StandardItem(name: "PurestGreen", sellIn: 0, quality: 0) };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
            Assert.AreEqual("PurestGreen", Items[0].Name);
		}
	}
}

