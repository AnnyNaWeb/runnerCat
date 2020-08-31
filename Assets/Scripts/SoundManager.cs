using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip catBox;
    public static AudioClip catinBox;
    public static AudioSource audiosrc;
    //  public static AudioSource audiosrcB;

    void Start () {
        catBox = Resources.Load<AudioClip> ("catbox");
        catBox = Resources.Load<AudioClip> ("catinbox");
        audiosrc = GetComponent<AudioSource> ();
        //    audiosrcB = GetComponent<AudioSource> ();
    }

    public static void playSound () {
        audiosrc.PlayOneShot (catBox);
    }
    public static void playSoundIn () {
        //    audiosrc.PlayOneShot (catinBox);
    }
}