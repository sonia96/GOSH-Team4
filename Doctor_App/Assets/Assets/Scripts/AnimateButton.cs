using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimateButton : MonoBehaviour {

    // Use this for initialization
    bool isplaying = false;
    public Slider slider;


    public void PlayAnimation()
    {
        this.GetComponent<Animator>().Play("Reform Skull");
        this.GetComponent<Animator>().speed = 1;
    }

    public void StopPlaying()
    {
        this.GetComponent<Animator>().Play("Not Playing");
        this.GetComponent<Animator>().speed = 0;
    }

    public void ButtonControl()
    {
        if(isplaying)
        {
            StopPlaying();
            GameObject.Find("Optimize_Button").GetComponentInChildren<Text>().text = "Optimize Cuts\n –Paused–";
        }
        else
        {
            PlayAnimation();
            GameObject.Find("Optimize_Button").GetComponentInChildren<Text>().text = "Optimize Cuts\n –Playing–";

        }
        isplaying = !isplaying;
    }


    // Use this for initialization
    void Start()
    {
        this.GetComponent<Animator>().speed = 0;
        slider = (Slider)FindObjectOfType(typeof(Slider));

    }

    // Update is called once per frame
    void Update()
    {
        if (!isplaying)
        {
            if (slider.normalizedValue < 1)
            {
                this.GetComponent<Animator>().Play("Reform Skull", -1, slider.normalizedValue);
            }
        }
    }
}
