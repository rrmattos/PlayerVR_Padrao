using UnityEngine;

public class PointCollider : MonoBehaviour
{
    public Animator HandAnimator;
    public GameObject Collider;

    void Update()
    {
        if (HandAnimator.GetFloat("Grip") > 0.8f && HandAnimator.GetFloat("Trigger") <= 0.1f)
        {
            Collider.SetActive(true);
        }
        else
        {
            Collider.SetActive(false);
        }
    }
}
