using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 150;

    public float verticalPower = 20;

    void Start()
    {
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * verticalPower * Time.deltaTime;
        transform.Translate(0, translation, 0);

        float rotation = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -rotation);
    }

    private void OnDisable()
    {
        Debug.Log("I got disabled.");
    }
}