using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneMan : MonoBehaviour {

    public static int shortgame_orchard=0;
    public static int shortgame_market = 0;
    public static int shortgame_magicglade = 0;
    public static int shortgame_bridge = 0;


    public void LoadIntro2()
    {
        SceneManager.LoadScene(2);
    }
    public void sceneman(){
		SceneManager.LoadScene (8);
	}

    public void GoToSecondQuestion()
    {
        //   CanvasGroup d = GameObject.Find("Quiz_Panel1").GetComponent<CanvasGroup>();
        GameObject g = GameObject.Find("Quiz_Panel1");
        Destroy(g);
       // d.alpha = 0;
    }

    public void GoToThirdQuestion()
    {
        //   CanvasGroup d = GameObject.Find("Quiz_Panel1").GetComponent<CanvasGroup>();
        GameObject g = GameObject.Find("Quiz_Panel2");
        Destroy(g);
        // d.alpha = 0;
    }
    public void GoToForthQuestion()
    {
        //   CanvasGroup d = GameObject.Find("Quiz_Panel1").GetComponent<CanvasGroup>();
        GameObject g = GameObject.Find("Quiz_Panel3");
        Destroy(g);
        // d.alpha = 0;
    }
    public void GoToFifthQuestion()
    {
        //   CanvasGroup d = GameObject.Find("Quiz_Panel1").GetComponent<CanvasGroup>();
        GameObject g = GameObject.Find("Quiz_Panel4");
        Destroy(g);
        // d.alpha = 0;
    }
    public void GoToOrchardSetupShortGame()
    {

        shortgame_orchard = 1;

        SceneManager.LoadScene("InventoryMaster/Examples/OrchardSetup");
        // d.alpha = 0;
    }
    public void GoToMagicGladeSetupShortGame()
    {

        shortgame_magicglade = 1;

        SceneManager.LoadScene("InventoryMaster/Examples/MagicGladeSetup");
        // d.alpha = 0;
    }
    public void GoToMarketSetupShortGame()
    {
       
        shortgame_market = 1;
        Debug.Log("shortgame market" + SceneMan.shortgame_market);
        SceneManager.LoadScene("InventoryMaster/Examples/MarketSetup");
        // d.alpha = 0;
    }
    public void GoToBridgeSetupShortGame()
    {

        shortgame_bridge = 1;

        SceneManager.LoadScene("InventoryMaster/Examples/BridgeSetup");
        // d.alpha = 0;
    }
    public void GoToEndQuiz()
    {



        SceneManager.LoadScene("InventoryMaster/Examples/end_quiz");
        // d.alpha = 0;
    }
    public void GoToEndScene()
    {
        if (SceneMan1.finished == 1)
        {

            SceneManager.LoadScene("End_Scene");
        }
        else
        {
            SceneManager.LoadScene("Introduction");
        }
        // d.alpha = 0;
    }

    public void GoToBridgeQuiz()
    {
        if (SceneMan.shortgame_bridge == 1)
        {
            SceneManager.LoadScene("Introduction");
        }
        else
        {
            SceneManager.LoadScene("bridge_quiz");
        }
        // d.alpha = 0;
    }
    public void GoToTest()
    {

        SceneManager.LoadScene("Test");


    }

    public void GoToCrossBridge()
    {
      
            SceneManager.LoadScene("CrossBridge");
          
       
    }



    public void GoToOrchard()
    {
        if (SceneMan.shortgame_bridge == 1)
        {
            SceneManager.LoadScene("Introduction");
            Debug.Log("Goto Introduction");
        }
        else
        {
            SceneManager.LoadScene("orchard");
        }
    }
    public void GoToTheBridge()
    {

        if (SceneMan.shortgame_magicglade == 1)
        {
            SceneManager.LoadScene("Introduction");
            Debug.Log("Goto Introduction");
        }
        else
        {
            SceneManager.LoadScene("thebridge");
        }

      
    }

    public void GoToIntro()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void GoToMagicGladeQuiz()
    {
        if (SceneMan.shortgame_magicglade == 1)
        {
            SceneManager.LoadScene("Introduction");
        }
        else
        {
            SceneManager.LoadScene("MagicGladeQuiz");
        }
    }

    public void GoToCredits()
    {
       
            SceneManager.LoadScene("Credits");
       
    }



    public void GoToMarketQuiz()
    {
        if (SceneMan.shortgame_market == 1)
        {
            SceneManager.LoadScene("Introduction");
        }
        else
        {
            //       SceneManager.LoadScene("marketplace_quiz");
            SceneManager.LoadScene("magic_glade");
        }
    }
   

    public void GoToMagicGlade()
    {
        Debug.Log("Goto MagicGlade");
        Debug.Log("shortgame_market" + SceneMan.shortgame_market);
        if (SceneMan.shortgame_market== 1)
        {
            SceneManager.LoadScene("Introduction");
            Debug.Log("Goto Introduction");
        }
        else
        {
          SceneManager.LoadScene("magic_glade");
        }
    }
    // Use this for initialization
    void Start () {
        ScoreManager.score = 0;
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
