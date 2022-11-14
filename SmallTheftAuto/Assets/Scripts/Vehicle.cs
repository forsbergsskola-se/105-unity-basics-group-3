using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public GameObject player;
    public GameObject car;
    public CarMovement carMovement;
    public bool inRange = false;

    void Update()
    {
        EnterCarButtonPressed();
        /*if (Vector3.Distance(car.transform.position, player.transform.position) < 2)
        {
            inRange = true;
        }
        bool PlayerIsInCar()
        {
            if (player.activeInHierarchy)
            {
                return false;
            }

            return true;
        }*/
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void EnterCarButtonPressed()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (PlayerIsInCar()) // Already in Car, so get out of car
                    LeaveCar();
            else // Not in Car, get in
                if (Vector3.Distance(car.transform.position, player.transform.position) < 2)
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
    }
}


