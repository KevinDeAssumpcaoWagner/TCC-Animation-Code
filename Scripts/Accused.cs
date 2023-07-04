using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Accused : MonoBehaviour
{
    private Animator animator;
    public Pistol pistol;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        Transform pistolTransform = transform.Find("mixamorig9:Hips/mixamorig9:Spine/mixamorig9:Spine1/mixamorig9:Spine2/mixamorig9:RightShoulder/mixamorig9:RightArm/mixamorig9:RightForeArm/mixamorig9:RightHand/mixamorig9:RightHandIndex1/mixamorig9:RightHandIndex2/Hand_pistol/Pistol");
        pistol = pistolTransform.GetComponent<Pistol>();
        pistol.Deactivate();
    }

    void Update()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("Accused_Drawing_Gun"))
        {
            pistol.Activate();
        }
        else if (stateInfo.IsName("idle"))
        {
            ChangeRotation();
        }
    }
    public void ChangeRotation()
    {
        transform.rotation = Quaternion.Euler(0f, -190.900f, 0f);
    }
    public void SetActivateThirdShot(bool value)
    {
        animator.SetBool("activate_third_shot", value);
    }
    public Animator GetAnimator()
    {
        return animator;
    }
}
