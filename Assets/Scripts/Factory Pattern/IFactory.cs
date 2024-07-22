using UnityEngine;

public interface IFactory
{
    IProduct GetProduct(int productType, Vector3 position);
}