using UnityEngine;
using System.Collections;

public class MutantCharacterController : MonoBehaviour {

    float leftJoystickVertical;
    Animator animator;

	// Use this for initialization
	void Start () {

        animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {

        leftJoystickVertical = Input.GetAxis("LeftJoystickVertical");

        animator.SetFloat("Speed", Mathf.Abs(leftJoystickVertical));
	}
}
