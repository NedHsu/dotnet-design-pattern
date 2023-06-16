// 創建寫作家實例
IWriter writer = new Writer();

// 創建代理編輯實例
IEditor editor = new EditorProxy(writer);

// 透過代理編輯進行作品編輯和寫作
editor.Edit("Hello, world!");