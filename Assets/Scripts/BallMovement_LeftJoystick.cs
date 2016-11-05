using UnityEngine;
using System.Collections;

public class BallMovement_LeftJoystick : MonoBehaviour {

    float leftJoystickHorizontal;
    float leftJoystickVertical;

    Rigidbody rb;

    public float speed;
    public float maxSpeed;
    public float ballDamp;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {

        leftJoystickHorizontal = Input.GetAxis("LeftJoystickHorizontal");
        leftJoystickVertical = Input.GetAxis("LeftJoystickVertical");
        
        Vector3 movement = new Vector3(leftJoystickHorizontal, 0.0f, -leftJoystickVertical);

        DeadZone();
        LimitSpeed(maxSpeed);
        
        if (leftJoystickHorizontal == 0 && leftJoystickVertical == 0)
        {
            rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, Time.deltaTime * ballDamp);
        }
        else
        {
            rb.AddForce(movement * speed);
        }

    }

    void DeadZone()
    {
        if (leftJoystickHorizontal < 0.2 && leftJoystickHorizontal > -0.2)
        {
            leftJoystickHorizontal = 0;
        }

        if (leftJoystickVertical < 0.2 && leftJoystickVertical > -0.2)
        {
            leftJoystickVertical = 0;
        }
    }

    void LimitSpeed(float maximumSpeed)
    {
        maximumSpeed = maxSpeed;
        //rb.velocity.magnitude = Mathf.Clamp(rb.velocity.magnitude, 0, maximumSpeed);
    }
}
