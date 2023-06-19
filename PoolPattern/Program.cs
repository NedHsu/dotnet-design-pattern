// 使用範例
CarPool carPool = new CarPool();

// 租借一輛汽車
Car car1 = carPool.GetCar();
car1.Drive(); // 輸出：Driving Toyota Camry

// 租借另一輛汽車
Car car2 = carPool.GetCar();
car2.Drive(); // 輸出：Driving Honda Civic

// 將使用完畢的汽車歸還到池中
carPool.ReturnCar(car1);

// 再次租借一輛汽車
Car car3 = carPool.GetCar();
car3.Drive(); // 輸出：Driving Toyota Camry
