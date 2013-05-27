

describe("when Gilded Rose is run for 30 days", function() {

    function createGoldenMaster() {
        for (var day = 1; day < 31; day++) {
            o_update_quality();
            window.localStorage.setItem('day' + day, JSON.stringify(oitems));
        }
    }

    beforeEach(function() {
        if (window.localStorage.length === 0 ) {

            createGoldenMaster();
        }
    });


    it("should update quality for each item", function() {

        for (var day = 1; day < 31; day++ ) {
            update_quality();
            
            var expected = JSON.parse(window.localStorage.getItem('day' + day));
            expect(items.length).toEqual(expected.length);
            for (var index =0; index< items.length; index++ )
            {
                expect(items[index]).toEqual(expected[index]);
            }
        }
    });


});
