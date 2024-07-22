using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject TruckPrefab1;
    [SerializeField] private GameObject TruckPrefab2;

    public const int TRUCK_TYPE_1 = 0;
    public const int TRUCK_TYPE_2 = 1;
    
    
    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case TRUCK_TYPE_1:
                var truck1 = Instantiate(TruckPrefab1);
                truck1.transform.position = position;
                return new Truck1();
            case TRUCK_TYPE_2:
                var truck2 = Instantiate(TruckPrefab2);
                truck2.transform.position = position;
                return new Truck2();
        }

        return null;
    }
    
}

public class Truck1 : IProduct
{
    string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Truck1";
    }
}

public class Truck2 : IProduct
{
    string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Truck2";
    }
}
