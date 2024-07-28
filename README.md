# Unity Vehicle Factory Example

This repository demonstrates a vehicle factory system in Unity. The project utilizes the Factory design pattern to create different types of vehicles (cars, SUVs, and trucks) at specified positions in the scene.

## Project Structure

1. **CarFactory.cs**: Manages the creation of car objects.
2. **SUVFactory.cs**: Manages the creation of SUV objects.
3. **TruckFactory.cs**: Manages the creation of truck objects.
4. **VehicleManager.cs**: Handles user input to create vehicles at specific positions.
5. **IFactory.cs**: Interface for factory classes.
6. **IProduct.cs**: Interface for product classes.
7. **Car1.cs, Car2.cs, Car3.cs**: Concrete implementations of car products.
8. **SUV1.cs, SUV2.cs**: Concrete implementations of SUV products.
9. **Truck1.cs, Truck2.cs**: Concrete implementations of truck products.

## Usage

### Factories
- **CarFactory**: Creates car instances based on the specified type and position.
- **SUVFactory**: Creates SUV instances based on the specified type and position.
- **TruckFactory**: Creates truck instances based on the specified type and position.

### Products
- **Car1, Car2, Car3**: Implement the `IProduct` interface and represent different car models.
- **SUV1, SUV2**: Implement the `IProduct` interface and represent different SUV models.
- **Truck1, Truck2**: Implement the `IProduct` interface and represent different truck models.

### VehicleManager
- **VehicleManager**: Handles input to create vehicles. Press the number keys (1-7) to create vehicles of different types at predefined positions.

## How to Use

1. **Setup**:
   - Ensure you have the required prefabs assigned in the factory scripts.
   - Add the `VehicleManager` script to a GameObject in your scene.
   - Assign the `CarFactory`, `SUVFactory`, and `TruckFactory` to the `VehicleManager`.

2. **Run**:
   - Press the number keys (1-7) to create vehicles:
     - `1, 2, 3`: Create different types of cars.
     - `4, 5`: Create different types of SUVs.
     - `6, 7`: Create different types of trucks.


