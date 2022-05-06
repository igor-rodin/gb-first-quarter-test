/// <summary>
/// Метод <c>GetThreeCharStrings</c> формирует из массива строк <c>inputArray</c>
/// массив строк, состоящий из 3 и меньше символов
/// </summary>
/// <param name="inputArray">Массив строк</param>
/// <returns>Массив строк, состоящий из 3 и меньше символов</returns>
string[] GetThreeCharStrings(string[] inputArray)
{
  int size = inputArray.Length;
  int index = 0;
  int resArraySize = 0;
  string[] resArray;

  while (index < size)
  {
    if (inputArray[index].Length <= 3) resArraySize += 1;

    index += 1;
  }

  resArray = new string[resArraySize];
  index = 0;
  int resIndex = 0;

  while (index < size)
  {
    if (inputArray[index].Length <= 3)
    {
      resArray[resIndex] = inputArray[index];
      resIndex += 1;
    }

    index += 1;
  }

  return resArray;
}

/// <summary>
/// Метод <c>PrintWords</c> формирует строку из массива строк <c>words</c>
/// с разделителем <c>delim</c> между ними 
/// /// </summary>
/// <param name="words">Массив строк</param>
/// <param name="delim">Разделитель</param>
/// <returns>Результирующая строка</returns>
string PrintWords(string[] words, string delim)
{
  if (words.Length == 0) return string.Empty;

  string resString = string.Empty;
  for (int i = 0; i < words.Length - 1; i++)
  {
    resString += $"{words[i]}{delim}";
  }
  resString += $"{words[words.Length - 1]}";

  return resString;
}
////////////////////////////////////////////////////////////////////////
string[] testData = { "hello", "2", "world", ":-)" };

Console.WriteLine($"Исходный массив: [{PrintWords(testData, ", ")}]");

string[] resArray = GetThreeCharStrings(testData);

Console.WriteLine($"Сформированный массив: [{PrintWords(resArray, ", ")}]");
