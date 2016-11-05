using UnityEngine;
using System.Collections;

public class SpotlightTrigger : MonoBehaviour {

    GameObject ball1, ball2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other) {

        if(other.tag == "Ball1")
        {
            ball1 = GameObject.FindGameObjectWithTag("Ball1");
            Renderer ball1Rend = ball1.GetComponent<Renderer>();
            ball1Rend.material.SetColor("_Color", Color.red);
        }

        if (other.tag == "Ball2")
        {
            ball2 = GameObject.FindGameObjectWithTag("Ball2");
            Renderer ball2Rend = ball2.GetComponent<Renderer>();
            ball2Rend.material.SetColor("_Color", Color.red);
        }

    }
}
