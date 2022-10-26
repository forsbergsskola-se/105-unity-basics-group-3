using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Brick : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float minRandomOffset = -0.05f;
    public float maxRandomOffset = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += transform.right * Random.Range(minRandomOffset, maxRandomOffset);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody>().isKinematic = true;
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

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
