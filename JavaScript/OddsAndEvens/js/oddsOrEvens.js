/*

	This program lets the user simulate creating an
	alphabetic (A - Z) letter 1000 times.  A count is
	made of how many vowels (A, E, I, O, or U) are
	generated.  Ideally the total vowels will below
	approximately 20% (~200).

*/

function oddsOrEvens()
{
	var totOdds 		= 0;		//	Total # odd  numbers generated
	var totEvens 		= 0;		//	Total # even numbers generated
	var theNumber 	= 0;		//	Current number generated

	var lcv =1;
	while (lcv <= 1000)
	{
		theNumber = Math.floor(Math.random() * 101);

		while (theNumber == 0)
		{
			theNumber = Math.floor(Math.random() * 101);
		}
		if (theNumber % 2 == 0)
		{
			totEvens++;
		}
		else
		{
			totOdds++;
		}

		++lcv;
	}

	alert ("Total Number Evens: " + totEvens + "\n" +
				"Total Number Odds: " + totOdds);

}
