using UnityEngine;
using System.Collections;

public class GetDropped : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball1")
        {
            rb.isKinematic = false;
        }
    }
}
