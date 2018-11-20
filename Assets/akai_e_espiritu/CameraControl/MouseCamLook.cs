using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamLook : MonoBehaviour
{

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseY = 1,
        MouseX = 2
    }
    public GameObject cam;
    public GameObject DotRotate;
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float rotationX = 0;
    

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            if (axes == RotationAxes.MouseY)
            {

            }
            else
            {
                rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
                rotationX = Mathf.Clamp(rotationX, minimumVert, maximumVert);
                float delta = Input.GetAxis("Mouse X") * sensitivityHor;
                float rotationY = transform.localEulerAngles.y + delta;
                DotRotate.transform.localEulerAngles = new Vector3(rotationX, 0, 0);
            }
        }
    }
}
