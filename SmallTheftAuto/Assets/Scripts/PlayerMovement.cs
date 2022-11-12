using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 inputVector = new Vector2(0, 0);

    private Rigidbody rb;
    //private PlayerControls _playerControls;

    [SerializeField] private float turnSpeed = 150;

    [SerializeField] private float speed = 200;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Moving(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
        Debug.Log("X: " + inputVector.x.ToString() + " Z: " + inputVector.y.ToString());
    }

    private void FixedUpdate()
    {
        rb.velocity = transform.forward * (inputVector.y * speed * Time.deltaTime);
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