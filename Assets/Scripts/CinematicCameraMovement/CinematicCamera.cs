using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class CinematicCamera : MonoBehaviour {

    public Camera mainCamera;
    public Camera cinematicCamera;

    public Transform firstCam;
    public Transform finalCam;

    public float firstCamSpeed = 12f;
    public float secondCamSpeed = 12f;

    bool firstCamMovement = false;
    bool secondCamMovement = false;

    DepthOfFieldDeprecated dof;

    // Use this for initialization
    void Start () {

        StartCoroutine(StartCameraMovement());

        dof = GetComponent<DepthOfFieldDeprecated>();

        mainCamera.enabled = false;
        cinematicCamera.enabled = true;
    
	}
	
	// Update is called once per frame
	void Update () {

        if (firstCamMovement)
        {
            transform.position = Vector3.MoveTowards(transform.position, firstCam.position, Time.deltaTime * firstCamSpeed);
        }

        if(Vector3.Distance(transform.position, firstCam.position) < 0.1)
        {
            StartCoroutine(SecondCameraMovement());
        }

        if (secondCamMovement)
        {
            transform.position = Vector3.MoveTowards(transform.position, finalCam.position, Time.deltaTime * secondCamSpeed);
        }

        if(Vector3.Distance(transform.position, finalCam.position) < 0.1)
        {
            StartCoroutine(SwitchCamera());
        }
	
	}

    IEnumerator StartCameraMovement()
    {

        yield return new WaitForSeconds(2);
        firstCamMovement = true;

    }

    IEnumerator SecondCameraMovement()
    {

        yield return new WaitForSeconds(2);
        firstCamMovement = false;
        secondCamMovement = true;

    }

    IEnumerator SwitchCamera()
    {
        
        yield return new WaitForSeconds(5);
        mainCamera.enabled = true;
        cinematicCamera.enabled = false;

    }
}
