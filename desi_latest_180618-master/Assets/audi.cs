using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audi : MonoBehaviour {
    private AudioSource[] allAudioSources;
    public AudioClip alarm;
    private AudioSource source;
    public bool enter;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("enter");
           enter = true;
       

      
        if (other.gameObject.CompareTag("Player"))
        {
            source.Play();
        }
    }

    // Use this for initialization
    void Start () {
        enter = false;
        source = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
}
