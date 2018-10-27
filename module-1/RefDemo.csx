static ref readonly int RefDemo(this in int x, int y)
{
     //x++;
    return ref x;
}

var a = 100;
var b = 200;
var c = a.RefDemo(b);
c++;

WriteLine($"a = {a}, b = {b}, c = {c}");
