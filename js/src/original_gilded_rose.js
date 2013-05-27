function Item(name, sell_in, quality) {
  this.name = name;
  this.sell_in = sell_in;
  this.quality = quality;
}

var oitems = [];

oitems.push(new Item('+5 Dexterity Vest', 10, 20));
oitems.push(new Item('Aged Brie', 2, 0));
oitems.push(new Item('Elixir of the Mongoose', 5, 7));
oitems.push(new Item('Sulfuras, Hand of Ragnaros', 0, 80));
oitems.push(new Item('Backstage passes to a TAFKAL80ETC concert', 15, 20));
oitems.push(new Item('Conjured Mana Cake', 3, 6));

function o_update_quality() {
  for (var i = 0; i < oitems.length; i++) {
    if (oitems[i].name != 'Aged Brie' && oitems[i].name != 'Backstage passes to a TAFKAL80ETC concert') {
      if (oitems[i].quality > 0) {
        if (oitems[i].name != 'Sulfuras, Hand of Ragnaros') {
          oitems[i].quality = oitems[i].quality - 1
        }
      }
    } else {
      if (oitems[i].quality < 50) {
        oitems[i].quality = oitems[i].quality + 1
        if (oitems[i].name == 'Backstage passes to a TAFKAL80ETC concert') {
          if (oitems[i].sell_in < 11) {
            if (oitems[i].quality < 50) {
              oitems[i].quality = oitems[i].quality + 1
            }
          }
          if (oitems[i].sell_in < 6) {
            if (oitems[i].quality < 50) {
              oitems[i].quality = oitems[i].quality + 1
            }
          }
        }
      }
    }
    if (oitems[i].name != 'Sulfuras, Hand of Ragnaros') {
      oitems[i].sell_in = oitems[i].sell_in - 1;
    }
    if (oitems[i].sell_in < 0) {
      if (oitems[i].name != 'Aged Brie') {
        if (oitems[i].name != 'Backstage passes to a TAFKAL80ETC concert') {
          if (oitems[i].quality > 0) {
            if (oitems[i].name != 'Sulfuras, Hand of Ragnaros') {
              oitems[i].quality = oitems[i].quality - 1
            }
          }
        } else {
          oitems[i].quality = oitems[i].quality - oitems[i].quality
        }
      } else {
        if (oitems[i].quality < 50) {
          oitems[i].quality = oitems[i].quality + 1
        }
      }
    }
  }
}
