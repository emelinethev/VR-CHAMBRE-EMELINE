using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyTintColor : MonoBehaviour
{

    public Material sky;
    public Color color;
    public Color initialColor;

    // Start is called before the first frame update
    void Start()
    {
        color = sky.GetColor("_Tint");
        initialColor = color;
    }

    // Update is called once per frame
    void Update()
    {
        color = color * 0.99f;
        sky.SetColor("_Tint", color);
    }

    void OnDestroy() 
    {
        sky.SetColor("_Tint", initialColor);
    }
}
