List<int> listOfNumbers = new List<int>(){ 5, 10, 8, 3, 6, 12 , 52, 2, 67, 9};

Console.WriteLine("USO IL METODO ALL SIA PER LA QUERY CHE IL METHOD SYNTAX");
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



Console.WriteLine("-----------------------------------------");

Console.WriteLine("USO IL METODO ANY SIA PER LA QUERY CHE IL METHOD SYNTAX");
Console.WriteLine("query syntax:");
bool verifyOfnumbersAnyEvenQuerySyntax = (from number in listOfNumbers where (number % 2 == 0) select number).Any();
bool verifyOfnumbersAnyOddQuerySyntax = (from number in listOfNumbers where (number % 2 != 0) select number).Any();

Console.WriteLine("i numeri della lista sono tutti pari?= " + verifyOfnumbersAnyEvenQuerySyntax);
Console.WriteLine("i numeri della lista sono tutti dispari?= " + verifyOfnumbersAnyOddQuerySyntax);

Console.WriteLine("-----------------------------------------");

Console.WriteLine("Method syntax:");
bool verifyOfNumbersAnyEvenMethodSyntax = listOfNumbers.Any(number => number % 2 == 0);
bool verifyOfnumbersAnyOddMethodSyntax = listOfNumbers.Any(number => number % 2 == 0);

Console.WriteLine("ci sono alcuni numeri pari?= " + verifyOfNumbersAnyEvenMethodSyntax);
Console.WriteLine("ci sono alcuni numeri dispari?= " + verifyOfnumbersAnyOddMethodSyntax);


