using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Material nMaterial;
    public float timeToChange = 0.9f;
    private float timeSinceChange = 0;

    private void Awake()
    {
        nMaterial = GetComponent<Material>();
    }

    private void Update() {

        timeSinceChange += Time.deltaTime;
        
        if (nMaterial != null && timeSinceChange >= timeToChange)
        {
            Color newColor = new Color(
                Random.value,
                Random.value,
                Random.value

            );

            nMaterial.color = newColor;
            timeSinceChange = 0f;
        }
        
    }
}
