// 使用範例
TextEditor textEditor = new TextEditor();
MementoManager mementoManager = new MementoManager();

textEditor.SetContent("This is the initial content.");
textEditor.PrintContent();

// 保存備忘錄
Memento initialMemento = textEditor.CreateMemento();
mementoManager.SaveMemento(initialMemento);

// 進行編輯操作
textEditor.SetContent("This is the updated content.");
textEditor.PrintContent();

// 恢復到之前的狀態
Memento restoredMemento = mementoManager.PopMemento();
textEditor.RestoreFromMemento(restoredMemento);
textEditor.PrintContent();
