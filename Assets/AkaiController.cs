using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkaiController : MonoBehaviour
{

    public float X;
    public float Y;

    private float Gravity = 0;
    private CharacterController Character;
    private Animator anim;
    private Rigidbody RBody;
    int i = 0;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        RBody = GetComponent<Rigidbody>();
        Character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Roll");
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("Bow");
        }

        if (Input.GetMouseButtonDown(0))
        {
            i++;
            if (i == 1)
                anim.SetTrigger("MMA_Foot_Attack");
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("MMA_360Foot"))
        {
            i = 0;
        }

        Y = Input.GetAxis("Horizontal");
        X = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
            X = 1;
        anim.SetFloat("Speed", X, 0.1f, Time.deltaTime);
        anim.SetFloat("Direction", Y, 0.1f, Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {

    }
    private void OnCollisionExit(Collision collision)
    {
    }

    private void FixedUpdate()
    {

    }
}
