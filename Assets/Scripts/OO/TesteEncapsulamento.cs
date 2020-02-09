using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteEncapsulamento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        paiTest pai = new paiTest();
        print(pai.idade);

        pai.idade = 40;

        print(pai.idade);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class paiTest : MonoBehaviour
{
    private int Idade = 20;

    public int idade
    {
        get{return Idade;}
        set{Idade = value;}
    }
}