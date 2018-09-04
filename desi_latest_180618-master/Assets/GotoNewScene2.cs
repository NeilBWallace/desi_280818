using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoNewScene2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var pos = GameObject.Find("Moya").transform.position.y;

        if (pos <340)
        {
            SceneManager.LoadScene("Fall3");
        }

    }
}
