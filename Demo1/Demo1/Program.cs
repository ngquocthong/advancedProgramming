/*
using System.Globalization;

Console.WriteLine("Input: ");
string input = Console.ReadLine();
DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
Console.WriteLine(date.DayOfWeek);
*/

string[] words = Console.ReadLine().Split(' ');
Random r = new Random();
int random = r.Next(words.Length);

for(int pos1 = 0; pos1 < words.Length; pos1++)
{
    int pos2 = r.Next(words.Length);
    String tmp = words[pos1];
    words[pos1] = words[pos2];
    words[pos2] = tmp;
}
Console.WriteLine(string.Join(Environment.NewLine, words));
