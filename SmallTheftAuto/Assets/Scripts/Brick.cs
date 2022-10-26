using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.position + (transform.right * Random.Range(-0.1f, 0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
