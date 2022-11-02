using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float Speed = 5f;

public float TurnSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(0f, 0f,  verticalInput * Speed * Time.deltaTime);
        transform.Rotate(0f, horizontalInput * TurnSpeed * Time.deltaTime, 0f );
    }
}
