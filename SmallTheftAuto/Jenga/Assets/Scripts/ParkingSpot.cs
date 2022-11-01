using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingSpot : MonoBehaviour
{
    public bool hasCar;
    public Vehicle carPrefab;
    public GameObject player;
    public MeshRenderer PlayerBody;
    public MeshRenderer Head;
    public MeshRenderer Eye;
    public MeshRenderer SecondEye;
    void Start()
    {
        if (hasCar == true)
        {
            Vehicle car = Instantiate(carPrefab);
            car.transform.position = transform.position;
            car.player = player;
            car.PlayerBody = PlayerBody;
            car.Head = Head;
            car.Eye = Eye;
            car.SecondEye = SecondEye;
        }
        
    }

    void Update()
    {
        
    }
}
