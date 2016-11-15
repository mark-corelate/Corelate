using UnityEngine;
using System.Collections;

public class CameraMovement_OneBall : MonoBehaviour {

    public Transform ball1;

    float z;
    float x;

    public float distanceCamZ = 16f;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        z = ball1.position.z - distanceCamZ;
        x = ball1.position.x;

        transform.position = new Vector3(x, transform.position.y, z);

    }
}
