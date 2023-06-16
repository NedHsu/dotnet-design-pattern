
// 使用範例
public class Game
{
    private CharacterFactory characterFactory = new CharacterFactory();

    public void CreateCharacter(string characterType, string name, int level)
    {
        // 從角色工廠獲取角色物件
        ICharacter character = characterFactory.GetCharacter(characterType, name, level);

        // 創建角色並加入遊戲
        // ...
    }
}
