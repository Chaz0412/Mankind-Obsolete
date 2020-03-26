using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIdleToAttack : StateMachineBehaviour
{

    public float ran;
    public bool high;
    public bool low;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        ran = Random.Range(0f, 1f);
        if (ran >= 0.5f)
        {
            high = true;
            low = false;
        }
        else if (ran < 0.5f)
        {
            low = true;
            high = false;
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if(high == true)
        {
            animator.SetTrigger("HighAttack");
        }
        else if (low == true)
        {
            animator.SetTrigger("LowAttack");
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("HighAttack");
        animator.ResetTrigger("LowAttack");
    }

}
