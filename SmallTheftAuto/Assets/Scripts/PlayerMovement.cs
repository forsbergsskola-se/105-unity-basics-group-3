using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //private PlayerControls _playerControls;
    
    //[SerializeField] private float turnSpeed = 150;

    //[SerializeField] private float verticalPower = 20;

    public void OnMovement(InputValue value)
    {
        Debug.Log("Works");
    }

    /*private void Awake()
    {
        _playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
        //_playerControls.PlayerActions.WASD.performed += WASD;
    }

    private void OnDisable()
    {
        _playerControls.Disable();
        //_playerControls.PlayerActions.WASD.performed -= WASD;
    }

    private void FixedUpdate()
    {
        float movement = _playerControls.PlayerActions.WASD.ReadValue<float>();
        Vector3 currentPosition = transform.position;
        currentPosition.x = movement * verticalPower * Time.deltaTime;
        currentPosition.z = movement * verticalPower * Time.deltaTime;
        transform.position = currentPosition;
    }*/

    /*void Update()
    {
        float translation = Input.GetAxis("Vertical") * verticalPower * Time.deltaTime;
        transform.Translate(0,0 , translation);
    
        float rotation = Input.GetAxis("Horizontal") * turnSpeed  * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }*/
}