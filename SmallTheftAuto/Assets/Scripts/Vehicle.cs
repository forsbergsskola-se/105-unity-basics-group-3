using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class Vehicle : MonoBehaviour
{
    public GameObject player;

    public CarMovement carMovement;

    private bool EnterCarButtonPressed = false;

    bool PlayerIsInCar = false;

    private bool activeInHierarchy = false;
    // Start is called before the first frame update
    void Start()
    {
        Console.WriteLine("start");
    }
    
    void Update()
    {
        if (player.activeSelf)
        {
            PlayerIsInCar = false;
        }
        var keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.F)
        {
            EnterCarButtonPressed = true;
        }
        if(EnterCarButtonPressed)
        {
            switch (PlayerIsInCar)
            {
                case true: // Aleady in Car, so get out of car
                    LeaveCar();
                    break;
                default: // Not in Car, get in
                    EnterCar();
                    break;
            }
        }
    }
    void EnterCar()
    {
        Console.WriteLine("Get in Car");
        //activeInHierarchy = false;
        player.SetActive(false);
        //carMovement.setActive(true);
    }
    void LeaveCar()
    {
        Console.WriteLine("Get out of Car");
        //activeInHierarchy = true;
        player.SetActive(true);
        //carMovement = setInactive;
    }
}
