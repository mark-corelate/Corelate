using UnityEngine;
using System.Collections;

public class FixTransform_Z : MonoBehaviour {

    Vector3 startPosition;

	// Use this for initialization
	void Start () {

        startPosition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x, transform.position.y, startPosition.z);
	
	}
}
