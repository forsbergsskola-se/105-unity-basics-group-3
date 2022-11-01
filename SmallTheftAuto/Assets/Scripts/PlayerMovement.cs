using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float turnSpeed = 150;

    public float verticalPower = 20;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * verticalPower * Time.deltaTime;
        transform.Translate(0,0 , translation);

        float rotation = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}