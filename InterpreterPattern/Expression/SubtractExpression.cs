// 減法解釋器
public class SubtractExpression : IExpression
{
    private readonly IExpression leftExpression;
    private readonly IExpression rightExpression;

    public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
    {
        this.leftExpression = leftExpression;
        this.rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return leftExpression.Interpret() - rightExpression.Interpret();
    }
}
