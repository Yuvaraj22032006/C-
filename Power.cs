using System.IO.Pipelines;

string? a = "";
string? b = "";
static int multi(int baseNum, int powNum)
{
    int Result = 1;
    for (int i = 0; i < powNum; i++)
    {
        Result = Result * baseNum;
    }
    return Result;
}
Console.WriteLine("Enter Base:");
a = Console.ReadLine();
int num1 = Convert.ToInt32(a);

Console.WriteLine("Enter Power:");
b = Console.ReadLine();
int num2 = Convert.ToInt32(b);


Console.Write(multi(num1, num2));


