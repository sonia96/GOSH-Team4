using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull
{
    private float volume;
    private float length;
    private float width;
    private float height;
    private float circumference;
    private float radius;

    public Skull(float volume, float length, float width,float height,float circumference,float radius){
        this.volume = volume;
        this.length = length;
        this.width = width;
        this.height = height;
        this.circumference = circumference;
        this.radius = radius;
    }

    public string getSkullInfo(){
        string info = "Volume: " + volume + "\nLength: " + length + "\nWidth: " +  width + "\nHeight: " + height + "\nCircumference: " + circumference + "\nRadius: " + radius;
        return info;
    }
}
