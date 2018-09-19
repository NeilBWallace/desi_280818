using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
    Animator anim;                          // Reference to the animator component.

    public int timeLeft = 180;
    public Text countdownText;
    IEnumerator Wait(float duration)


    {


        //This is a coroutine


        Debug.Log("Start Wait() function. The time is: " + Time.time);

        Debug.Log("Float duration = " + duration);

        yield return new WaitForSeconds(duration);   //Wait



        SceneManager.LoadScene(Application.loadedLevelName);







        Debug.Log("End Wait() function and the time is: " + Time.time);


    }

    void Awake()
    {
        // Set up the reference.
        anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        StartCoroutine("LoseTime");
	}


    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
	// Update is called once per frame
	void Update () {
        countdownText.text = ("Time Left:" + timeLeft.ToString());

        if(timeLeft <=0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = "Times UP!";

            
            StartCoroutine(Wait(5));

            SceneManager.LoadScene(Application.loadedLevelName);


        }
	}
}
