using UnityEngine;
using System.Collections;

public class TileDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball1" || other.tag == "Ball2")
        {
            Debug.Log("Ball has entered");
            Destroy(GameObject.FindGameObjectWithTag(other.tag));
        }
    }
}
