using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    //The sounds that are being played when its corresponding button is pressed
    public AudioSource nextNumber;
    public AudioSource reset;
    public AudioSource nextExample;
    public AudioSource previousExample;
    public AudioSource spawnCube;

    public void PlayNextNumber()
    {
        nextNumber.Play();
    }

    public void PlayReset()
    {
        reset.Play();
    }

    public void NextExample()
    {
        nextExample.Play();
    }

    public void PreviousExample()
    {
        previousExample.Play();
    }

    public void Spawn()
    {
        spawnCube.Play();
    }
}
