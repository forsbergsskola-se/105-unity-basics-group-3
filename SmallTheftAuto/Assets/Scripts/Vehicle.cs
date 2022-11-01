using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
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

    void Update()
    {
        EnterCarButtonPressed();
    }

    void EnterCarButtonPressed()
    {

        if (Vector3.Distance(car.transform.position, player.transform.position) < 2)
        {
            if (Input.GetKey(KeyCode.F))
            {
                if (Vector3.Distance(car.transform.position, player.transform.position) < 2)
                {
                    if (PlayerIsInCar())
                        // Already in Car, so get out of car
                        LeaveCar();
                    else
                        // Not in Car, get in
                        EnterCar();
                }
            }
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
}


