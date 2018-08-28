using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions2 : MonoBehaviour {

    public void RunInstructions()
    {
        SceneManager.LoadScene(1);

    }

    public void RunInstructions2()
    {
        SceneManager.LoadScene(2);

    }


    // Use this for initialization
    void Start () {
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
