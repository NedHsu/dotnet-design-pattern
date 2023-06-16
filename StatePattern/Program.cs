// 使用範例
Context context = new Context();
context.Request();  // 輸出: HandleRequest in ConcreteStateA
context.Request();  // 輸出: HandleRequest in ConcreteStateB
context.Request();  // 輸出: HandleRequest in ConcreteStateA
