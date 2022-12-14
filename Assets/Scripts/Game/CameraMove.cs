using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Camera @object;
    public float speed = 0.5F;
    private void Start()
    {
        @object = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            @object.transform.position = new Vector3(@object.transform.position.x+Input.GetAxis("Horizontal")*speed, @object.transform.position.y, -10);
        }
        if (Input.GetAxis("Vertical") != 0)
        {
            @object.transform.position = new Vector3(@object.transform.position.x, @object.transform.position.y + Input.GetAxis("Vertical")*speed, -10);
        }
    }
}
