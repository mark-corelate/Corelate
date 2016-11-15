using UnityEngine;
using System.Collections;

public class CameraArea_PosZ : MonoBehaviour
{

    public static bool ball1_posZ = false;
    public static bool ball2_posZ = false;

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
            ball1_posZ = true;
        }

        if (other.tag == "Ball2")
        {
            ball2_posZ = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball1")
        {
            ball1_posZ = false;
        }

        if (other.tag == "Ball2")
        {
            ball2_posZ = false;
        }
    }
}
