using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    
    public CarMovement carMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

     

    public void EnterCar()
    {
        Debug.Log("EnteredCar");
        player.SetActive(false);
        carMovement.enabled = true;
        
    }
    

    public void LeaveCar()
    {
        Debug.Log("LeftCar");
        carMovement.transform.position = player.transform.position;
        player.SetActive(true);
        carMovement.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 Distance = carMovement.transform.position - player.transform.position;
        if (Input.GetKeyDown(KeyCode.F) && Distance.magnitude < 2)
        {
            if(player.activeInHierarchy )
            {
                EnterCar();
            }
            else
            {
                LeaveCar();
            }
        }
    }
}
