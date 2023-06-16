
// 角色工廠
public class CharacterFactory
{
    private Dictionary<string, ICharacter> characters = new Dictionary<string, ICharacter>();

    public ICharacter GetCharacter(string characterType, string name, int level)
    {
        // 檢查角色是否已存在，如果存在則返回該角色
        if (characters.ContainsKey(characterType))
        {
            return characters[characterType];
        }
        else
        {
            // 如果角色不存在，則根據角色類型創建一個新角色並將其添加到字典中
            ICharacter character;
            switch (characterType)
            {
                case "Warrior":
                    character = new Warrior(name, level);
                    break;
                case "Mage":
                    character = new Mage(name, level);
                    break;
                default:
                    throw new ArgumentException($"Invalid character type: {characterType}");
            }
            characters.Add(characterType, character);
            return character;
        }
    }
}
