using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GildedRose
{
    public class StandardItem : Item
    {
        public StandardItem(string name, int sellIn, int quality)
            : base(name, sellIn, quality)
        {
        }
        public override void UpdateQualityAtEndOfDay()
        {
            DecrementQuality();
        }
        public override void UpdateQualityPastSellByDate()
        {
            DecrementQuality();
        }
    }

    public class AgedBrie : Item
    {
        public AgedBrie(int sellIn, int quality)
            : base("Aged Brie", sellIn, quality)
        {
        }        
        public override void UpdateQualityAtEndOfDay()
        {
            IncrementQuality();
        }
        public override void UpdateQualityPastSellByDate()
        {
            IncrementQuality();
        }
    }

    public class BackstagePass : Item
    {
        public BackstagePass(string artist, int sellIn, int quality)
            : base("Backstage passes to a " + artist + " concert", sellIn, quality)
        {
        }        
        public override void UpdateQualityAtEndOfDay()
        {
            IncrementQuality();

            if (SellIn < 11)
            {
                IncrementQuality();
            }

            if (SellIn < 6)
            {
                IncrementQuality();
            }
        }
        public override void UpdateQualityPastSellByDate()
        {
            ZeroQuality();
        }
    }

    public class Sulfurus : Item
    {
        public Sulfurus(int quality)
            : base("Sulfuras, Hand of Ragnaros", 0 /*N/A*/, quality)
        {
        }
        public override void UpdateQualityAtEndOfDay()
        {
        }
        public override void UpdateQualityPastSellByDate()
        {
        }
    }

    public class ConjuredItem : Item
    {
        public ConjuredItem(string name, int sellIn, int quality)
            : base(name, sellIn, quality)
        {
        }
        public override void UpdateQualityAtEndOfDay()
        {
            DecrementQuality();
            DecrementQuality();
        }
        public override void UpdateQualityPastSellByDate()
        {
            DecrementQuality();
            DecrementQuality();
        }
    }

    public abstract class Item
    {
        public Item(string name, int sellIn, int quality)
        {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public string Name { get; private set; }

        public int SellIn { get; private set; }

        public int Quality { get; private set; }


        public void AgeByOneDay()
        {
            UpdateQualityAtEndOfDay();
            DecrementSellIn();
            if (IsPastSellByDate())
            {
                UpdateQualityPastSellByDate();
            }
        }

        public abstract void UpdateQualityAtEndOfDay();
        public abstract void UpdateQualityPastSellByDate();

        #region Implementation

        protected void DecrementSellIn()
        {
            SellIn = SellIn - 1;
        }

        protected bool IsPastSellByDate()
        {
            return SellIn < 0;
        }

        protected void DecrementQuality()
        {
            if (Quality > QualityMin())
            {
                Quality = Quality - 1;
            }
        }

        protected void IncrementQuality()
        {
            if (Quality < QualityMax())
            {
                Quality = Quality + 1;
            }
        }

        protected void ZeroQuality()
        {
            Quality = 0;
        }

        protected static int QualityMin()
        {
            return 0;
        }

        protected static int QualityMax()
        {
            return 50;
        }
        
        #endregion
    }
}
