using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoNewScene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var pos = GameObject.Find("Camera").transform.position.y;

        if (pos <90)
        {
            SceneManager.LoadScene("Fall3");
        }

    }
}
