static int recursive_multiple(int mulitplicand, int multiplier)
{
    if (mulitplicand == 1 || multiplier == 1)
    {
        return mulitplicand * multiplier;
    }
    else if (mulitplicand == 0 || multiplier == 0)
    {
        return 0;
    }
    else
    {
        return mulitplicand + recursive_multiple(mulitplicand, multiplier - 1);
    }
}
static int recursive_div(int dividend, int divisor)
{
    int count = 0;
    if (dividend == divisor || divisor == dividend)
    {
        return 1;
    }
    else if (dividend == 0 || divisor == 0)
    {
        return -1;
    }
    else if (divisor > dividend)
    {
        return 0;
    }
    else
    {
        count++;
        return count + recursive_div(dividend - divisor, divisor);
    }
}
static int recursive_mod(int information, int RF)
{
    if (information == 0 || RF == 0)
    {
        return -1;
    }
    else if (information < RF)
    {
        return information;
    }
    else
    {
        return recursive_mod(information-RF, RF);
    }
}
Console.WriteLine(recursive_multiple(5, 4));
Console.WriteLine(recursive_div(49, 7));
Console.WriteLine(recursive_mod(7, 3));