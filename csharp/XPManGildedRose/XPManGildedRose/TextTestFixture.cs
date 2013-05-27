using System;
using System.Collections.Generic;

namespace GildedRose
{
	class Program
	{
		public static void Main(string[] args)
		{
			System.Console.WriteLine("Gilded Rose Stuff!");

			IList<Item> Items = new List<Item>{
				new StandardItem (name: "+5 Dexterity Vest",                           sellIn: 10,    quality: 20),
				new AgedBrie (sellIn: 2,     quality: 0 ),
				new StandardItem (name: "Elixir of the Mongoose",                      sellIn: 5,     quality: 7 ),
				new Sulfurus (quality: 80),
				new Sulfurus (quality: 80),
				new BackstagePass (artist: "TAFKAL80ETC",   sellIn: 15,    quality: 20),
				new BackstagePass (artist: "TAFKAL80ETC",   sellIn: 10,    quality: 49),
				new BackstagePass (artist: "TAFKAL80ETC",   sellIn: 5,     quality: 49),				
				new ConjuredItem (name: "Conjured Mana Cake",                          sellIn: 3,     quality: 6 )// this conjured item does not work properly yet
			};

			var app = new GildedRose(Items);

			
			for (var i = 0; i < 31; i++)
			{
				System.Console.WriteLine("-------- day " + i + " --------");
				System.Console.WriteLine("name, sellIn, quality");
				for (var j = 0; j < Items.Count; j++)
				{
					System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
				}
				System.Console.WriteLine("");
				app.UpdateQuality();
			}

		}

	}
}
