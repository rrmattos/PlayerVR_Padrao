using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateGrabRay : MonoBehaviour
{
    public GameObject LeftGrabRay;
    public GameObject RightGrabRay;

    public XRDirectInteractorCustom LeftDirectInteractor;
    public XRDirectInteractorCustom RightDirectInteractor;

    // Update is called once per frame
    void Update()
    {
        LeftGrabRay.SetActive(LeftDirectInteractor.interactablesSelected.Count.Equals(0));
        RightGrabRay.SetActive(RightDirectInteractor.interactablesSelected.Count.Equals(0));
    }
}
