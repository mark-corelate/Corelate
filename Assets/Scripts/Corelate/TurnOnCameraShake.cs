using UnityEngine;
using System.Collections;

public class TurnOnCameraShake : MonoBehaviour {

    public float amplitude = 0.1f;
    public float duration = 0.5f;

    private bool callOnce = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {
        if (callOnce)
        {
            if (other.tag == "Ball1")
            {
                EnableCameraShake();
                callOnce = false;
            }
        }
    }

    void EnableCameraShake()
    {
        CameraShake.Instance.Shake(amplitude, duration);
    }
}
