// See https://aka.ms/new-console-template for more information

int abc = 5000;
object obj = abc;//Boxing
int xyz = (int)obj;//UnBoxing
Console.WriteLine("Value Of Object = "+ abc);
Console.WriteLine("Value Of Xyz = " + xyz);
