using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayGame : MonoBehaviour {


	public void PlayGames(){

		//IF food chosen
		if (Opening_Values.foods_chosen > 0) {
			SceneManager.LoadScene (4);
		}
	
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
