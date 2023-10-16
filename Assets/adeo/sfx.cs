using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfx : MonoBehaviour
{
    [Header("Aoudio")]
    public AudioSource audioSource;
    public AudioClip kaboom;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        

        //make the kabbomsound when space bar is hit 

        if (Input.GetKeyUp(KeyCode.Space) && !audioSource.isPlaying) 
        {
            audioSource.PlayOneShot(kaboom);
        }
    }
}
