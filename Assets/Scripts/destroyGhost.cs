using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;


public class destroyGhost : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    
    public void DestroyItem ()
    {
        source.clip = clip;
        source.Play();
        Invoke("Destroy", 0.5f);
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
