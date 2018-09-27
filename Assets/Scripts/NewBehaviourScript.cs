using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool IsChecked;
    public int MyIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if(IsChecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Nej");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= störe än eller lika med
        // > större än
        // < mindre än
        // && OCH (and)
        // || ELLER (or) [Alt Gr + <]

        if (MyIntValue == 10 && IsChecked == true)
        {
            if (IsChecked == true)

            print("Måndag");
        }
        else if (MyIntValue == 9)
        {
            print("Tisdag");
        }
        else
        {
            print("Okänd dag");
        }
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("Reload");
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            //Random.RandomRange(0, 1); nej.
            //0 1 2 3 4 5 6 7 8 9
            MyIntValue = Random.Range(0, 10);
            //0.032f, 10.000f
            print(Random.Range(0f, 10f));
            print("Lean left");

        }
    }
}