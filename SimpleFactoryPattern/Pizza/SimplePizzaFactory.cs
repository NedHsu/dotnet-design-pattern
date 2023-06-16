// 簡單披薩工廠
public class SimplePizzaFactory {
    public Pizza CreatePizza(string type) {
        Pizza pizza = null;

        // 根據口味創建相應的披薩
        switch (type) {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "mushroom":
                pizza = new MushroomPizza();
                break;
            case "pepperoni":
                pizza = new PepperoniPizza();
                break;
            default:
                // 如果口味不匹配，可以在這裡執行一些預設的處理邏輯，如創建一個預設的披薩或拋出異常等
                break;
        }

        return pizza;
    }
}