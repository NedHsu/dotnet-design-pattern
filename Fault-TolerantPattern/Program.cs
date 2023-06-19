// 創建具體的操作實例
IFaultTolerantOperation operation = new MyOperation();

// 使用容錯處理的代理執行操作
IFaultTolerantOperation faultTolerantOperation = new FaultTolerantProxy(operation);
faultTolerantOperation.Execute();