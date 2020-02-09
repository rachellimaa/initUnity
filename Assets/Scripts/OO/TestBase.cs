using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        filho filho = new filho();
        filho.getIdade();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class pai: MonoBehaviour
{
    public int idade = 30;
}

class filho : pai
{
    public void getIdade()
    {
        print(base.idade);
    }
}