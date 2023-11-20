Console.Clear(); // возможная 'очистка' консоли

int xa = 1, ya = 1, //оп ределяем 1ую точку треугольника с координатами по х и у
    xb = 1, yb = 30, // следующая точка треугольника
    xc = 40, yc = 30;

Console.SetCursorPosition(xa, ya); // команда, которая будет 'рисовать' с отступом от левого и правого края n символов
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count <10)
{
    int what = new Random().Next(0, 3)
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 1)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1 // count =+1 или count++

}
     