using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public float enterCarRange = 2;
    private CarMovement carMovement;
    

    private void Update()
    {
        EnterExitCar();
    }

    void EnterExitCar()
    {
        if (EnterCarInput)
        {
            if (IsWithinCarDistance)
            {
                EnterCar();
            }
        }
    }
    
    

    private bool EnterCarInput => Input.GetButtonDown("Interact-Vehicle");

    Transform GetClosestCar()
    {
        Transform closestCar = null;
        CarMovement[] cars = FindObjectsOfType<CarMovement>();
        float minDist = Mathf.Infinity;
        foreach (CarMovement car in cars)
        {
            Transform t = car.transform;
            float dist = Vector3.Distance(t.position, transform.position);
            if (dist < minDist)
            {
                closestCar = t;
                minDist = dist;
            }
        }

        if (closestCar == null)
            return null;
        
        carMovement = closestCar.GetComponent<CarMovement>();
        return closestCar;
        
    }
    
    private bool IsWithinCarDistance => Vector3.Distance(transform.position, GetClosestCar().position) <= enterCarRange;

    void EnterCar()
    {
        transform.position = GetClosestCar().transform.position;
        transform.SetParent(GetClosestCar());
        gameObject.SetActive(false);
        carMovement.enabled = true;
    }

    
}
