using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour {

    // Start is called before the first frame update
    void Start () {
        List<int> lista = new List<int> ();

        for (int i = 0; i < 9; i++) 
        {
            lista.Add(i);    
        }

        foreach (var item in lista)
        {
            print(item);
        }

    }

}