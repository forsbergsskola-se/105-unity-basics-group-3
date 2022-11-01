using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Awake()
    {
        _player = FindObjectOfType<PlayerMovement>();
        _carMovement = GetComponent<CarMovement>();
    }

    // Update is called once per frame
    void Update()
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
        
        if (EnterCarInput && IsInCar)
        {
            ExitCar();
        }
    }
    
    private PlayerMovement _player;
    private CarMovement _carMovement;
    private bool EnterCarInput => Input.GetButtonDown("Interact-Vehicle"); //I know, ugly copy paste code
    
    

    private bool IsInCar
    {
        get
        {
            if (_player.gameObject.activeInHierarchy)
                return false;
            return true;
        }
    }

    void ExitCar()
    {
        _player.transform.parent = null;
        _player.gameObject.transform.position = transform.position;
        _player.gameObject.SetActive(true);
        _carMovement.enabled = false;
    }
}
