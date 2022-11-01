using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Parkingspot : MonoBehaviour
{
    public bool hasCar;
    public GameObject carPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        if (hasCar == true)
        {
            Instantiate(carPrefab, transform.position, quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
