using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Victim : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Accused accused = FindObjectOfType<Accused>();
        if (accused != null && accused.GetAnimator().GetCurrentAnimatorStateInfo(0).IsName("Accused_shooting"))
        {
            animator.Play("block");
        }
        if (accused != null && accused.GetAnimator().GetCurrentAnimatorStateInfo(0).IsName("Accused_shooting_1"))
        {
            animator.SetBool("Punch", true);
        }
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("idle_vic"))
        {
            Vector3 finalPosition = new Vector3(2.676f, 0f, -13.659f);
            transform.position = finalPosition;
        }
        if (stateInfo.IsName("Male_Action_Pose"))
        {
            accused.SetActivateThirdShot(true);
        }
        if (stateInfo.IsName("idle"))
        {
            transform.position = new Vector3(4.103f, 0.021587f, -13.825f);
        }
        if (stateInfo.IsName("idle_2"))
        {
            transform.rotation = Quaternion.Euler(0f, -190.900f, 0f);
        }
    }
}
