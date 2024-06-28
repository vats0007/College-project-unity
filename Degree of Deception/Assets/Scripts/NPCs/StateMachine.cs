using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState activeState;
   


    public void Initalise()
    {
        //setup default state
        ChangeState(new PatrolState());

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(activeState != null)
        {
            activeState.Perform();
        }
    }

    public void ChangeState(BaseState newState)
    {
        //check active state is not null
        if(activeState != null)
        {
            activeState.Exit();
        }

        //change to new state
        activeState = newState;

        //fail-check for the case that new state is null
        if(activeState != null)
        {
            //setup new state
            activeState.stateMachine = this;
            activeState.enemy = GetComponent<Enemy>();
            //assign state enemy class
            activeState.Enter();
        }
    }
}
