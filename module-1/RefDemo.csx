ref int RefDemo(ref int x, int y)
{
    //x++;
    y--;
    return ref x;
}

int a = 1, b = 10;
readonly int c = RefDemo(ref a, b);
//c += 100;

WriteLine($"a = {a}, b = {b}, c = {c}");