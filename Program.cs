using BasicCoreProgrms;

//Options for which basic programs to pick
Console.WriteLine("Pick Which program You Want to Perform");
Console.WriteLine("1 - Flipcoin Program");
Console.WriteLine("2 - LeapYear Program");
Console.WriteLine("3 - Powerof2 Program");
Console.WriteLine("4 - HarmonicNumber Program");
Console.WriteLine("5 - PrimeFactors Program");
Console.Write("Your Pick : ");

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
    default:
        Console.WriteLine("Invalid Input");
        break;
}
