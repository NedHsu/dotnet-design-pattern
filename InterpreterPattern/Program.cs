// 使用範例
string expression = "2 + 3 - 4 * 5";
IExpression parsedExpression = ExpressionParser.Parse(expression);
int result = parsedExpression.Interpret();

Console.WriteLine($"Expression: {expression}");
Console.WriteLine($"Result: {result}");
