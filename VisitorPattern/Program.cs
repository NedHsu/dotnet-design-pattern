// 使用範例
Animal lion = new Lion();
Animal tiger = new Tiger();
Animal giraffe = new Giraffe();

IAnimalVisitor operationVisitor = new AnimalOperationVisitor();

lion.Accept(operationVisitor);
tiger.Accept(operationVisitor);
giraffe.Accept(operationVisitor);
