using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class gotobridge2 : MonoBehaviour {


    public static int bridge_discussion=0;

   public void gotobridge()
    {
        if (bridge_discussion == 0)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "No.. My wings are hurt from the fall. And I can't fly properly!";
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
            GameObject.Find("Quickly").GetComponent<Text>().text = "I'm a dragon. I'm lost and the storm has blown me to this strange land. I want to fly home to my friends and family.";

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
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Protein is very important for the growth and repair of our body and it keeps us in good health.  ";
       //     GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
      //      GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
  else if (bridge_discussion == 5)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Foods that are rich in protein are:";

            bridge_discussion++;
        }
        else if (bridge_discussion == 6)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "meats, fish, eggs, dairy, nuts, seeds,  beans and lentils and even some vegetables. Look for the magic proteins to help heal your wings. ";
  
            bridge_discussion++;
        }
        else
        {
            SceneManager.LoadScene("marketplace");
        }
        }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
