using UnityEngine;
using System.Collections;

public class ChangeLightTileColour : MonoBehaviour
{

    Material material;
    new Renderer renderer;
    Color alternatingColour;

    float r, g, b;

    bool colourChange = false;
    bool switchOn = true;

    public float time = 2;

    // Use this for initialization
    void Start()
    {

        renderer = GetComponent<Renderer>();
        material = renderer.material;

        StartCoroutine(Switch());

    }

    // Update is called once per frame
    void Update()
    {
        
        if (!colourChange)
        {
            r = 9 / 255;
            g = 184 / 255;
            b = 119 / 255;
        }

        if (colourChange)
        {
            r = 186 / 255;
            g = 59 / 255;
            b = 117 / 255;
        }

        alternatingColour.r = r;
        alternatingColour.g = g;
        alternatingColour.b = b;
        alternatingColour.a = material.color.a;

        material.SetColor("_MainColor", alternatingColour);

        Debug.Log(colourChange);
        Debug.Log(r + " " + g + " " + b);
    }

    IEnumerator Switch()
    {
        yield return new WaitForSeconds(time);
        colourChange = true;
        yield return new WaitForSeconds(time);
        colourChange = false;
    }
}
