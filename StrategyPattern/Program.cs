var warrior = new Character(new WarriorAttackStrategy());
warrior.Attack();  // 輸出：使用劍進行近距離攻擊！

var mage = new Character(new MageAttackStrategy());
mage.Attack();  // 輸出：使用法術進行遠距離攻擊！

var archer = new Character(new ArcherAttackStrategy());
archer.Attack();  // 輸出：使用弓箭進行遠距離攻擊！
