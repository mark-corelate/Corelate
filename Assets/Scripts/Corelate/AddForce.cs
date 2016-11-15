using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Time.time < 1)
        {
            rb.AddForce(Vector3.left, ForceMode.Force);
        }
	
	}
}
