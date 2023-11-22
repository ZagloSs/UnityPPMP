using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float velocidad = 20;
    private Rigidbody2D rb;
    private Vector2 direccion;
    public KeyCode upKey, downKey;
    



    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){

        direccion = Vector2.zero;

        if (Input.GetKey(upKey))
        {
            direccion = new Vector2(0, 1);
        }else if(Input.GetKey(downKey)){

            direccion = new Vector2(0, -1);
        }
        


    }

    void FixedUpdate(){
        //Update que se ejecuta cada más tiempo

        rb.velocity = direccion * velocidad;


    }
}
 