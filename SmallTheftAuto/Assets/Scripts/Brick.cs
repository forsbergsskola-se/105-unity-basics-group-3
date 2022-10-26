using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

    private Material material;
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0f, 1f), 0.7f, .8f);
        transform.position = transform.position + (transform.right * Random.Range(-.1f, .1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
