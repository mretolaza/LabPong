//Maria Mercedes Retolaza Reyna 
//Carne: 16339 
//Plataformas Moviles y Video Juegos 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour {
    
    float velo;
    public int Player;
    Vector3 padTras;

    // Use this for initialization
    void Start () {
        padTras = new Vector3(0.0f, 0.0f, 0.0f);
        velo = 10.0f; }
	
	// Update is called once per frame
	void Update () {
        padTras.x = 0.0f;
        padTras.y = 0.0f;
        padTras.z = 0.0f;

        if (Player == 1) {
            if (Input.GetKey(KeyCode.UpArrow)){
                padTras.y = velo * Time.deltaTime;
                transform.Translate(padTras);
            }
            if (Input.GetKey(KeyCode.DownArrow)){
                padTras.y = -velo * Time.deltaTime;
                transform.Translate(padTras);
            }     
        }

        if (Player == 2){

            if (Input.GetKey(KeyCode.W)){
                padTras.y = velo * Time.deltaTime;
                transform.Translate(padTras);
            }
            if (Input.GetKey(KeyCode.S)) {
                padTras.y = -velo * Time.deltaTime;
                transform.Translate(padTras);
            }    
        }
    }   
}
// end de la clase 