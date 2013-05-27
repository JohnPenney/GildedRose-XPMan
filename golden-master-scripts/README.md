Golden Master scripts for the Gilded Rose Kata
==============================================

Here are some simple scripts to allow you to work using the Golden Master technique.

The Golden Master technique involves pushing a large amount of data through your system and recording the output in a file - the Golden Master.  After each refactoring step, you push the same data set through your code and compare the output to the Golden Master.

Generation
----------

The first job is to generate your Golden Master.  To do this you run the following script:

	generate "<Your command here>" "<output directory>"

The command to run for your choice of language can be found at the bottom of this file.

I've been using the language name as an output directory, so, for example, using `java` will generate the `java/golden-master` file.  The file name can't be changed... without hacking the scripts.  Feel free if you want to.

Verification
------------

Once you've made a refactoring, you'll want to check you haven't broken anything.  You need to do:

	verify "<Your command here>" "<output directory>"

Note that the args are identical to that of the `generate` command you used earlier.

You will either get a simple message telling you that your tests pass, or the diffs between the current output and the Golden Master.  If you have failures, fix them or revert to your last safe point.  Running `verify` again will tell you when the behaviour has returned to the original.

Updating
--------

Should you actually want to make a change to the Golden Master to represent a change of functionality (e.g. changing the behaviour of the Conjured Mana Cake) then, assuming you're happy with your diffs from the `verify` command, simply run the `generate` command again. 

Windows
-------

Windows users should use the Power Shell versions of the scripts `generate.ps1` and `verify.ps1`.  Note that you might need to enter `Set-ExecutionPolicy RemoteSigned` into Power Shell to allow it to run scripts.

Language Specific Usage
-----------------------

Note that you may need to ensure that enough data is pushed through your code.  The tests provided in this repo require 30 days' worh of updates, which explains the parameter 30 for some languages (for the others the 30 is burnt in).  You can check that you have enough data by simply inspecting the Golden Master file that is output.

	generate 'java -classpath ../Java/bin com.gildedrose.TexttestFixture 30' java
	verify 'java -classpath ../Java/bin com.gildedrose.TexttestFixture 30' java

	generate 'python ../python/texttest_fixture.py 30' python
	verify 'python ../python/texttest_fixture.py 30' python

	generate 'ruby ../ruby/texttest_fixture.rb 30' ruby
	verify 'ruby ../ruby/texttest_fixture.rb 30' ruby

	generate '../cpp/GildedRoseTextTests' cpp
	verify '../cpp/GildedRoseTextTests' cpp
	
	generate '../C/GildedRoseTextTests' C
	verify '../C/GildedRoseTextTests' C


Scripts originally based on code by Samir Talwar: https://github.com/SamirTalwar/trivia-golden-master
