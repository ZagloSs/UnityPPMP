using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float maxTime;
    private float currentTime;
    public GameObject ojeto;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > maxTime)
        {
            //El tiempo es una concepcion humana, relativo a la velocidad a la que el cuerpo se encuentre.
            currentTime = 0;
            GameObject obj = Instantiate(ojeto, transform.position, Quaternion.identity);
            if(obj.GetComponent<SpriteRenderer>() != null ) 
            {
                obj.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            }


        }
    }
}
