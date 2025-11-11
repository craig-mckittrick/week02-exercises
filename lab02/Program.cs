// Console.WriteLine("Hello World!");
// int year = 1965;
// double miles = 19534.6;
// Console.WriteLine(year.ToString());
// Console.WriteLine(miles.ToString());

int number1 = 10;
int number2 = 10;
double number3 = 10.0;
double number4 = 5.2345;

// int addTwoNumbers = number1 + number2;
// var addTwoNumbers2 = number1 + number2;
// Console.WriteLine(addTwoNumbers);
// Console.WriteLine(addTwoNumbers2);

// var subtractInts = number1 - number2;
// var subtractDoubles = number3 - number4;
// Console.WriteLine(subtractInts);
// Console.WriteLine(subtractDoubles);
// number1 = 2;
// number3 = 14.875;
// double noValue;
// noValue = 1.0;
// Console.WriteLine(noValue);

// int result1 = number1 * number2;
// double result2 = number3 * number4;
// var result3 = number2 / number1;
// var result4 = number3 / number4;
// var result5 = number1 * number4;
// var result6 = number3 / number1;
// Console.WriteLine("Result1: " + result1);
// Console.WriteLine("Result2: " + result2);
// Console.WriteLine("Result3: " + result3);
// Console.WriteLine("Result4: " + result4);
// Console.WriteLine("Result5: " + result5);
// Console.WriteLine("Result6: " + result6);

// string namePrompt = "Please enter your name: ";
// Console.WriteLine(namePrompt);
// var name = Console.ReadLine();
// Console.WriteLine("Hello " + name);

// var favoriteColorPrompt = "Please enter your favorite color: ";
// Console.WriteLine(favoriteColorPrompt);
// var favoriteColor = Console.ReadLine();
// Console.WriteLine("Your favorite color is: " + favoriteColor);

// Console.WriteLine(string.Format("Hello {0}! Your favorite color is: {1}", name, favoriteColor));

var carData = "1965|Ford|Mustang|75231.9|Blue";

// Console.WriteLine($"Length: {carData.Length}");
// Console.WriteLine($"Substring 10: {carData.Substring(10)}");
// Console.WriteLine($"Substring 17: {carData.Substring(17)}");
// Console.WriteLine($"Substring 10, 7: {carData.Substring(10, 7)}");

// Console.WriteLine($"Substring 17: {carData.Substring(45)}");
//Console.WriteLine($"Substring 17: {carData.Substring(25, 15)}");

// var trailingSpaces = "1994|Ford|Mustang|175231.9|Green  ";
// Console.WriteLine($"Trailing Spaces Length: {trailingSpaces.Length}");
// Console.WriteLine($"Trailing Spaces Length Trimmed: {trailingSpaces.Trim().Length}");

// var updatedCar = carData.Replace("1965", "1985");
// updatedCar = updatedCar.Replace("Ford", "Chevy");
// updatedCar = updatedCar.Replace("Mustang", "Camaro");
// Console.WriteLine($"Your new car data is: {updatedCar}");

// var adjustedCarData = carData.ToUpper();
// Console.WriteLine($"Car Data: {adjustedCarData}");
// Console.WriteLine($"Car Data: {adjustedCarData.ToLower()}");

// Console.WriteLine($"{number1} == {number2}, {number1 == number2}");
// number2 = 50;
// Console.WriteLine($"{number1} <= {number2}, {number1 <= number2}");
// Console.WriteLine($"{number1} >= {number2}, {number1 >= number2}");
// Console.WriteLine($"{number1} != {number2}, {number1 != number2}");
// Console.WriteLine($"{number1} < {number2}, {number1 <   number2}");
// Console.WriteLine($"{number1} > {number2}, {number1 > number2}");

// bool isFord = carData.Contains("ford", StringComparison.OrdinalIgnoreCase);
// bool isFord2 = carData.ToUpper().Contains("FORD");
// Console.WriteLine($"Is a Ford: {isFord}");
// Console.WriteLine($"Is a Ford: {isFord2}");

// var startsWith1 = carData.StartsWith("1"); //cars from the 1900's only
// var startswith2 = carData.StartsWith("2"); //cars from the 2000's only
// Console.WriteLine($"Is a 1900s car: {startsWith1}");
// Console.WriteLine($"Is a 2000s car: {startswith2}");

// var hasPositionalDataGT = carData.LastIndexOf('n') >= 15; //contains an n after position 15
// var hasPositionalDataLT = carData.LastIndexOf('o') < 15; //contains no o's after position 14
// Console.WriteLine($"Has an 'n' at position 15 or after position 15: {hasPositionalDataGT}");
// Console.WriteLine($"Does not have an 'o' after position 14: {hasPositionalDataLT}");

// var anotherCar = carData;
// var yetAnotherCar = carData.Replace("Ford", "Chevy");
// var isSameCar = anotherCar.Equals(carData);
// var isSameCar2 = yetAnotherCar.Equals(carData);
// Console.WriteLine($"anotherCar is equal to carData: {isSameCar}");
// Console.WriteLine($"yetAnotherCar is equal to carData: {isSameCar2}");

// bool isHungry = true;
// bool haveMoney = false;
// bool haveGiftCard = true;
// var isTired = true;
// var haveToWork = true;

// var getTakeout = isHungry && haveMoney;
// Console.WriteLine($"Should Get Takeout: {getTakeout}");

// var sleeping = isTired && !haveToWork;
// Console.WriteLine($"Are you sleeping: {sleeping}");

// getTakeout = isHungry && (haveMoney || haveGiftCard);
// Console.WriteLine($"Should Get Takeout: {getTakeout}");

string string1 = null;
var string2 = string.Empty;
var string3 = "  ";
Console.WriteLine($"string1: {string1}");
Console.WriteLine($"string2: {string2}");
Console.WriteLine($"string3: {string3}");

// Console.WriteLine($"string1.Length: {string1.Length}");
Console.WriteLine($"string2.Length: {string2.Length}");
Console.WriteLine($"string3.Length: {string3.Length}");

Console.WriteLine($"string 1 null or whitespace: {string.IsNullOrWhiteSpace(string1)}");
Console.WriteLine($"string 2 null or whitespace: {string.IsNullOrWhiteSpace(string2)}");
Console.WriteLine($"string 3 null or whitespace: {string.IsNullOrWhiteSpace(string3)}");
