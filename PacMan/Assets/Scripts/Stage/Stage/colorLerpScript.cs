using UnityEngine;
using System.Collections;

public class colorLerpScript : MonoBehaviour {

    GameObject floor;

    private int arrayCounter = 0;
    private Color[] availableColors;
    private Color lerpedColor;
    public float lerpDuration = 2.0f;     // this changes how fast the interpolation takes in seconds(?). try changing the nuber in the inspector.
    private float lerpControlVar = 0.0f;  // these two floats makes it possible to loop interpolations

    // Use this for initialization
    void Start ()
    {
        floor = GameObject.Find("FloorSprite");
        availableColors = new Color[7];   // creates the color array
        availableColors[0] = new Vector4(0.2f, 0.2f, 0.2f);
        availableColors[1] = new Vector4(0, 0.1f, 0, 0.1F);
        availableColors[2] = new Vector4(0, 0.5f, 0, 0.2F);
        availableColors[3] = new Vector4(0, 0.7F, 0, 0.5F);
        availableColors[4] = new Vector4(0, 0.5f, 0, 0.2F);
        availableColors[5] = new Vector4(0, 0.1f, 0, 0.15F);
        availableColors[6] = new Vector4(0.2f, 0.2f, 0.2f);


    }
	
	// Update is called once per frame
	void Update ()
    {
        Color colorOne = availableColors[arrayCounter];     // assigns the colors
        Color colorTwo = availableColors[arrayCounter + 1];     

        lerpedColor = Color.Lerp(colorOne, colorTwo, lerpControlVar); // interpolates the color
        floor.GetComponent<SpriteRenderer>().color = lerpedColor; // sets the color to the sprite

        if (lerpControlVar < 1)
        {
            lerpControlVar += Time.deltaTime / lerpDuration;        // changes the speed of the interpolation
        }
     
        if (lerpControlVar > 1)                                     // tells the interpolation to start again when it´s done
        {
            lerpControlVar = 0;
            arrayCounter = arrayCounter + 1;
        }

        if (arrayCounter == availableColors.Length - 1)             // stops the Array index from getting out of range
        {
            arrayCounter = 0;
        }
    }
}
