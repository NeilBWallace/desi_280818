using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class wait5s : MonoBehaviour
{


    



IEnumerator Wait(float seconds)
{
yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Introduction");
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(Wait(30.0F)); 
       
	}
}
