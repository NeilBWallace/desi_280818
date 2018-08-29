using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToBridgeQuiz : MonoBehaviour {


    IEnumerator GoNextScene()
    {
       

        // wait for 3 seconds
        yield return new WaitForSeconds(8);


        //      SceneManager.LoadScene("InventoryMaster/Examples/bridge_quiz");
        SceneManager.LoadScene("Orchard");

    }

    // Update is called once per frame
    void Update () {
        StartCoroutine(GoNextScene());
	}
}
