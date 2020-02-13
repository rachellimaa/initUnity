using UnityEngine;

public class InputController : MonoBehaviour
{
    private float speed = 3.5f;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }*/

        //Teclado
        float input = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(input * Time.deltaTime, inputVertical * Time.deltaTime, 0));
        
        //Mouse
        /*float input = Input.GetAxis("Mouse X");
        float inputVertical = Input.GetAxis("Mouse Y");
        transform.Translate(new Vector3(input * Time.deltaTime, inputVertical * Time.deltaTime, 0));*/

        
    }
}