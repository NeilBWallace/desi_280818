using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startup : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public GameObject g;
	public Transform[] spawnLocations;
	public static GameObject[] FoodSpawns;
	public static int pos=0;
	public float x;float y;float z;
	// Use this for initialization
	void Start () {


       


    



        x = 0;y = 0;z = 0;
		float f1x = 288;float f1y = 3;float f1z = 183;
		float f2x = 308;float f2y=4; float f2z=181;
		float f3x = 287;float f3y=3; float f3z=136;
		float f4x = 238;float f4y=3; float f4z=139;
		float f5x = 241;float f5y=2; float f5z=141;


        if (Application.loadedLevelName == "magic_glade")
        {
           f5x = 270;  f5y = 1;  f5z = 186;


        }
        if (Application.loadedLevelName == "bridge2")
        {
            f5x = 270; f5y = 1; f5z = 186;


        }

        if (Application.loadedLevelName == "orchard")
        {
            f1x = 309; f1y = 2.71f; f1z = 129.85f;

            f2x = 301f; f2y = 3f; f2z = 143f;

            f3x = 244; f3y = 3; f3z = 138f;

            f4x = 297; f4y = 3; f4z = 128f;

            f5x = 312f; f5y = 3f; f5z = 130f;

        }


            if (Application.loadedLevelName == "marketplace")
        {
            f1x = 279.48f; f1y = 1.4f; f1z = 141.04f;
            f2x = 260f; f2y = 0.8f; f2z = 151.14f;
            f3x = 269; f3y = 1; f3z = 151f;
            f4x = 281; f4y = 1; f4z =154f;
            f5x = 283.7f; f5y = 1f; f5z = 164.94f;
        }


            //		Vector3 v = new Vector3 (100f, -100f, 3);

            //		spawnPos.position = v;
            for (int i = 0; i <= 4; i++)
            {
                spawnPos.Translate(0, 0, pos);

                if (i == 0)
                {
                    x = f1x;
                    y = f1y;
                    z = f1z;
                }

                if (i == 1)
                {
                    x = f2x;
                    y = f2y;
                    z = f2z;
                }

                if (i == 2)
                {
                    x = f3x;
                    y = f3y;
                    z = f3z;
                }

                if (i == 3)
                {
                    x = f4x;
                    y = f4y;
                    z = f4z;
                }

                if (i == 4)
                {
                    x = f5x;
                    y = f5y;
                    z = f5z;
                }

              

                g = (GameObject)Instantiate(spawnee, new Vector3(x, y, z), spawnPos.rotation);
            if (Application.loadedLevelName == "orchard")
            {
                Debug.Log("fruitss" + Opening_Values.vegetable_fruit_name[i]);
                g.name = Opening_Values.vegetable_fruit_name[i];
                g.GetComponent<stats>().fd = Opening_Values.vegetable_fruit_description[i];
                //	g.GetComponent<stats> ().food_group = Opening_Values.foodGroup [i];
                //	g.GetComponent<AudioSource> ().name= Opening_Values.foodObjs [i];

               
                Material newMat = Resources.Load("flags/Materials/" + Opening_Values.vegetable_fruit_description[i], typeof(Material)) as Material;
               g.GetComponent<Renderer>().material = newMat;




            }
            if (Application.loadedLevelName == "bridge2")
            {
               
                g.name = Opening_Values.sweets_fats_name[i];
                g.GetComponent<stats>().fd = Opening_Values.sweets_fats_description[i];
                //	g.GetComponent<stats> ().food_group = Opening_Values.foodGroup [i];
                //	g.GetComponent<AudioSource> ().name= Opening_Values.foodObjs [i];

               
                Material newMat = Resources.Load("flags/Materials/" + Opening_Values.sweets_fats_description[i], typeof(Material)) as Material;
               g.GetComponent<Renderer>().material = newMat;

            }

            if (Application.loadedLevelName == "magic_glade")
            { 
                   
                g.name = Opening_Values.carbohydrates_name[i];
                g.GetComponent<stats>().fd = Opening_Values.carbohydrates_description[i];

          
                Material newMat = Resources.Load("flags/Materials/" + Opening_Values.carbohydrates_description[i], typeof(Material)) as Material;
                g.GetComponent<Renderer>().material = newMat;

                //	g.GetComponent<stats> ().food_group = Opening_Values.foodGroup [i];
                //	g.GetComponent<AudioSource> ().name= Opening_Values.foodObjs [i];
            }
            if (Application.loadedLevelName == "marketplace")
            {                          
              
                g.name = Opening_Values.protein_dairy_name[i];
                g.GetComponent<stats>().fd = Opening_Values.protein_dairy_description[i];
                //	g.GetComponent<stats> ().food_group = Opening_Values.foodGroup [i];
                //	g.GetComponent<AudioSource> ().name= Opening_Values.foodObjs [i];

                Material newMat = Resources.Load("flags/Materials/" + Opening_Values.protein_dairy_description[i], typeof(Material)) as Material;
               g.GetComponent<Renderer>().material = newMat;



            }


     //   pos =pos +3;
			}
		}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
