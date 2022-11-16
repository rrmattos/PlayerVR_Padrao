using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty PinchAnimationAction;
    public InputActionProperty gripAnimationAction;
    public Animator HandAnimator;
    public HandPoses.Poses TargetPose;

    private float triggerValue;
    private float gripValue;

    void Update()
    {
        triggerValue = PinchAnimationAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Trigger", triggerValue);

        gripValue = gripAnimationAction.action.ReadValue<float>();
        HandAnimator.SetFloat("Grip", gripValue);
        
        if (gripValue > 0)
        {
            HandAnimator.SetInteger("HandPose", TargetPose.GetHashCode());
        }
        else
        {
            HandAnimator.SetInteger("HandPose", HandPoses.Poses.Default.GetHashCode());
        }
    }

}
