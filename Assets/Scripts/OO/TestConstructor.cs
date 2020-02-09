using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConstructor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        metodosConstructor metodos = new metodosConstructor(10, "Rachellll");
        print(metodos.value1);        
        print(metodos.value2);        
    }


}

public class metodosConstructor
{
    public int value1;
    public string value2;

    public metodosConstructor(int val1, string val2)
    {
        value1 = val1;
        value2 = val2;
    }
}