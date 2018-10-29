using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject goldPrefab;

    void Start () {
        GenerateQuestion();
        //Q1:
        /*: for(int i=0;i<7;i++)
         {
             float x;
             float y;
             x = -10.5f+i * 3.5f;
             y =10.5f+ i *- 3.5f;
             Vector3 position = new Vector3(x, y, 0);
             Instantiate(goldPrefab, position, Quaternion.identity);

             float a;
             float b;
             a = -10.5f + i * 3.5f;
             b = -10.5f + i * 3.5f;
             Instantiate(goldPrefab, new Vector3(a, b, 0), Quaternion.identity);
         }*/


    }

   
    void Update () {
		
	}

    public void GenerateQuestion()
    {
        //Q2
        /*for(int i=0;i<3;i++)
        {
            float x;

            x = -7f+i * 2*3.5f;
           Instantiate(goldPrefab, new Vector3(x,0 , 0), Quaternion.identity);

            float a;
            float b;
            a = -7f + i * 2 * 3.5f;
            b = 7f;
            Instantiate(goldPrefab, new Vector3(a, b, 0), Quaternion.identity);

            float c;
            float d;
            c = -7f + i * 2 * 3.5f;
            d = -7f;
            Instantiate(goldPrefab, new Vector3(c, d, 0), Quaternion.identity);
        }*/


        //Q3  
       /* float i = 0;
        while ( i<3 )
        {
            float x;

            x = -7f + i * 2 * 3.5f;
            Instantiate(goldPrefab, new Vector3(x, 0, 0), Quaternion.identity);

            float a;
            float b;
            a = -7f + i * 2 * 3.5f;
            b = 7f;
            Instantiate(goldPrefab, new Vector3(a, b, 0), Quaternion.identity);

            float c;
            float d;
            c = -7f + i * 2 * 3.5f;
            d = -7f;
            Instantiate(goldPrefab, new Vector3(c, d, 0), Quaternion.identity);
            
        }*/

}
}
