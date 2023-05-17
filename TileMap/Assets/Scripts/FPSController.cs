using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour
{
    private Vector3 angle;
    private bool isClick;
    private Vector3 defaultangle;
    private int anglespeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        angle = this.gameObject.transform.localEulerAngles;
        defaultangle = angle;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isClick = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isClick= false;

            angle = defaultangle;
            this.gameObject.transform.localEulerAngles = angle;
        }

        if(isClick)
        {
            angle.y += Input.GetAxis("Mouse X") * anglespeed;
            angle.x -= Input.GetAxis("Mouse Y") * anglespeed;

            this.gameObject.transform.localEulerAngles = angle;
        }
    }
}
