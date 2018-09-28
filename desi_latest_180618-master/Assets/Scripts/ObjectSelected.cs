using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectSelected : MonoBehaviour {

	private AudioSource[] allAudioSources;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetMouseButtonDown (0)) {
			

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
            string food_name = "";
			if (Physics.Raycast (ray, out hit)) {
                
                Debug.Log(hit.transform.name + "raycast");

				if (hit.transform.tag.Contains("Food")){
                    Time.timeScale = 0;
                    food_name = hit.transform.name;
					AudioSource audio = gameObject.AddComponent<AudioSource>();
					allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
					//	GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();
					foreach(AudioSource audioS in allAudioSources){
						audioS.Stop();
					}
					Debug.Log ("play audio" + food_name);
					audio.PlayOneShot((AudioClip)Resources.Load("audio/" + food_name));

				
				//	GameObject.Find ("Food_Sound").GetComponent<AudioSource> ().Play ();
				

					CanvasGroup c = GameObject.Find ("Food_Panel").GetComponent<CanvasGroup> ();
					c.alpha = 1;

                    Text ttt = GameObject.Find("Food_Title").GetComponent<Text>();
                 		ttt.text = food_name;

                    //	GameObject.Find (t.text ).GetComponent<AudioSource> ().Play ();


                    Image i = GameObject.Find ("Food_Image").GetComponent<Image> ();
					Debug.Log ("gg" + food_name);

                    //Special food name
                    string food_name2 = "";
                    if (food_name.Length > 1)
                    {
                      food_name2 = GameObject.Find(food_name).GetComponent<stats>().food_name.ToString().ToLower();
                    }
                    if (food_name2.Length > 1) {
                        i.sprite = Resources.Load<Sprite>("flags/" + food_name2.ToLower());
                    }
                    else
                    {
                    
                        i.sprite = Resources.Load<Sprite>("flags/" + food_name.ToLower());
                    }


                    if (food_name.Length > 1)
                    {
                        Text g = GameObject.Find("Food_Description").GetComponent<Text>();
                        g.text = GameObject.Find(food_name).GetComponent<stats>().fd.ToString();


                        g = GameObject.Find("Food_Group").GetComponent<Text>();
                        g.text = GameObject.Find(food_name).GetComponent<stats>().food_group.ToString();
                    }
				}
			}
		}
	}
}
