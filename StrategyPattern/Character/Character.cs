public class Character
{
    private AttackStrategy attackStrategy;

    public Character(AttackStrategy strategy)
    {
        this.attackStrategy = strategy;
    }

    public void SetAttackStrategy(AttackStrategy strategy)
    {
        this.attackStrategy = strategy;
    }

    public void Attack()
    {
        attackStrategy.Attack();
    }
}
