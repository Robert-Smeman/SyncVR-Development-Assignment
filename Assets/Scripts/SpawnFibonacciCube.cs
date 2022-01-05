using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFibonacciCube : MonoBehaviour
{
    public Transform cubePrefab;

    //Using long because it can store bigger numbers than int
    public  long number1 = 0;
    public long number2 = 1;
    public  long next_number = 0;

    public void SpawnCube()
    {
        number1 = number2;
        number2 = next_number;
        next_number = number1 + number2;
        
        //Spawns amount of cubes based on what number next_number is
        for (int i = 0; i < next_number; i++)
        {
            Instantiate(cubePrefab, new Vector3(16, i * 2.0F, 10), Quaternion.identity);
        }
    }
}
