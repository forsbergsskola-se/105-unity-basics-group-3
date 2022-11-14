//Handle F key to enter / exit car and other interactions
using UnityEngine;

public class FKeyPress : MonoBehaviour
{
    public GameObject player;
    public GameObject car;
    public CarMovement carMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void CarInteraction()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (PlayerIsInCar()) // Already in Car, so get out of car
                LeaveCar();
            else // Not in Car, get in
            if (inRange)
                EnterCar();
        }

        bool PlayerIsInCar()
        {
            if (player.activeInHierarchy)
            {
                return false;
            }

            return true;
        }

        void EnterCar()
        {
            player.SetActive(false);
            carMovement.enabled = true;
        }

        void LeaveCar()
        {
            player.SetActive(true);
            player.transform.position = car.transform.position + new Vector3(2,0,0);
            carMovement.enabled = false;
        }
    }*/
}
