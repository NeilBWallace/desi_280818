using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour {


    public int timeLeft = 600;
    public Text countdownText;

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
        }
	}
}
