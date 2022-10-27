using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ViewMove();
    }

    public void ViewMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, -0.01f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-0.01f, 0f, 0f);
        }
    }
}