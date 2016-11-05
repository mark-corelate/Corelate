using UnityEngine;
using System.Collections;

public class FogColour : MonoBehaviour {

    public Color colour;

	// Use this for initialization
	void Start () {
        
        RenderSettings.fog = true;

    }
	
	// Update is called once per frame
	void Update () {

        RenderSettings.fogColor = colour;

    }
}
