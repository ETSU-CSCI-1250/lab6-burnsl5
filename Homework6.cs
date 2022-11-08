
////////////////////// MAIN METHOD   /////////////////////////////

string message = "New York";
Console.WriteLine("Enter the character");
int index = int.Parse(Console.ReadLine()) - 1;
ShowCharacter(message, index);

for (int f = 80; f <= 100; f++)
{
    Console.WriteLine($"{f}f = {Celsius(f)} C");
}

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine($"{i} = {IsPrime(i)}");
}

// get numbers for CalculateRetail arguments
Console.Write("Enter a product cost: ");
var pc = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a markup percentage: ");
var mp = Convert.ToDouble(Console.ReadLine())/100;

var totalCost = CalculateRetail(pc, mp);

Console.WriteLine($"Total cost: {totalCost}");

/////////////////////////////////////////////////////////////////

static void ShowCharacter(string str, int index)
{
    Console.WriteLine($"{str[index]}");
}

//Calculate Retail method
static double CalculateRetail(double productCost, double markupPercent)
{
    //Console.Write("Enter item's wholesale cost: ");
    //double productCost = double.Parse(Console.Read());
    //Console.Write("Enter in markup percentage");
    //double markupPercent = double.Parse(Console.Read());

    double finalTotal = productCost + (productCost * markupPercent);
    return finalTotal;

}

//Temperature Table
static double Celsius(double fTemp)
{
    double cTemp = 5.0 / 9.0 * fTemp - 32;

    return cTemp;
}

static bool IsPrime(int num)
{
if (num <= 1)
    return false;
for (int i = 2; i < num; i++)
{
    if (num % i == 0)
        return false;
}
return true;
}