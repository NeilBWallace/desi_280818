using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {


  public   void GoBack()
    {
        //Hide Food canvas and Startup panels
        CanvasGroup c = GameObject.Find("Food_Panel").GetComponent<CanvasGroup>();
        c.alpha = 0;
        //   c = GameObject.Find("Startup").GetComponent<CanvasGroup>();
        //     c.alpha = 0;
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        Destroy(GameObject.Find("Market_Panel"));
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
