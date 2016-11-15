using UnityEngine;
using System.Collections;

public class Emissive : MonoBehaviour {

    Material material;
    new Renderer renderer;
    Color emissiveColour;

    bool emissive = false;

    public float smooth = 2;

    public Color targetColour;

    // Use this for initialization
    void Start () {

        renderer = GetComponent<Renderer>();
        material = renderer.material;

        emissiveColour = Color.black;

    }
	
	// Update is called once per frame
	void Update () {

        if (emissive)
        {
            emissiveColour = Color.Lerp(emissiveColour, targetColour, Time.deltaTime * smooth);
            material.SetColor("_EmissionColor", emissiveColour);
        }
        else
        {
            emissiveColour = Color.Lerp(emissiveColour, Color.black, Time.deltaTime * smooth);
            material.SetColor("_EmissionColor", emissiveColour);
        }
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ball1")
        {
            emissive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball1")
        {
            emissive = false;
        }
    }
}
