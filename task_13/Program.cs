//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Number = new Random().Next (0,9999);
Console.WriteLine(Number);
string array =Convert.ToString(Number);
if (array.Length>2)
{
    Console.WriteLine(array[2] + " - третья цифра");
}
else
{
    Console.WriteLine("Третьей цифры нет в заданном числе");
}