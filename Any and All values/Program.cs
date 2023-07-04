List<int> listOfNumbers = new List<int>(){ 5, 10, 8, 3, 6, 12 , 52, 2, 67, 9};

Console.WriteLine("query syntax:");
bool verifyOfnumbersAllEvenQuerySyntax = (from number in listOfNumbers where (number % 2 == 0) select number).Count() == listOfNumbers.Count;
bool verifyOfnumbersAllOddQuerySyntax= (from number in listOfNumbers where (number % 2 != 0) select number).Count() == listOfNumbers.Count;

Console.WriteLine("i numeri della lista sono tutti pari?= " + verifyOfnumbersAllEvenQuerySyntax);
Console.WriteLine("i numeri della lista sono tutti dispari?= " + verifyOfnumbersAllOddQuerySyntax);

Console.WriteLine("-----------------------------------------");

Console.WriteLine("Method syntax:");
bool verifyOfNumbersAllEvenMethodSyntax = listOfNumbers.All(number => number % 2 == 0);
bool verifyOfnumbersAllOddMethodSyntax= listOfNumbers.All(number => number % 2 == 0);

Console.WriteLine("i numeri della lista sono tutti pari?= " + verifyOfNumbersAllEvenMethodSyntax);
Console.WriteLine("i numeri della lista sono tutti dispari?= " + verifyOfnumbersAllOddMethodSyntax);



