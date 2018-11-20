using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    // Use this for initialization
    public enum RotationAxes
    {
        
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public GameObject cam;
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
                transform.Rotate(0, Input.GetAxis("Mouse X")* sensitivityHor, 0);
            
        }
    }
}
