using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeControl : MonoBehaviour {
    bool isplaying = false;

    public void PlayAnime()
    {
        this.GetComponent<Animator>().Play("Reform Skull");
    }

    public void StopPlayAnime()
    {
        this.GetComponent<Animator>().Play("Not Playing");
    }

    public void AnimeButton()
    {
        if(isplaying)
        {
            StopPlayAnime();
            isplaying = !isplaying;
        }
        else{
            PlayAnime();
            isplaying = !isplaying;
        }
    }
}
