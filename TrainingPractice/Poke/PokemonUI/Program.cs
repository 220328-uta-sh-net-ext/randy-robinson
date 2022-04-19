// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* In the following example, the lambda expression x => x * x, which specifies a parameter
 * that's named x and returns the value of x squared, is assigned to a variable of a delegate type: 
 */
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));
// Output:
// 25