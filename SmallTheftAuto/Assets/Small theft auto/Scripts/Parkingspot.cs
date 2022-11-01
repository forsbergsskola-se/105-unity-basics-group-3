using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Parkingspot : MonoBehaviour
{
    public bool hasCar;
    public GameObject carPrefab;
    public float respawnTime = 10f;
    float spawnTimer;
    public LayerMask carLayer;
    private GameObject car;
   
    void Start()
    {
        if (hasCar == true)
        {
            SpawnCar();
        }
    }

    void Update()
    {
        RespawnCar();
    }

    void RespawnCar()
    {
        Collider[] hitColliders = Physics.OverlapBox(transform.position, transform.localScale / 2, quaternion.identity, carLayer);
        if (hitColliders.Length == 0)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= respawnTime)
            {
                SpawnCar();
            }
        }
        else
        {
            spawnTimer = 0;
        }
    }

    void SpawnCar()
    {
        car = Instantiate(carPrefab, transform.position, quaternion.identity);
    }
}
