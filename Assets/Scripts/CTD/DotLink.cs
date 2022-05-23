using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotLink : MonoBehaviour
{
    LineRenderer lr;
    public Transform[] dots;

    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.positionCount = dots.Length;

        for (int i = 0; i < dots.Length; i++)
        {
            lr.SetPosition(i, dots[i].position);
        }
    }
}
