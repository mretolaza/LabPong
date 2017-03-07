//Maria Mercedes Retolaza Reyna 
//Carne: 16339 
//Plataformas Moviles y Video Juegos 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {

    private Rigidbody2D rib2d;
    private Vector2 velo;

    //Procedimiento cuando la bola sale. Este procedimiento hace que la bola 
    //salga y que tenga diferentes direcciones 
    void GoBall()
    {
        float rand = Random.Range(0.0f, 2.0f);
        if (rand < 1.0f){
            rib2d.AddForce(new Vector2(20.0f, -15.0f));
        }else{
            rib2d.AddForce(new Vector2(-20.0f, -15.0f));
        }
    }
    //Procedimiento que hace que la bola regrese al lugar 
    void ResetBall()
    {
        velo.y = 0;
        velo.x = 0;
        rib2d.velocity = velo;
        gameObject.transform.position = new Vector2(0, 0);
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1.0f);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            velo.x = rib2d.velocity.x;
            velo.y = (rib2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f); 
            rib2d.velocity = velo;
        }
    }

    // Use this for initialization
    void Start () {
        rib2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2.0f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
