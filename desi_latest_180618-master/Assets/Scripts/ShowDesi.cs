using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDesi : MonoBehaviour {


	public void Show_Desi(){
	
		GameObject desi = GameObject.FindGameObjectWithTag ("desi");

			desi.SetActive(true);
	}
}
