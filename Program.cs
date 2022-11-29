string[] mass;
Console.WriteLine("Введите массив строк, используя пробел как разделитель между словами или числами");
string massstr = Console.ReadLine();
mass = massstr.Split(' ');
var result = new string[mass .Length];
var realSize = 0;
foreach (var value in mass )
{
    if (value.Length <= 3)
         {
            result[realSize] = value;
            realSize++;
         }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);
