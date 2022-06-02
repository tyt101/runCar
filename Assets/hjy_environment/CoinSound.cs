using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip collectSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CoinPickup()
    {
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        Debug.Log("½ð±ÒÉùÒô");
    }
}
