using BasicCoreProgrms;

//Options for which basic programs to pick
Console.WriteLine("Pick Which program You Want to Perform");
Console.WriteLine("1 - Flipcoin Program");
Console.WriteLine("2 - LeapYear Program");
Console.WriteLine("3 - Powerof2 Program");
Console.WriteLine("4 - HarmonicNumber Program");
Console.WriteLine("5 - PrimeFactors Program");
Console.WriteLine("6 - Quotient And Remainder Program");
Console.WriteLine("7 - Swapping Two Numbers Program");
Console.WriteLine("8 - Even Or Odd Check Program");
Console.WriteLine("9 - Vowel Or Consonant Program");
Console.Write("\nYour Pick : ");

int pick = Convert.ToInt32(Console.ReadLine());
switch (pick)
{
    case 1:
        FlipCoin.Flip();
        break;
    case 2:
        LeapYear.Leap();
        break;
    case 3:
        PowerOf2.Power();
        break;
    case 4:
        HarmonicNumber.Harmonic();
        break;
    case 5:
        PrimeFactors.Factors();
        break;
    case 6:
        QuotientAndRemainder.QAndR();
        break;
    case 7:
        SwapTwoNumbers.SwapNumbers();
        break;
    case 8:
        EvenOrOdd.OddOrEven();
        break;
    case 9:
        VowelOrConsonant.ConsonantOrVowel();
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}
