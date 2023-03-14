//Created by Miguel Angel Cabrera Victoria
// The pipeMiddle script try to find a gameobject with the tag named "logic"
//The import the logicScript to find the funtions and add the score when the bird goes thought the trigger


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMiddle : MonoBehaviour
{
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
     logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collider){
        logic.addScore();
    }
    
}
