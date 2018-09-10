using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class gotobridge2 : MonoBehaviour {


    public static int bridge_discussion=0;
    private AudioSource[] allAudioSources;
    public void gotobridge()
    {

        AudioSource audio = gameObject.AddComponent<AudioSource>();
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
        if (bridge_discussion == 0)
        {


            GameObject.Find("deezi_fall").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "No... I'm so lost and the storm has blown me to this strange land. I need to get home but my wings are injured. How will I fly back to my family and friends?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 1)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.white;
            GameObject.Find("Quickly").GetComponent<Text>().text = "I never saw a rabbit that looked like you..";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 2)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "I'm a dragon.";

            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }

        else if (bridge_discussion ==3)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.white;
            GameObject.Find("Quickly").GetComponent<Text>().text = "You will need to find foods full of protein to mend those wings of yours.";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 4)
        {
            GameObject.Find("whatisprotein").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.white;
            GameObject.Find("Quickly").GetComponent<Text>().text = "What is protein?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 5)
        {
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Protein is very important for the growth and repair of our body and it keeps us in good health.  ";
       //     GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
      //      GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
  else if (bridge_discussion == 6)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Foods that are rich in protein are:";

            bridge_discussion++;
        }
        else if (bridge_discussion == 7)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "meats, fish, eggs, dairy, nuts, seeds,  beans and lentils and even some vegetables. Look for the magic proteins to help heal your wings. ";
  
            bridge_discussion++;
        }
        else if (bridge_discussion == 8)
        {
            GameObject.Find("theresamarket").GetComponent<AudioSource>().Play();
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Look, there's a market! Perhaps I can find some things to help my wings get better.";

            bridge_discussion++;
        }



        else
        {
            SceneManager.LoadScene("marketplace");
        }
        }
	// Use this for initialization
	void Awake () {
     
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
