using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemySimulator")
        {
            print("triggered");
            other.GetComponent<Mutant_AI>().Health -= 20;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
            print("detected");
    }
    
}
