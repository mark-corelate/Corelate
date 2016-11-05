using UnityEngine;
using System.Collections;

public class ChangeLightTile : MonoBehaviour {

    public GameObject blueTile;
    public GameObject pinkTile;

    public float switchTime = 2.0f;

    bool runSwitchTile = true;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (runSwitchTile)
        {
            StartCoroutine(SwitchTile());
        }
    
	}

    IEnumerator SwitchTile()
    {
        runSwitchTile = false;
        yield return new WaitForSeconds(switchTime);
        blueTile.SetActive(true);
        pinkTile.SetActive(false);
        yield return new WaitForSeconds(switchTime);
        blueTile.SetActive(false);
        pinkTile.SetActive(true);
        runSwitchTile = true;
    }
}
