using FizzBuzz;
using FizzBuzz.Transforms;

var fizzBuzz = new FizzBuzzer(new FizzTransform(), new BuzzTransform());

for (var i = 0; i <= 100; i++)
{
    Console.WriteLine(fizzBuzz.Do(i));
}

Console.WriteLine();

var fizzyBuzzy = new FizzBuzzer(new FizzyTransform(), new BuzzyTransform());

for (var i = 0; i <= 100; i++)
{
    Console.WriteLine(fizzyBuzzy.Do(i));
}