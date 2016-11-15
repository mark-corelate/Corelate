using UnityEngine;
using System.Collections;

public class CameraArea_PosX : MonoBehaviour
{

    public static bool ball1_posX = false;
    public static bool ball2_posX = false;

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
            ball1_posX = true;
        }

        if (other.tag == "Ball2")
        {
            ball2_posX = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball1")
        {
            ball1_posX = false;
        }

        if (other.tag == "Ball2")
        {
            ball2_posX = false;
        }
    }
}
