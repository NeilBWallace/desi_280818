using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gotothebridge2 : MonoBehaviour {

    public static int bridge_discussion = 0;

    public void gotobridge()
    {
        if (bridge_discussion == 0)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Young Dragon, there is no way you are crossing this bridge till you get me what I need.";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 1)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "What do you need?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 2)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Well .. you see how I look so beautiful?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }

        else if (bridge_discussion == 3)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Um.. beautiful? Well I guess .. so";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }

        else if (bridge_discussion == 4)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "It's sweets that give me this wonderful complexion, but I'm a little fat to move.";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 5)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Maybe that's because ..";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 6)
        {
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Silence..! Go to the magic forest and find me sweets and fatty things then you can pass. ";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else
        {
            SceneManager.LoadScene("bridge2");
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}