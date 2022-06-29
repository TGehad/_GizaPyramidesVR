using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed =10f;
    bool isMoving=false;

    public Transform[] targets;
    int nextIndex;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("welcome to egypt");
        //set player o first position
        transform.position=targets[0].position;
        nextIndex=1;
       
    }

    // Update is called once per frame
    void Update()
    {
         //check input
        HandleInput();
       //start move
        HandleMovement();
    }

    void HandleInput()
    {
       //check for fire1 axix
       if(Input.GetButtonDown("Fire1"))
       {
           //negate ismoving
           isMoving=!isMoving;
       }

    }
     //take care of movement
    void HandleMovement()
    {
        if(!isMoving) return;

        // calc distance from target
        float dist = Vector3.Distance(transform.position,targets[nextIndex].position);
        //have we arrive
        if(dist>0)
        {

        //calc how much we need move step d=v*t
        float step =speed * Time.deltaTime;
        //move that step
        transform.position=Vector3.MoveTowards(transform.position,targets[nextIndex].position,step);

        }
        // if we arrive
        else
        {
            nextIndex++;

            if(nextIndex==targets.Length){

                nextIndex=0;
            }
            //stop moving
            isMoving=false;

        }


    }

}
