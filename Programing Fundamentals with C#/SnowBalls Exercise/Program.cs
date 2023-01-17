using System.Numerics;

int num = int.Parse(Console.ReadLine());

BigInteger highestVal = BigInteger.MinusOne;
int highestSnow = 0;
int highestTime = 0;
int highestQuality = 0;

for (int i = 0; i < num; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

   BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
    if (highestVal < snowballValue)
    {
        highestVal = snowballValue;
        highestSnow = snowballSnow;
        highestTime = snowballTime;
        highestQuality = snowballQuality;
    }
}
Console.WriteLine($"{highestSnow} : {highestTime} = {highestVal} ({highestQuality})");
