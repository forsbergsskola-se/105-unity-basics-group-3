using System;
using UnityEngine;

public class CameraRig : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 1.0f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
        
        transform.LookAt(target);
    }
}
