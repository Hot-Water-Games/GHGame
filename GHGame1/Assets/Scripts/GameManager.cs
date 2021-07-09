using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;

    public bool startPlaying;

    public NoteScroller theNS;

    public static GameManager instance;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theNS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {

    }

    public void NoteMissed()
    {

    }
}
