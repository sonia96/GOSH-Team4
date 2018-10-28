using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DateTime : MonoBehaviour {

    public Text date_Time;
    private string time;
    private string date;

    void Update()
    {   
        time = System.DateTime.Now.ToString("hh:mm"); 
        date = System.DateTime.Now.ToString("MM.dd.yyyy");
        date_Time.text = time + " " + date;
    }
}
