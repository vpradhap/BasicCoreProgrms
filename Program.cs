using BasicCoreProgrms;

//Options for which basic programs to pick
Console.WriteLine("Pick Which program You Want to Perform");
Console.WriteLine("1 - Flipcoin Program");
Console.WriteLine("2 - LeapYear Program");
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
    default:
        Console.WriteLine("Invalid Input");
        break;
}
