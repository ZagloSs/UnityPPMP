using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int playerIndex;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Guardamos la colision de la bola
        ball ballComp = collision.GetComponent<ball>();

        if(ballComp != null)
        {
            //Resetea la bola a su posicion original
            ballComp.ResetBall();

            //Sumar puntos al contador que corresponda
            GameManager.instance.points[playerIndex]++;
        }
    }
}
