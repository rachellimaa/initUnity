using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    enum AI { correr, atirar, patrulhar}

    // Start is called before the first frame update
    void Start()
    {
        AI vilao1 = AI.atirar;
        AI vilao2 = AI.correr;
        AI vilao3 = AI.patrulhar;

        print(vilao1);
         
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
