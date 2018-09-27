using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    //public = syns i unity
    // bool = ja eller nej
    // int = heltal
    // shar = ett teken
    // flote = decimal tal
    // double = dubelt så många tal
    //string = flera teken
   
    //Uppgift 2
    public string sentence1 = "Du";
    public string sentence2 = "är";
    public string sentence3 = "efterbliven";
    //Uppgift 3
    public int number;
    //Uppgitf 4
    public float triangleBase;
    public float angel;
    // Use this for initialization
    public float bitar;
    public string namn;
    public int count;

    void Start()
    {
        TestFunktion();

        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift5a();
        Uppgift6();
    }

    void Uppgift1()
    {
        Debug.Log(
            string.Format(
                "Svaret på (963 * 421) - (175463 / 87) är {0}"
                , (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        Debug.Log(sentence1);
        Debug.Log(sentence2);
        Debug.Log(sentence3);
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}",
            number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }

    void Uppgift4()
    {
        //triangelns bas gånger höjden delat på två är lika med svaret
        Debug.Log(triangleBase * 8 / 2);
    }

    void Uppgift5()
    {
        Debug.Log(360 / angel); 
    }

    void Uppgift5a()
    {
        Debug.Log(360 / bitar);
    }

    void Uppgift6()
    {
        Debug.Log(string.Format("Hej {0} idioten", namn));
    }

    void TestFunktion()
    {
        Debug.Log("detta är min TestFunktion");
    }
    
    // Update is called once per frame

    void Update()
    {
        count = count + 1;
        count += 1;

        count = count - 1;
        count -= 1;

        count = count * 1;
        count *= 1;
    
        count = count % 2;
        count %= 2;

        count = count / 2;
        count /= 2;

        count += 5 % 2;

    }
}
