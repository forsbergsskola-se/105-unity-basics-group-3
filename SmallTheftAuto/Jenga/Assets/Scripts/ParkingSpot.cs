using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpot : MonoBehaviour
{
    public bool hasCar;
    public Vehicle carPrefab;
    public GameObject player;
    void Start()
    {
        if (hasCar == true)
        {
            Vehicle car = Instantiate(carPrefab);
            car.transform.position = transform.position;
            car.player = player;
        }
        
    }

    void Update()
    {
        
    }
}
