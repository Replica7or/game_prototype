using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mutant_AI : MonoBehaviour {

    public GameObject player;
    public float dist;
    NavMeshAgent nav;
    public float MinDist;
    Animator MutantAnim;

    public int Health = 100;

	// Use this for initialization
	void Start () {
        nav = GetComponent<NavMeshAgent>();
        MutantAnim = GetComponent<Animator>();
        MinDist = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > MinDist)
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            MutantAnim.SetTrigger("MutantRun");
            print("checked");
        }
        else
        {
            nav.enabled = false;
            if (!MutantAnim.GetCurrentAnimatorStateInfo(0).IsName("FlyingPunch"))
            {
                transform.LookAt(player.transform.position);
            }
            MutantAnim.SetTrigger("MutantIdle");
            
            if(MutantAnim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                MutantAnim.SetTrigger("MutantPunch");
            }
        }
    }
}
