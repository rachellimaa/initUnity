using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {
        Debug.Log ("Rachel Lima");
        //   Debug.Log("Rachel Lima");
        /*   Debug.Log("Rachel Lima"); */

        int[] array = new int[10];

        for (int i = 0; i < 9; i++) {
            array[i] = i + 1;
            print (array[i]);
        }

        Debug.Log ("matriz\n");

        int[, ] matriz = new int[2, 2];

        /*  matriz[0, 0] = 1;
           matriz[0, 1] = 2;
           matriz[1, 0] = 3;
           matriz[1, 1] = 4;

           print (matriz[1, 1]); */

        int aux = 1;

        for (int i = 0; i <= 1; i++) {
            for (int j = 0; j <= 1; j++) {
                matriz[i, j] = aux;
                aux++;
            }
        }

        for (int i = 0; i <= 1; i++) {
            for (int j = 0; j <= 1; j++) {
                print(matriz[i,j]);
            }
        }

    }

    // Update is called once per frame
    void Update () {

    }
}