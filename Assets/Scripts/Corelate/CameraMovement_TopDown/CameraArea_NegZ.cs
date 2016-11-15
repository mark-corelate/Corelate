using UnityEngine;
using System.Collections;

public class CameraArea_NegZ : MonoBehaviour
{

    public static bool ball1_negZ = false;
    public static bool ball2_negZ = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball1")
        {
            ball1_negZ = true;
        }

        if (other.tag == "Ball2")
        {
            ball2_negZ = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball1")
        {
            ball1_negZ = false;
        }

        if (other.tag == "Ball2")
        {
            ball2_negZ = false;
        }
    }
}
