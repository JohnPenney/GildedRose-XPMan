<?php

include 'gilded_rose.php';

class GildedRoseTest extends PHPUnit_Framework_TestCase {
    public function testFoo() {
        $items = array(new Item("foo", 0, 0));
        $gilded_rose = new GildedRose($items);
        $gilded_rose->updateQuality();
        $this->assertEquals("fixme", $items[0]->name);
    }
}

