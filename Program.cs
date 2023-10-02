// Kyle Solesbee 10/2/23
// Room Calculator Lab

double length = 0;
double width = 0;
double height = 0;

Console.WriteLine("Please enter the width of the classroom: ");
length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the length of the classroom: ");
width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the height of the classroom: ");
height = double.Parse(Console.ReadLine());

double perimeter  = (width * 2) + (length * 2);
double area = (width * length);
double volume = (length * width * height);
double surfaceArea = ((2 * length * width) + (2 * length * height) + (2 * width * height)); 

Console.WriteLine($"The perimeter is {perimeter}");
Console.WriteLine($"The area is {area}");
Console.WriteLine($"The volume is {volume}");
Console.WriteLine($"The surface area is {surfaceArea}");

if (area <= 250)
{
    Console.WriteLine("The room is small.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("The room is medium.");
} 
else if (area > 650)
{
    Console.WriteLine("The room is large.");
}
