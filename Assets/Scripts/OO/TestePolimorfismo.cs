using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestePolimorfismo : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Leao leao = new Leao ();
        leao.comer();
        Gato gato = new Gato ();
        gato.comer();
    }

    // Update is called once per frame
    void Update () {

    }
}

class Animal : MonoBehaviour {
    //sobrescrito
    public virtual void comer () {
        print ("o animal esta comendo!!!");
    }
}

class Leao : Animal {
    public override void comer () {
        print ("o leao esta comendo");
    }
}

class Gato : Animal {
    public override void comer () {
        print ("o gato esta comendo");
    }
}