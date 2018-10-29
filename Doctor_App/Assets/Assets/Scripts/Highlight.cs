using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour {
    private bool isOn = false;

    public void Button_Click()
    {
        GameObject[] lights = GameObject.FindGameObjectsWithTag("SkullLight");
        if (isOn != true)
        {
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].GetComponent<Light>().enabled = true;
            }
            isOn = true;
        }
        else{
            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].GetComponent<Light>().enabled = false;
            }
            isOn = false;
            
        }
    }
}
