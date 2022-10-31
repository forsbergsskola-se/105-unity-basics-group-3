using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public GameObject car;
    public CarMovement carMovement;

    private void Start()
    {

    }

    void Awake()
    {
        //player.SetActive(true);
    }
    
    void Update()
    {
        EnterCarButtonPressed();
    }

    bool EnterCarButtonPressed()
    {
        
        if (Vector3.Distance(player.transform.position, car.transform.position) < 2)
        {
            if (Input.GetKey(KeyCode.F))
            {
            if (PlayerIsInCar())
                // Already in Car, so get out of car
                LeaveCar();
            else
                // Not in Car, get in
                EnterCar();
            }
        }
        return true;
}

    bool PlayerIsInCar()
    {
        // active in hierarchy
        if (player.activeInHierarchy)
        {
            return false;
        }
        return true;
    }
    
    void EnterCar()
    {
        Console.WriteLine("Get in Car");
        player.SetActive(false);
        carMovement.enabled = true;
    }
    void LeaveCar()
    {
        Console.WriteLine("Get out of Car");
        player.SetActive(true);
        carMovement.enabled = false;
    }
}
