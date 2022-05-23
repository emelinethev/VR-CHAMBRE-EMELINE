using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRDotTarget : MonoBehaviour
{
    void Start()
    {
        var interactable = GetComponent<XRSimpleInteractable>();
        
        interactable.activated.AddListener(e => {
            var linkManager = FindObjectOfType<LinkManager>();
            linkManager.DotOnClick(transform);
        });
    }
}
