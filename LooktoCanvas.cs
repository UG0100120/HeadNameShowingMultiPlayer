using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooktoCanvas : MonoBehaviour
{
    private Transform cameraTransform;
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.LookAt(transform.position + cameraTransform.rotation * Vector3.forward, cameraTransform.rotation * Vector3.up);
    }
}
