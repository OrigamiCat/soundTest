using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCheck : MonoBehaviour
{
    public AudioClip se_1;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            audioSource.PlayOneShot(se_1);
        }
    }
}
