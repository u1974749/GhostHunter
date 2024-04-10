using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreGhost;
    public TMP_Text winText;
    public int numberGhost;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update

    public void scoreUI()
    {
        numberGhost-=1;
        scoreGhost.text = (numberGhost).ToString();
        if(numberGhost<=0)
        {
            winText.text = "You Win!!! :)";
            source.clip = clip;
            source.PlayOneShot(clip);
        }
    }

}
