// 創建具體的汽車建造者
using BuilderPattern.Car;

CarBuilder builder = new ConcreteCarBuilder();

// 創建指揮者並傳入汽車建造者
Director director = new Director(builder);

// 建造汽車
Car car = director.ConstructCar();

// 使用建造好的汽車對象
Console.WriteLine($"Engine Type: {car.EngineType}");
Console.WriteLine($"Color: {car.Color}");
Console.WriteLine($"Tire Size: {car.TireSize}");