//Created By Miguel Angel Cabrera Victoria
// The bird Script made the bird jumps using the space key 
// If there is a collision the gameover screen will appear


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D myRigidBody;
    public bool birdAlive = true;

        // Start is called before the first frame update
        void Start()
        {
            logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //calls the gameObject with the logic tag
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
            {
                myRigidBody.velocity = Vector2.up * 2; // while the birdisAlive and the user press the Space key the bird will fly
            }
        }

        private void OnCollisionEnter2D(Collision2D collision){
            logic.gameOver();
            birdAlive = false;
        }


}
