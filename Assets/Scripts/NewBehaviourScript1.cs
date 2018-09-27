using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

    public bool IsChecked;
    public int MyIntValue = 10;
    public int userValue = 2;
    public int Dicenumber = 10;
    public int Dragon = 100;
    public int Human = 100;
	void Start ()
    {
		if(IsChecked == true)
        {
            Debug.Log("it's true");
        }

	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Dicenumber = Dicenumber - Random.Range(0, 7);
            Dicenumber = Dicenumber + Random.Range(0, 7); 
            print("Roll the dice");
            print(Dicenumber);
        }
        else if (Dicenumber >= 20)
        {
            print("You Won");
        }
        else if (Dicenumber <= 0)
        {
            print("You Lost");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Dragon = Random.Range(100, 150);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dragon = Dragon - Random.Range(5, 25);
        }
    }
}
