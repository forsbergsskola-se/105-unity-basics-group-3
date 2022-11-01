using UnityEngine;

public class ParkingSpot : MonoBehaviour
{
    public bool hasCar = false;

    public GameObject carPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (!hasCar)
        {
            Debug.Log("Create car");
            Instantiate(carPrefab, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}