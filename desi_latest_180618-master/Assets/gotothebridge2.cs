using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class gotothebridge2 : MonoBehaviour {

    public static int bridge_discussion = 0;
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

            GameObject.Find("whodarescrossbridge").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Who dares to try and cross my bridge?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 1)
        {
            GameObject.Find("Crossbridge").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "It’s me, Deezi. I need to get home. So please can I cross your bridge?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 2)
        {
            GameObject.Find("findmefood").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "There is no way you are crossing my bridge, go away …. Wait! …. I am feeling mighty hungry you need to get me something to eat and then I might let you pass.";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }

        else if (bridge_discussion == 3)
        {
            GameObject.Find("whatdoyouwant").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "What can I get you?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }

        else if (bridge_discussion == 4)
        {

            GameObject.Find("foodlotsfood").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Food. Lots of food, so that I can keep my figure and good looks. It takes a lot of sweets, cakes, fried foods and fizzy sweet drinks to make me beautiful.Yawn… I’m feeling a little tired …. young thingy.";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 1;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 0;
            bridge_discussion++;
        }
        else if (bridge_discussion == 5)
        {
            GameObject.Find("perhapsifatehealthily").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.green;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Perhaps if you ate healthily..?";
            GameObject.Find("Ogre_Image").GetComponent<CanvasGroup>().alpha = 0;
            GameObject.Find("Desi_Image").GetComponent<CanvasGroup>().alpha = 1;
            bridge_discussion++;
        }
        else if (bridge_discussion == 6)
        {

            GameObject.Find("silence").GetComponent<AudioSource>().Play();
            GameObject.Find("Quickly").GetComponent<Text>().color = Color.red;
            GameObject.Find("Quickly").GetComponent<Text>().text = "Silence!!!! Go to the magic forest and find me my dinner. Return with 5 pieces of food and you will be able to pass. ";
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