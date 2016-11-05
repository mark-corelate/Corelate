using UnityEngine;
using System.Collections;

public class CameraArea_NegX : MonoBehaviour {

    public static bool ball1_negX = false;
    public static bool ball2_negX = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "Ball1")
        {
            ball1_negX = true;
        }

        if (other.tag == "Ball2")
        {
            ball2_negX = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball1")
        {
            ball1_negX = false;
        }

        if (other.tag == "Ball2")
        {
            ball2_negX = false;
        }
    }
}
