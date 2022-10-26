using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public float Speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(0f, verticalInput * Speed * Time.deltaTime,  0f);
        

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f,-100f * Time.deltaTime,0f);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,100f * Time.deltaTime,0f);
        }
    }
}
