using UnityEngine;

public class VehicleManager : MonoBehaviour
{
    [SerializeField] private CarFactory carFactory;
    [SerializeField] private SUVFactory suvFactory;
    [SerializeField] private TruckFactory truckFactory;

    private Vector3[] positions = new Vector3[]
    {
        new Vector3(-7, 0, 4),
        new Vector3(0, 0, 4),
        new Vector3(7, 0, 4),
        new Vector3(-7, 0, -4),
        new Vector3(0, 0, -4),
        new Vector3(7, 0, -4)
    };

    private int currentPositionIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CreateVehicle(carFactory, CarFactory.CAR_TYPE_1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CreateVehicle(carFactory, CarFactory.CAR_TYPE_2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CreateVehicle(carFactory, CarFactory.CAR_TYPE_3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CreateVehicle(suvFactory, SUVFactory.SUV_TYPE_1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            CreateVehicle(suvFactory, SUVFactory.SUV_TYPE_2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            CreateVehicle(truckFactory, TruckFactory.TRUCK_TYPE_1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            CreateVehicle(truckFactory, TruckFactory.TRUCK_TYPE_2);
        }
        
    }

    private void CreateVehicle(IFactory factory, int productType)
    {
        if (currentPositionIndex >= positions.Length) return;
        
        Vector3 position = positions[currentPositionIndex];
        factory.GetProduct(productType, position);
        
        currentPositionIndex++;
    }
}