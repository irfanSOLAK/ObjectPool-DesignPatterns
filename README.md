# ObjectPool-DesignPatterns
Object Pool Design Pattern implemented using Unity version 2020.3.35f1.

# Description
This project demonstrates the implementation of the Object Pool design pattern using Unity version 2020.3.35f1. The related scripts for object pooling can be found in the "Scripts/Object Pooling" folder. Additionally, there is a demo scene included that showcases the object pooling implementation. In this scene, a green circle (referred to as a bullet) is created and used using the principles of object pooling.

# How to use
The main script for object pooling is named ObjectPool.cs. This script creates objects from the Bullet.prefab file located in the "Resources/Prefabs" folder. You can modify this script to use a different prefab by assigning a different value to the _objectPrefab variable. Additionally, you can adjust the number of objects in the pool by modifying the _objectsAmountInPool method. This change can impact the resource usage, so it's recommended to find the optimal value through testing and experimentation.

To utilize the object pool, you can use the ObjectSpawner.cs class to retrieve an object from the pool and deassign it when it's no longer needed. Similarly, the ObjectDespawner.cs class handles returning unused bullet game objects to the object pool.

Please note that the code provided should be written in C# syntax for Unity.
