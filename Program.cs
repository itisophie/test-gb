Console.Write($"Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
string[] arrString = new string[elementsCount];

for (int i = 0; i < arrString.Length; i++)
{
   Console.Write($"\nВведите элемент массива под индексом:{i}:\t");
   arrString[i] =  string.Concat(Console.ReadLine());
}
Console.WriteLine($"\nВаш массив: ");
for (int i = 0; i < arrString.Length; i++)
{
    Console.WriteLine(arrString[i]);
}
Console.ReadLine();
var result = arrString.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();