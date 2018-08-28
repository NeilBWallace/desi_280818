using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using UnityEngine.UI;



public class hidenon : MonoBehaviour {


	public void Show_Carbs(){
	


		string food_group = EventSystem.current.currentSelectedGameObject.name;


			foreach (GameObject go in GameObject.FindGameObjectsWithTag("fruit")) {

			CanvasGroup rt = go.GetComponent<CanvasGroup>();


			if ((food_group == "All") ||(go.transform.parent.name=="dinner")) {
				rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;

			} else {
				rt.alpha = 0;
				rt.GetComponent<LayoutElement>().preferredWidth=0;
				rt.GetComponent<LayoutElement>().preferredHeight=0;
				rt.GetComponent<LayoutElement> ().ignoreLayout = true;

			}
	

			}

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("vegetables")) {
			
			CanvasGroup rt = go.GetComponent<CanvasGroup>();

			if ((food_group == "All") ||(go.transform.parent.name=="dinner")) {
			rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout =false;
			//	rt.GetComponent<Renderer>().enabled = true;
			} else {

				rt.GetComponent<LayoutElement>().preferredWidth=0;
				rt.GetComponent<LayoutElement>().preferredHeight=0;
				rt.GetComponent<LayoutElement> ().ignoreLayout = true;
				rt.alpha = 0;
			//	rt.GetComponent<Renderer>().enabled = false;
			}




		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("meat")) {
			Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
			CanvasGroup rt = go.GetComponent<CanvasGroup>();

			if ((food_group == "All") ||(go.transform.parent.name=="dinner")) {
				rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;

			} else {
				rt.alpha = 0;
				rt.GetComponent<LayoutElement>().preferredWidth=0;
				rt.GetComponent<LayoutElement>().preferredHeight=0;
				rt.GetComponent<LayoutElement> ().ignoreLayout = true;
			}




		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("fats")) {
			Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
			CanvasGroup rt = go.GetComponent<CanvasGroup>();

			if ((food_group == "All") ||(go.transform.parent.name=="dinner")) {
				rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
			} else {
				rt.alpha = 0;
				rt.GetComponent<LayoutElement>().preferredWidth=0;
				rt.GetComponent<LayoutElement>().preferredHeight=0;
				rt.GetComponent<LayoutElement> ().ignoreLayout = true;

			}




		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("carbohydrates")) {
			Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
			CanvasGroup rt = go.GetComponent<CanvasGroup>();

			if ((food_group == "All") ||(go.transform.parent.name=="dinner")) {
				rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
			} else {
				rt.alpha = 0;
				rt.GetComponent<LayoutElement>().preferredWidth=0;
				rt.GetComponent<LayoutElement>().preferredHeight=0;
				rt.GetComponent<LayoutElement> ().ignoreLayout = true;
			}




		}
	
		if(food_group=="Carbohydrates"){
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("carbohydrates")) {
				Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
				CanvasGroup rt = go.GetComponent<CanvasGroup> ();

				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
					rt.alpha = 1;
			


			}
		}

		if(food_group=="Fats"){
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("fats")) {
				Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
				CanvasGroup rt = go.GetComponent<CanvasGroup> ();

				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
					rt.alpha = 1;
			


			}
		}

		if(food_group=="Vegetables"){
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("vegetables")) {
				Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
				CanvasGroup rt = go.GetComponent<CanvasGroup> ();

				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
				rt.alpha = 1;
			


			}
		}
		if(food_group=="Meats"){
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("meat")) {
				Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
				CanvasGroup rt = go.GetComponent<CanvasGroup> ();

				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
					rt.alpha = 1;
			


			}
		}

		if(food_group=="Fruits"){
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("fruit")) {
				Debug.Log ("test" + EventSystem.current.currentSelectedGameObject.name);
				CanvasGroup rt = go.GetComponent<CanvasGroup> ();
				rt.GetComponent<LayoutElement> ().ignoreLayout = false;
				rt.alpha = 1;
				rt.GetComponent<LayoutElement>().preferredWidth=100;
				rt.GetComponent<LayoutElement>().preferredHeight=100;



			}
		}


	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
