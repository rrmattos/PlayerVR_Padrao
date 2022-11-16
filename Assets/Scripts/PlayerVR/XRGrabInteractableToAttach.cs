using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableToAttach : XRGrabInteractable
{
    public Transform LeftAttachTransform;
    public Transform RightAttachTransform;
    public HandPoses.Poses pose;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("LeftHand"))
        {
            attachTransform = LeftAttachTransform;
        }
        else if (args.interactorObject.transform.CompareTag("RightHand"))
        {
            attachTransform = RightAttachTransform;
        }

        base.OnSelectEntered(args);
    }
}
