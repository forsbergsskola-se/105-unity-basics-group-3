using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 150;

    public float verticalPower = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
void Update()
{
    // only, if the W-Key is currently pressed...
    /*if (Input.GetKey(KeyCode.W))
    {
        // translate the player's transform-component on the y-axis (which points up)
        transform.Translate(0f, verticalPower * Time.deltaTime, 0f);
    }
    if (Input.GetKey(KeyCode.S))
    {
        // translate the player's transform-component on the y-axis (which points up)
        transform.Translate(0f, -verticalPower * Time.deltaTime, 0f);
    }
    if (Input.GetKey(KeyCode.A))
    {
        transform.Rotate(0f, -turnSpeed * Time.deltaTime, 0f);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Rotate(0f, turnSpeed * Time.deltaTime, 0f);
    }*/
    float translation = Input.GetAxis("Vertical") * verticalPower * Time.deltaTime;
    transform.Translate(0, 0, translation);
    
    float rotation = Input.GetAxis("Horizontal") * turnSpeed  * Time.deltaTime;
    transform.Rotate(0, rotation, 0);
}
}
