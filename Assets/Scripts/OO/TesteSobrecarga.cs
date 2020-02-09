using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteSobrecarga : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        calculadora calc = new calculadora();

        int result = calc.calcula(5,2);

        float result2 = calc.calcula(5.6f,2.8f);
        
        print(result);

        print(result2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

class calculadora
{
    public int calcula(int x, int y)
    {
        return x + y;
    }

    public float calcula(float x, float y)
    {
        return x + y;
    }
}