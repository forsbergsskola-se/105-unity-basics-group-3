using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CarMovement _carMovement;
    private bool EnterCarInput => Input.GetButtonDown("Interact-Vehicle"); //I know, ugly copy paste code

    void Awake()
    {
        _carMovement = GetComponent<CarMovement>();
    }
    
    void Update()
    {
        Movement();
        
        if (EnterCarInput && IsInCar)
        {
            ExitCar();
        }
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(0f, 0f,  verticalInput * moveSpeed * Time.deltaTime);
                
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f,-100f * Time.deltaTime,0f);
        }
                
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f,100f * Time.deltaTime,0f);
        }
    }
    
    private bool IsInCar
    {
        get
        {
            if (Singleton.Instance.player.activeInHierarchy)
                return false;
            return true;
        }
    }

    void ExitCar()
    {
        Debug.Log("Exit Car");
        Singleton.Instance.player.transform.parent = null;
        Singleton.Instance.player.gameObject.transform.position = transform.position;
        Singleton.Instance.player.gameObject.SetActive(true);
        _carMovement.enabled = false;
    }
}
