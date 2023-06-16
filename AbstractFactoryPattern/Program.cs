// 使用 Windows 工廠
IGUIFactory windowsFactory = new WindowsGUIFactory();
Client windowsClient = new Client(windowsFactory);
windowsClient.RenderUI();

Console.WriteLine();

// 使用 MacOS 工廠
IGUIFactory macosFactory = new MacOSGUIFactory();
Client macosClient = new Client(macosFactory);
macosClient.RenderUI();