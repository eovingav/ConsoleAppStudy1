Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string binary_repr = Convert.ToString(number, 2);
Console.WriteLine($"В в числе {number} - {binary_repr.Length} разрядов, число в двоичном виде:");
Console.WriteLine($"          {binary_repr}");
Console.Write("Введите номер разряда: ");
int binary_digit_place = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Inverted  {Convert.ToString(invertDigit(number, binary_digit_place),2)}");
Console.WriteLine($"Bit set   {Convert.ToString(setDigit(number, binary_digit_place), 2)}");
Console.WriteLine($"Bit unset {Convert.ToString(unsetDigit(number, binary_digit_place), 2)}");
int invertDigit(int number, int place)
{
    return (number & (1 << (place - 1))) > 0 ? unsetDigit(number, place) : setDigit(number, place);
}

int setDigit(int number, int place)
{
    return number| (1 << (place - 1));
}

int unsetDigit(int number, int place)
{
    return number & ((1 << (place - 1)) ^ int.MaxValue);
}
