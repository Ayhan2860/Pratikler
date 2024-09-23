// See https://aka.ms/new-console-template for more information
using AreaCalculation;
bool state = true;

while (state)
{
    int vote = Menu.MainMenu();
    switch (vote)
    {
        case 1:
            ScreenWrite.CircleAreaOrPerimeterCalculation();
            break;
        case 2:
            ScreenWrite.TriangleAreaOrPerimeterCalculation();
            break;
        case 3:
            ScreenWrite.SquareAreaOrPerimeterCalculation();
            break;
        case 4:
            ScreenWrite.RectangleAreaOrPerimeterCalculation();
            break;
        case 5:
            state = false;
            break;
        default:
            Console.WriteLine("Hatalı İşlem Yaptınız");
            break;
    }

    Console.ReadLine();

}

