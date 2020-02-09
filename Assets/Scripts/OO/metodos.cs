using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print (sombra(2,3));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int sombra(int valor1, int valor2)
    {
        return valor1 + valor2;
    }

}
