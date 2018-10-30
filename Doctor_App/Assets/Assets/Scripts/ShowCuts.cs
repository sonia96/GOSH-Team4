using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCuts: MonoBehaviour {
    Vector3 v1;
    GameObject cut;

    public void Button_Click()
    {
        cut = GameObject.FindGameObjectWithTag("cut1");
        for (int i = 0; i < 10; i++){
            v1 = cut.transform.position;
            v1.z = cut.transform.position.z + i / 100f;
            cut.transform.position = v1;
        
        }
    }
}
