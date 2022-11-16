using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRDirectInteractorCustom : XRDirectInteractor
{
    public AnimateHandOnInput Hand;

    protected override void Start()
    {
        if (ReferenceEquals(interactionManager, null))
        {
            interactionManager = GameObject.Find("XR Interaction Manager").GetComponent<XRInteractionManager>();
        }
        
        base.Start();
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        Hand.TargetPose = args.interactableObject.transform.GetComponent<XRGrabInteractableToAttach>().pose;

        base.OnSelectEntered(args);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        Hand.TargetPose = HandPoses.Poses.Default;

        base.OnSelectExited(args);
    }
}
