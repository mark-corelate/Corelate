using UnityEngine;
using System.Collections;

public class Pulse : MonoBehaviour {

    Material material;
    new Renderer renderer;

    Color emissiveColour;
    Color pulseColour;

    bool fadeToBlack, fadeToPulse;
    bool startPulse = true;

    public float smooth = 0.5f;

	// Use this for initialization
	void Start () {

        renderer = GetComponent<Renderer>();
        material = renderer.material;

        pulseColour = new Color(0f, 0.25f, 0.25f);

        emissiveColour = Color.black;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (startPulse)
        {
            StartCoroutine(PulseEmissive());
            startPulse = false;
        }

        if (fadeToPulse)
        {
            emissiveColour = Color.Lerp(emissiveColour, pulseColour, Time.deltaTime * smooth);
        }

        if (fadeToBlack)
        {
            emissiveColour = Color.Lerp(emissiveColour, Color.black, Time.deltaTime * smooth);
        }

        material.SetColor("_EmissionColor", emissiveColour);

        Debug.Log("Pulse colour: " + fadeToPulse);
        Debug.Log("Black colour: " + fadeToBlack);

    }

    IEnumerator PulseEmissive()
    {
        fadeToPulse = true;
        fadeToBlack = false;
        yield return new WaitForSeconds(2);
        fadeToBlack = true;
        fadeToPulse = false;
        yield return new WaitForSeconds(2);
        startPulse = true;
    }
}
