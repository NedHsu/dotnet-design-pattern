// 創建巧克力蛋糕工廠
ICakeFactory chocolateFactory = new ChocolateCakeFactory();
// 使用巧克力蛋糕工廠製作蛋糕
ICake chocolateCake = chocolateFactory.CreateCake();
chocolateCake.Make();

// 創建草莓蛋糕工廠
ICakeFactory strawberryFactory = new StrawberryCakeFactory();
// 使用草莓蛋糕工廠製作蛋糕
ICake strawberryCake = strawberryFactory.CreateCake();
strawberryCake.Make();