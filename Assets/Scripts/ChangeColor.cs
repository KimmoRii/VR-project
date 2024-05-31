using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material defaultMaterial;
    public Material newMaterial;

    Renderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<Renderer>();
    }

    public void HoverEnter()
    {
        meshRenderer.material = newMaterial;
    }

    public void HoverExit()
    {
        meshRenderer.material = defaultMaterial;
    }
}
