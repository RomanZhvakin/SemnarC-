int numberA = 5;
int numberB = 7;

int max = numberA;
if ( numberA > max ) max = numberA;
if ( numberB > max ) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);
