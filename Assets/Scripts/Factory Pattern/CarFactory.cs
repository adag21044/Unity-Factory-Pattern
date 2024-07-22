using UnityEngine;

public class CarFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject CarPrefab1;
    [SerializeField] private GameObject CarPrefab2;
    [SerializeField] private GameObject CarPrefab3;
    
    public const int CAR_TYPE_1 = 0;
    public const int CAR_TYPE_2 = 1;
    public const int CAR_TYPE_3 = 2;

    public IProduct GetProduct(int productType, Vector3 position)
    {
        GameObject carInstance = null;
        switch (productType)
        {
            case CAR_TYPE_1:
                carInstance = Instantiate(CarPrefab1, position, Quaternion.identity);
                return new Car1();
            case CAR_TYPE_2:
                carInstance = Instantiate(CarPrefab2, position, Quaternion.identity);
                return new Car2();
            case CAR_TYPE_3:
                carInstance = Instantiate(CarPrefab3, position, Quaternion.identity);
                return new Car3();
        }

        return null;
    }
}

public class Car1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 1";
    }
}

public class Car2 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 2";
    }
}

public class Car3 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 3";
    }
}