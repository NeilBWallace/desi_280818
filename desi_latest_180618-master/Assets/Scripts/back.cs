using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class back : MonoBehaviour {
    private AudioSource[] allAudioSources;
    public void Start()
    {
        Time.timeScale = 0f;
    }
    

        public void Back()
    {

        Time.timeScale = 1f;
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
        GameObject[] objs;
      

        if (Application.loadedLevelName == "InventoryMaster/Examples/magicglade_quiz")
        {
            SceneManager.LoadScene("thebridge");

        }


        if (Application.loadedLevelName == "marketplace")
        {


            GameObject.Find("Intro_Voice").GetComponent<AudioSource>().Play();
            CanvasGroup d = GameObject.Find("Food_Panel").GetComponent<CanvasGroup>();
            d.alpha = 0;

          

        }

        //GameObject.Find ("Back").GetComponent<AudioSource> ().Play ();

        if (ScoreManager.score == 5)
        {
            Debug.Log(ScoreManager.score);
            Debug.Log("moving to next scene");
            if (Application.loadedLevelName == "bridge2")
            {
                SceneManager.LoadScene("InventoryMaster/Examples/bridge_quiz");
            }

            if (Application.loadedLevelName == "marketplace")
            {
            //    SceneManager.LoadScene("InventoryMaster/Examples/marketplace_quiz");
                //    SceneManager.LoadScene(13);

              SceneManager.LoadScene("Magic_Glade");
            }

            if (Application.loadedLevelName == "orchard")
            {

                SceneManager.LoadScene("InventoryMaster/Examples/end_quiz");
            }

           
            if (Application.loadedLevelName == "magic_glade")
            {
                Debug.Log("werwer");
                //   SceneManager.LoadScene("thebridge");
                SceneManager.LoadScene("InventoryMaster/Examples/magicglade_quiz");
            }
        }


        CanvasGroup c = GameObject.Find("Food_Panel").GetComponent<CanvasGroup>();
        c.alpha = 0;

        Destroy(GameObject.Find("Market_Panel"));
    //   c = GameObject.Find("Market_Panel").GetComponent<CanvasGroup>();
   //   c.alpha = 0;
      
    }
    }
	
  
