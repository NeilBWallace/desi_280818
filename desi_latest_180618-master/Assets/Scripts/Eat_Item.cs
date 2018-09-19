using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eat_Item : MonoBehaviour {

	private AudioSource[] allAudioSources;


	void Start () {
//	Button btn = yourbutton.GetComponent<Button> ();
//btn.onClick.AddListener (TaskOnClick);
	}

	public void Eat_Food()
	{
		Time.timeScale = 1f;

		Debug.Log ("Eat Item");


      

        //Get title name
        Text t = GameObject.Find ("Food_Title").GetComponent<Text> ();

      
        Debug.Log("Food Title" + t.text);
        if (t.text.Length > 0)
        {
            GameObject g = GameObject.Find (t.text);

            Debug.Log("tag" + t.text);
                 if (g.tag == "Good_Food")
            {

                allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

                foreach (AudioSource audioS in allAudioSources)
                {
                    audioS.Stop();
                }


                GameObject.Find("Tasty_Voice").GetComponent<AudioSource>().Play();



                ScoreManager.score = ScoreManager.score + 1;


                GameObject[] objs;
                objs = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject o in objs)
                {
                    //	AudioSource enemyAudio = o.GetComponent <AudioSource> ();
                    //	enemyAudio.clip = deathClip;
                    //	enemyAudio.Play ();
                    //	o.GetComponent<EnemyHealth> ().StartSinking ();
                    GameObject.Destroy(o);
                    //	o.GetComponent<EnemyHealth> ().Death ();
                    //	o.GetComponent<EnemyHealth> ().StartSinking ();
                }


            }
            else
            {
                allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];

                foreach (AudioSource audioS in allAudioSources)
                {
                    audioS.Stop();
                }
                GameObject.Find("Burp").GetComponent<AudioSource>().Play();
                if (ScoreManager.score > 0)
                {
                    //	ScoreManager.score =ScoreManager.score -1;
                }




            }

            Destroy(g);
        }
		

		Debug.Log ("eat food");
	//	Opening_Values.move = 1;


		Debug.Log (ScoreManager.score);

		t = GameObject.Find ("ScoreText").GetComponent<Text> ();
		t.text = "Score: " + ScoreManager.score;
        
	
		CanvasGroup c =GameObject.Find("Food_Panel").GetComponent<CanvasGroup> ();
		c.alpha = 0;
	
	
	
	}


}
