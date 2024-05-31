using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomInput : MonoBehaviour
{
    [SerializeField] GameObject menuCanvas;

    private void Start()
    {
        menuCanvas.SetActive(false);
    }

    public void OnMenu()
    {
        Debug.Log("Menu button pressed");
        menuCanvas.SetActive(!menuCanvas.activeInHierarchy);
    }
}
