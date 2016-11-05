using UnityEngine;
using System.Collections;

public class ChangeMaterialColour : MonoBehaviour {

    Material material;
    new Renderer renderer;
    Color alternatingColour;

    float r = 9;
    float g = 184;
    float b = 119;

    float maxValueR = 186;
    float maxValueG = 184;
    float maxValueB = 177;

    float minValueR = 9;
    float minValueG = 59;
    float minValueB = 119;

    public float time = 2;

    bool top = false;
    bool bottom = false;

    // Use this for initialization
    void Start () {

        renderer = GetComponent<Renderer>();
        material = renderer.material;

    }
	
	// Update is called once per frame
	void Update () {

        #region Change R value

        if (r > maxValueR - 1)
        {
            top = true;
            bottom = false;
        }

        if (top)
        {
            r = Mathf.Lerp(r, minValueR, Time.deltaTime * time);
        }
        
        if (r < minValueR + 1)
        {
            bottom = true;
            top = false;
        }

        if (bottom)
        {
            r = Mathf.Lerp(r, maxValueR, Time.deltaTime * time);
        }

        #endregion

        #region Change G value

        if (g > maxValueG - 1)
        {
            top = true;
            bottom = false;
        }

        if (top)
        {
            g = Mathf.Lerp(g, minValueG, Time.deltaTime * time);
        }

        if (g < minValueG + 1)
        {
            bottom = true;
            top = false;
        }

        if (bottom)
        {
            g = Mathf.Lerp(g, maxValueG, Time.deltaTime * time);
        }

        #endregion

        #region Change B value

        if (b > maxValueB - 1)
        {
            top = true;
            bottom = false;
        }

        if (top)
        {
            b = Mathf.Lerp(b, minValueB, Time.deltaTime * time);
        }

        if (b < minValueB + 1)
        {
            bottom = true;
            top = false;
        }

        if (bottom)
        {
            b = Mathf.Lerp(b, maxValueB, Time.deltaTime * time);
        }

        #endregion

        Debug.Log("R: " + r + " G: " + g + " B: " + b);

        alternatingColour.r = r / 255;
        alternatingColour.g = g / 255;
        alternatingColour.b = b / 255;
        alternatingColour.a = material.color.a;

        material.SetColor("_Color", alternatingColour);

    }
}
