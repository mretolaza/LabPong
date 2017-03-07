//Maria Mercedes Retolaza Reyna 
//Carne: 16339 
//Plataformas Moviles y Video Juegos 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour {
   //Declaracion de los game objet (las raquetas que representan a los 
    //jugadores 1 y 2 
    public GameObject Player1;
    public GameObject Player2;

    // Declaracion de los Collider (estos son los que simularan la caja en la que se 
    //juega el pong 
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;

}
