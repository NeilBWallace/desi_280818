using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoNewScene4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        var pos = GameObject.Find("rabbit1").transform.position.x;
        Debug.Log("pos" + pos);
        if (pos > 303.4)
        {
         SceneManager.LoadScene("fall4");
        }

    }
}
