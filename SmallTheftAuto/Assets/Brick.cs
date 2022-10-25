using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public float minRandomOffset = -0.05f;
    public float maxRandomOffset = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += transform.right * Random.Range(minRandomOffset, maxRandomOffset);
    }
}
