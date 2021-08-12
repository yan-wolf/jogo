using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocarCameras : MonoBehaviour
{
    public Camera[] cameras;
    public Canvas lista;
    public int numeroCameras;
    public int NumeroMaximo;
    void Start()
    {
        NumeroMaximo = cameras.Length;
        numeroCameras = 1;
        foreach (Camera obj in cameras)
        {
            obj.gameObject.SetActive(false);
        }
        cameras[numeroCameras - 1].gameObject.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown("c") && numeroCameras < NumeroMaximo)
        {
            numeroCameras++;
            foreach (Camera obj in cameras)
            {
                obj.gameObject.SetActive(false);
            }
            cameras[numeroCameras - 1].gameObject.SetActive(true);
        }
        if (Input.GetKeyDown("c") && numeroCameras == NumeroMaximo)
        {
            foreach (Camera obj in cameras)
            {
                obj.gameObject.SetActive(false);
            }
            cameras[numeroCameras - 1].gameObject.SetActive(true);
            numeroCameras = 0;

        }

        if (Input.GetKey("e"))
        {
                lista.gameObject.SetActive(true);
        }
            else
            {
                lista.gameObject.SetActive(false);
            }
        
         
    }
}
