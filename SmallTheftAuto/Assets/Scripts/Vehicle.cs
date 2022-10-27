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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        var keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.F)
        {
            EnterCarButtonPressed = true;
        }
        if(EnterCarButtonPressed)
        {
            Console.WriteLine("Enter Car");
            /*if(PlayerIsInCar()) {
                LeaveCar();
            } else {
                EnterCar();
            }*/
        }
    }
/*
    // Update is called once per frame
    void Update()
    {
        if (Console.ReadKey(Convert.ToBoolean("F"))) //check, whether the F key is being Pressed.
        {
            if (player is isActiveInHierarchy) //check, whether the player-GameObject's isActiveInHierarchy-Property is true
            {
                player SetActive = false; // Set the player-GameObject inactive by invoking its SetActive method with the value false
                carMovement SetActive = true; //Set the carMovement-Field's enabled-Property to true to enable Car Controls.
            }
            else //If false, then the player is currently in the Vehicle and we should let him "Exit"
            {
                player SetActive = true; //Set the player-GameObject active by invoking its SetActive method with the value true to Show the Player.
                carMovement SetActive = false; // Set the carMovement-Field's enabled-Property to false to disable Car Controls.
            }
        }
    }

    private static readonly object isActiveInHierarchy = true;*/
}
