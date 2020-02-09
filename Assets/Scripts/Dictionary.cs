using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Dictionary<string, string> vilao = new Dictionary<string, string> ();
        vilao.Add ("Magneto", "Matar todos");
        vilao.Add ("Coringa", "Fazer loucuras");

        vilao.Remove("Magneto");

        foreach (var item in vilao.Keys) {
            print (vilao[item]);
        }

    }

    // Update is called once per frame
    void Update () {

    }
}