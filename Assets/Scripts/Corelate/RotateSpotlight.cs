using UnityEngine;
using System.Collections;

public class RotateSpotlight : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        iTween.RotateTo(gameObject, new Vector3(78, -90, -90), 5);
    }
}
