using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFelino : MonoBehaviour
{
    Felino _felino1;
    Felino _felino2;
    // Start is called before the first frame update
    void Start()
    {
         _felino1 = new Felino();
        _felino1.atacar(); 

    }

}
