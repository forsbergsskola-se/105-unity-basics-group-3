using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float turnSpeed = 150;

    [SerializeField] private float speed = 200;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(0,0 , translation);
    
        float rotation = Input.GetAxis("Horizontal") * turnSpeed  * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}