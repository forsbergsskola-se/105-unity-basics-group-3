using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpot : MonoBehaviour
{
    public GameObject parkingspot;
    public bool hasCar;
    public GameObject carPrefab;
    void Start()
    {
        if (hasCar == true)
        {
            Instantiate(carPrefab);
            carPrefab.transform.position = parkingspot.transform.position;

        }
        
    }

    void Update()
    {
        
    }
}
