using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class GitHubTest : MonoBehaviour
{
    void Start()
    { 
        //    string firstName = "Khamis";
        //    string lastName = "Sabri";

        //    Debug.Log (firstName.Length);

        //    Debug.Log (firstName + " " +  lastName);
        //    Debug.Log ( 1 + "Saleem"); 

        // Variable Scopes
      

        // {
        //     int a = 5;
        //     Debug.Log(a);
        //     {
        //        Debug.Log(a);
        //     }
        // }
        
        // int counter = 0;
        // while (counter < 10)
        // {
        //    int randomNumber = Random.Range(1,7); // 1, 2, 3, 4, 5, 6
        //    Debug.Log(randomNumber); 
        //    counter++;
        //    if (randomNumber == 4) 
        //    {
        //     // break;
        //      continue;
        //    }
        //    Debug.Log("Subhi");
        //    Debug.Log("Mlukhieh");
        // }
        // int tuna = 10;
        // int tomato = 5;
        // int sardines = 10;
        // int foul = 20;

        // int[] shop = new int[4];

        // int[] shop = new int[4] {10, 5, 10, 20};

        int[] shop = {10, 5, 10, 20};

        // Debug.Log (shop.Length);

        int counter = 0;
        while (counter < shop.Length)
        {
            Debug.Log(shop[counter]);
            counter ++;
        }

}
}