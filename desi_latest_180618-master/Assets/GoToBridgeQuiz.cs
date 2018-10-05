using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToBridgeQuiz : MonoBehaviour {


    IEnumerator GoNextScene()
    {
       

        // wait for 3 seconds
        yield return new WaitForSeconds(8);

        if (SceneMan.shortgame_bridge == 1)
        {
            //      SceneManager.LoadScene("InventoryMaster/Examples/bridge_quiz");
            SceneManager.LoadScene("Introduction");
        }
        else
        {
            //      SceneManager.LoadScene("InventoryMaster/Examples/bridge_quiz");
            SceneManager.LoadScene("Orchard");
        }
    }
    void Start()
    {
        Time.timeScale = 1f;
    }
    // Update is called once per frame
    void Update () {
        StartCoroutine(GoNextScene());
	}
}
