// 解析器
public class ExpressionParser
{
    public static IExpression Parse(string expression)
    {
        // 解析表達式並構建解釋器樹
        // 這裡只示範簡單的加法、減法和數字解釋器
        // 實際應用中可能需要更複雜的解析邏輯

        // 假設表達式為 2 + 3 - 4 * 5
        IExpression number1 = new NumberExpression(2);
        IExpression number2 = new NumberExpression(3);
        IExpression number3 = new NumberExpression(4);
        IExpression number4 = new NumberExpression(5);

        IExpression multiplyExpression = new SubtractExpression(number3, number4);
        IExpression addExpression = new AddExpression(number1, number2);
        IExpression finalExpression = new SubtractExpression(addExpression, multiplyExpression);

        return finalExpression;
    }
}
