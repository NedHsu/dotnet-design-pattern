
// 汽車池類別
public class CarPool
{
    private Queue<Car> availableCars;

    public CarPool()
    {
        availableCars = new Queue<Car>();
        // 預先建立一些汽車放入池中
        availableCars.Enqueue(new Car("Toyota", "Camry"));
        availableCars.Enqueue(new Car("Honda", "Civic"));
        availableCars.Enqueue(new Car("Ford", "Mustang"));
    }

    public Car GetCar()
    {
        if (availableCars.Count > 0)
        {
            // 從池中取出一輛汽車
            return availableCars.Dequeue();
        }
        else
        {
            // 池中沒有可用的汽車，可以選擇等待或者返回null或者拋出例外等處理方式
            return null;
        }
    }

    public void ReturnCar(Car car)
    {
        // 將使用完畢的汽車歸還到池中
        availableCars.Enqueue(car);
    }
}
