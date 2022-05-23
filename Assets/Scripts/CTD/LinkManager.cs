using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkManager : MonoBehaviour
{
    public DotLink linkPrefab;
    Transform firstDot;

    void Start()
    {
        if (linkPrefab == null)
        {
            Debug.Break();
            throw new System.Exception("Heeeey, t'as oublié le prefab DotLink!!!");
        }
    }

    void LinkDots(Transform dot1, Transform dot2)
    {
        // GameObject go = new GameObject("link");
        // go.AddComponent<LineRenderer>();
        // DotLink dotLink = go.AddComponent<DotLink>();
        DotLink dotLink = Instantiate(linkPrefab);
        dotLink.dots = new Transform[] { dot1, dot2 };
    }

    public void DotOnClick(Transform dot)
    {
        if (firstDot == null)
        {
            firstDot = dot;
        }
        else
        {
            if (firstDot != dot)
            {
                LinkDots(firstDot, dot);
            }

            firstDot = dot;
        }
    }
}
