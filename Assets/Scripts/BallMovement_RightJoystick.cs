using UnityEngine;
using System.Collections;

public class BallMovement_RightJoystick : MonoBehaviour {

    float rightJoystickHorizontal;
    float rightJoystickVertical;

    Rigidbody rb;

    public float speed;

    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

        rightJoystickHorizontal = Input.GetAxis("RightJoystickHorizontal");
        rightJoystickVertical = Input.GetAxis("RightJoystickVertical");

        Vector3 movement = new Vector3(rightJoystickHorizontal, 0.0f, -rightJoystickVertical);

        rb.AddForce(movement * speed);

    }
}
