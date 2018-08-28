using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour {


    public static int quiz = 0;

    public void fight_germs_yes()
    {


        CanvasGroup d = GameObject.Find("5_yes_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

        d = GameObject.Find("quiz_5_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void fight_germs_no()
    {


        CanvasGroup d = GameObject.Find("5_no_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

        GameObject.Find("Click").GetComponent<AudioSource>().Play();

    }


    public void wide_variety_foods_Text()
    {


        CanvasGroup d = GameObject.Find("wide_variety_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

        d = GameObject.Find("quiz_4_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }


    public void potatoes_pasta_Text()
    {


        CanvasGroup d = GameObject.Find("potatoes_pasta_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

       
    }
    public void fruit_veg_Text()
    {


        CanvasGroup d = GameObject.Find("fruit_veg_text").GetComponent<CanvasGroup>();
        d.alpha = 1;


    }

    public void fruits_5_Text()
    {


        CanvasGroup d = GameObject.Find("fruits_5_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

        d = GameObject.Find("fruits_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void fruits_2_Text()
    {


        CanvasGroup d = GameObject.Find("fruits_2_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

     
    }

    public void fat_yes()
    {


        CanvasGroup d = GameObject.Find("yes_text").GetComponent<CanvasGroup>();
        d.alpha = 1;
        GameObject.Find("NotSoGood").GetComponent<AudioSource>().Play();

    }

    public void fat_no()
    {


        CanvasGroup d = GameObject.Find("no_text").GetComponent<CanvasGroup>();
        d.alpha = 1;

        GameObject.Find("Tada").GetComponent<AudioSource>().Play();

        d = GameObject.Find("fat_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;

    }


    public void Delicious()
    {


        CanvasGroup d = GameObject.Find("delicious_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void Sleep()
    {


        CanvasGroup d = GameObject.Find("sleep_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void Energy()
    {


        CanvasGroup d = GameObject.Find("energy_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void See()
    {


        CanvasGroup d = GameObject.Find("See_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }


    public void Heal()
    {


        CanvasGroup d = GameObject.Find("Heal_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
        d = GameObject.Find("OK").GetComponent<CanvasGroup>();
        d.alpha = 1;

    }


    public void GiveUsEnergy1()
    {


        CanvasGroup d = GameObject.Find("Energy_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
       
    }


    public void GiveUsEnergy()
    {
      

        CanvasGroup d = GameObject.Find("energy_Text").GetComponent<CanvasGroup>();
        d.alpha = 1;
        d = GameObject.Find("OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }
    public void two_2()
    {


        CanvasGroup d = GameObject.Find("2_2").GetComponent<CanvasGroup>();
        d.alpha = 1;
        d = GameObject.Find("2_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }
    public void beans()
    {
        CanvasGroup d = GameObject.Find("Beans_q").GetComponent<CanvasGroup>();
        d.alpha = 1;
        quiz++;
        if (quiz == 3)
        {
           d = GameObject.Find("end_OK").GetComponent<CanvasGroup>();
            d.alpha = 1;
        }
    }
    public void pies()
    {
        CanvasGroup d = GameObject.Find("pies_q").GetComponent<CanvasGroup>();
        d.alpha = 1;
        quiz++;
        if (quiz == 3)
        {
            d = GameObject.Find("end_OK").GetComponent<CanvasGroup>();
            d.alpha = 1;
        }
    }
    public void donuts()
    {
        CanvasGroup d = GameObject.Find("donuts_q").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }
    public void water()
    {
        CanvasGroup d = GameObject.Find("water_q").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }
    public void yoghurt()
    {
        CanvasGroup d = GameObject.Find("yoghurt_q").GetComponent<CanvasGroup>();
        d.alpha = 1;

    }
    public void meat()
    {
        CanvasGroup d = GameObject.Find("meat_q").GetComponent<CanvasGroup>();
        d.alpha = 1;
        quiz++;

        if (quiz == 3)
        {
            d = GameObject.Find("end_OK").GetComponent<CanvasGroup>();
            d.alpha = 1;
        }

    }


    public void two_1()
    {


        CanvasGroup d = GameObject.Find("2_1").GetComponent<CanvasGroup>();
        d.alpha = 1;

    }

    public void one_1()
    {


        CanvasGroup d = GameObject.Find("1_1").GetComponent<CanvasGroup>();
        d.alpha = 1;
       
    }
    public void one_2()
    {


        CanvasGroup d = GameObject.Find("1_2").GetComponent<CanvasGroup>();
        d.alpha = 1;
        d = GameObject.Find("1_OK").GetComponent<CanvasGroup>();
        d.alpha = 1;
    }

    public void one_3()
    {


        CanvasGroup d = GameObject.Find("1_3").GetComponent<CanvasGroup>();
        d.alpha = 1;
    
    }



    void ToSee()
    {

    }

    void ToHeal()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       

	}
}
