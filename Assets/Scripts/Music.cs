using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour //�ű���������Ҫһֱ,�˴���ű���Ϊmusic
{
    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play();
    }
}

