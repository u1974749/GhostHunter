using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideMap : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Wall")
        {
            source.clip = clip;
            source.Play();
        }
    }
}
