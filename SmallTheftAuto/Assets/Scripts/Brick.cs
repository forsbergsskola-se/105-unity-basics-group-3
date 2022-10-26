using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Brick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
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
    public void OnDrag(PointerEventData eventData)
    {
        Plane plane = new Plane(Vector3.up, Vector3.up * eventData.pointerPressRaycast.worldPosition.y);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out float distance))
        {
            transform.position = ray.GetPoint(distance);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
