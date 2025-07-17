using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class birdscript : MonoBehaviour

{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public Logicscript logic;
    public bool birdIsAlive =  true;
  
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Flappy Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();
    }

    // Update is called once per frame
    void Update()

    {
        if(Input.GetKeyDown(KeyCode.Space)&&birdIsAlive  )
        { 
          myRigidbody.velocity = Vector2.up * flapstrength;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdIsAlive = false;
    }
}
