using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSound : MonoBehaviour
{
    public AudioClip[] mergeSounds = new AudioClip[4];
    public static AudioClip[] mergeSoundsStatic = new AudioClip[4];
    public static AudioSource merge;
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            mergeSoundsStatic[i] = mergeSounds[i];
        }
        merge = GetComponent<AudioSource>();
    }
    public static void play()
    {
        merge.Play();
    }
}