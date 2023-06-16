// 創建汽車
Engine gasolineEngine = new GasolineEngine();
Car sedan = new Sedan(gasolineEngine);
Car suv = new SUV(gasolineEngine);

Engine electricEngine = new ElectricEngine();
Car sedan2 = new Sedan(electricEngine);
Car suv2 = new SUV(electricEngine);

// 駕駛汽車
sedan.Drive();
suv.Drive();

sedan2.Drive();
suv2.Drive();