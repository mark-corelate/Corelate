using UnityEngine;
using System.Collections;

public class CameraMovement_TwoBalls : MonoBehaviour {

    public Transform ball1;
    public Transform ball2;

    float z;
    float x;

    public float distanceCamZ = 16f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(GameObject.Find("Ball_1") != null && GameObject.Find("Ball_2") != null)
        {
            #region Calculate middle point on z axis between two balls
            if (ball1.position.z > ball2.position.z)
            {
                z = (ball1.position.z - ((ball1.position.z - ball2.position.z) / 2)) - distanceCamZ;
            }
            else if (ball2.position.z > ball1.position.z)
            {
                z = (ball2.position.z - ((ball2.position.z - ball1.position.z) / 2)) - distanceCamZ;
            }
            else
            {
                z = ball1.position.z - distanceCamZ;
            }
            #endregion

            #region Calculate middle point on x axis between two balls
            if (ball1.position.x > ball2.position.x)
            {
                x = (ball1.position.x - ((ball1.position.x - ball2.position.x) / 2));
            }
            else if (ball2.position.x > ball1.position.x)
            {
                x = (ball2.position.x - ((ball2.position.x - ball1.position.x) / 2));
            }
            else
            {
                x = ball1.position.x;
            }
            #endregion

            //transform.position = Vector3.Lerp(transform.position, new Vector3(x, transform.position.y, z), Time.deltaTime);
            transform.position = new Vector3(x, transform.position.y, z);
        }

        if (GameObject.Find("Ball_1") == null || GameObject.Find("Ball_2") == null)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
