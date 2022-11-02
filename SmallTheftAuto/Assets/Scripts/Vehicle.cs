using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public MeshRenderer PlayerBody;
    public MeshRenderer Head;
    public MeshRenderer Eye;
    public MeshRenderer SecondEye;
    public CarMovement carMovement;

    // Start is called before the first frame update
    void Start()
    {
    }

   
    public void EnterCar()
    {
        
        player.transform.position = carMovement.transform.position;
        Debug.Log("EnteredCar");
        PlayerBody.enabled = false;
        Head.enabled = false;
        Eye.enabled = false;
        SecondEye.enabled = false;
        player.transform.rotation = carMovement.transform.rotation;
        //transform.rotation = Quaternion.AngleAxis(2, Vector3.forward);
       // player.SetActive(false);
        carMovement.enabled = true;
    }

    public bool isInvisible()
    {
        
        return Head.enabled;
        return Eye.enabled;
        return PlayerBody.enabled;
        return SecondEye.enabled;
    }

    public void LeaveCar()
    {
        Debug.Log("LeftCar");
        carMovement.transform.position = player.transform.position;
        PlayerBody.enabled = true;
        Head.enabled = true;
        Eye.enabled = true;
        SecondEye.enabled = true;
        //player.SetActive(true);
        carMovement.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Distance = carMovement.transform.position - player.transform.position;
        if (Input.GetKeyDown(KeyCode.F) && Distance.magnitude < 2)
        {
           /* if (player.activeInHierarchy)
            {
                EnterCar();
            }*/
           if (isInvisible())
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