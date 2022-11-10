int a = 2; 
int b = 4;
int c = 8;
int d = 1;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);