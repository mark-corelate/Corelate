using UnityEngine;
using System.Collections;

public class CameraMovement_Old : MonoBehaviour {

    Rigidbody rb;

    float distance_ball1;
    float distance_ball2;

    float furthestBall;

    bool useBall1 = false;

    float ySum;

    public Transform cameraArea_PosZ;
    public Transform cameraArea_NegZ;

    Vector3 middleVector;

    public Transform ball1;
    public Transform ball2;

    bool getInitialDistance = true;

    float initialDistance;
    float camYPos;
    float camZPos;

    public int camYMovementSpeed;
    public int camZMovementSpeed;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();

        camYPos = transform.position.y;
        camZPos = transform.position.z;

        middleVector = cameraArea_PosZ.position - cameraArea_NegZ.position;

    }
	
	// Update is called once per frame
	void Update () {

        distance_ball1 = Vector3.Distance(ball1.position, middleVector);
        distance_ball2 = Vector3.Distance(ball2.position, middleVector);

        // If either ball occupies the positive Z camera area, move the camera forward on the Z axis
        if (CameraArea_PosZ.ball1_posZ || CameraArea_PosZ.ball2_posZ)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + camZMovementSpeed), Time.deltaTime);
        }

        // If either ball occupies the negative Z camera area, move the camera backwards on the Z axis
        if (CameraArea_NegZ.ball1_negZ || CameraArea_NegZ.ball2_negZ)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z - camZMovementSpeed), Time.deltaTime);
        }

        // If one ball occupies the positive Z camera area and the other the negative Z camera area, zoom the camera out on the Y axis
        if ((CameraArea_PosZ.ball1_posZ || CameraArea_PosZ.ball2_posZ) && (CameraArea_NegZ.ball1_negZ || CameraArea_NegZ.ball2_negZ))
        {
            if (getInitialDistance)
            {
                // Determine which distance is longer and set the initialDistance to that length
                if(distance_ball1 > distance_ball2)
                {
                    useBall1 = true;
                    initialDistance = distance_ball1;
                }
                else if(distance_ball2 > distance_ball1)
                {
                    useBall1 = false;
                    initialDistance = distance_ball2;
                }
                else
                {
                    useBall1 = true;
                    initialDistance = distance_ball1;
                }
                
                getInitialDistance = false;
            }

            if (useBall1)
            {
                furthestBall = distance_ball1;
            }
            else
            {
                furthestBall = distance_ball2;
            }

            ySum = (furthestBall - initialDistance) + camYPos;

            // Move camera on Y axis by the distance of the furthest ball from
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, ySum, transform.position.z), Time.deltaTime * 15);

            Debug.Log(ySum);

            //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y + camYMovementSpeed, transform.position.z), Time.deltaTime);
        }

        // If no balls occupy any of the four camera areas, Lerp to initial camera Y position
        if (!CameraArea_PosZ.ball1_posZ && !CameraArea_NegZ.ball1_negZ && !CameraArea_PosZ.ball2_posZ && !CameraArea_NegZ.ball2_negZ)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, camYPos, transform.position.z), Time.deltaTime * 15);
        }

        //float ySum = (distance_ball1 - initialDistance) + camYPos; // Y sum for distance between balls
        //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, ySum, transform.position.z), Time.deltaTime * 15); // Y pos for distance between balls
        //transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, camYPos, transform.position.z), Time.deltaTime * 15); // Y pos for distance between balls

    }
}
