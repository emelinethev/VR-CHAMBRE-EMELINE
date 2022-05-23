using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorClic : MonoBehaviour
{
    public Material[]materials;
    public Renderer rend;

    private int index = 1;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer> ();
        rend.enabled = true;
    }

    void OnMouseDown() {

        LinkManager linkManager = FindObjectOfType<LinkManager>();
        linkManager.DotOnClick(transform);

        if (materials.Length == 0){
            return;
        }
        if (Input.GetMouseButtonDown(0)){
            index += 1;
        }
        print(index);
        rend.sharedMaterial = materials [index-1];
    }

    // Update is called once per frame

}
