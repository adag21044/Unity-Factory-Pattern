using UnityEngine;

public class SUVFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject SUVPrefab1;
    [SerializeField] private GameObject SUVPrefab2;
    public const int SUV_TYPE_1 = 0;
    public const int SUV_TYPE_2 = 1;
    public IProduct GetProduct(int productTye, Vector3 position)
    {
        switch (productTye)
        {
            case SUV_TYPE_1:
                var suv1 = Instantiate(SUVPrefab1);
                suv1.transform.position = position;
                return new SUV1();
            case SUV_TYPE_2:
                var suv2 = Instantiate(SUVPrefab2);
                suv2.transform.position = position;
                return new SUV2();
        }

        return null;
    }
    
}

public class SUV1 : IProduct
{
    string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "SUV 1";
    }
}
public class SUV2 : IProduct
{
    string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "SUV 2";
    }
}