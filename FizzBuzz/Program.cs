

for (int num = 1; num <= 100; num++)
{
    var output = new System.Text.StringBuilder("");
    if (num % 3 == 0) output.Append("Fizz");
    if (num % 5 == 0) output.Append("Buzz");
    if (output.Length == 0) output.Append(num);
    Console.WriteLine(output);
}
