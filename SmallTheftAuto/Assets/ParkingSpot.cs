using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpot : MonoBehaviour
{
    public bool hasCar = false;

    public GameObject carPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (hasCar)
        {
            Instantiate(carPrefab, new Vector3(), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
