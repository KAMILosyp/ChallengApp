int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

List<int> numbers = Enumerable.Range(1, 10).ToList();
List<int> numbersList = new List<int>();

for (int i = 0; i < letters.Length; i++)
{
    numbersList.Add(int.Parse(letters[i].ToString()));
    Console.WriteLine(letters[i]);
}