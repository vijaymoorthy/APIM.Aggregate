using Internal;

int digit = 1234;

var original = digit;
int rev = 0;
while (original != 0)
{
    var pop = original % 10;
    original /= 10;
    rev = rev * 10 + pop;
}
Console.WriteLine($"the reverse is {rev}");
