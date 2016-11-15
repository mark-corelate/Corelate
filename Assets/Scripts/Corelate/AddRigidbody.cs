using UnityEngine;
using System.Collections;

public class AddRigidbody : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Rigidbody")
        {
            RigidbodyNoGravity.turnOnRB = true;
        }
    }
}
