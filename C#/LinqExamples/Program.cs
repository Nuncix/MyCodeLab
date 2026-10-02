LinqSort();
LinqWhere();
LinqTakeSkip();


void LinqSort()
{
    string[] names = new string[] { "Pino", "Gigi", "Provolo", "Ermenegildo" };

    //var result = names.OrderBy(name => name);
    //var result = names.OrderByDescending(name => name);
    //var result = names.Reverse();
    var result = names.OrderBy(name => name.Length).ThenBy(name => name);

    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}

void LinqTakeSkip()
{
    int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //var result = numbers.Take(5);
    //var result = numbers.TakeWhile(number => number < 8);
    //var result = numbers.SkipWhile(number => number < 8);
    var result = numbers.Skip(8);


    foreach (var item in result)
    {
        Console.WriteLine(item);
    }
}

void LinqWhere()
{
    int[] numbers = new int[] { 1, 2, 3, 5, 9, 1 };
    List<int> greaterThanTwo = new List<int>();

    foreach (var number in numbers)
    {
        if (number > 2)
        {
            greaterThanTwo.Add(number);
        }
    }

    //greaterThanTwo = numbers.Where(number => number > 2).ToList();
    greaterThanTwo = numbers.Where((number, index) => (number > 2) && index >= 3).ToList();

    foreach (var number in greaterThanTwo)
    {
        Console.WriteLine(number);
    }
}