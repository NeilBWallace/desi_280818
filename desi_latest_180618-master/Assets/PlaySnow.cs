using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlaySnow : MonoBehaviour {
	public GameObject fx_Snow;
	public Text credits;

	// Use this for initialization
	void Start () {
		fx_Snow.SetActive(false);
		StartCoroutine(Example());

		StartCoroutine(Example2());
	}

	IEnumerator Example2()
	{   

		yield return new WaitForSeconds(54);
        //fx_Snow.SetActive (false);

        SceneManager.LoadScene("falling1");
    }

	IEnumerator Example()
	{   

		yield return new WaitForSeconds(40);
		fx_Snow.SetActive(true);


	}



	// Update is called once per frame
	void Update () {
		
	
	}
}
