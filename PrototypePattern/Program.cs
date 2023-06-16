// 創建玩具原型
using PrototypePattern.Toy;

IToyPrototype bearToyPrototype = new BearToy();

// 使用原型創建新的玩具實例
IToyPrototype toy1 = bearToyPrototype.Clone();
IToyPrototype toy2 = bearToyPrototype.Clone();

// 操作玩具實例
toy1.Play();
toy2.Play();