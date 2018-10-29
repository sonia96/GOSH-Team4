using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class skullData : MonoBehaviour {

    Skull skull1 = new Skull(1.0f,1.0f,1.0f,1.0f,1.0f,1.0f);
    public Text SkullInfo;


    void Update()
    {
        SkullInfo.text = skull1.getSkullInfo();
    }
	
}
