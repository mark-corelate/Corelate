using UnityEngine;
using System.Collections;

public class RigidbodyNoGravity : MonoBehaviour {

    Rigidbody rb;

    public static bool turnOnRB = false;

	// Use this for initialization
	void Start () {

        rb = gameObject.GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

        if (turnOnRB)
        {
            rb.isKinematic = false;
        }
	
	}
}
