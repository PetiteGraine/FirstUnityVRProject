using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabbableInteractableTwoAttach : XRGrabInteractable
{
    public Transform leftAttachTransform;
    public Transform rightAttachTransform;
    public override Transform GetAttachTransform(IXRInteractor interactor)
    {
        Debug.Log("GetAttachTransform");

        Transform i_attachTransform = null;

        if (interactor.transform.CompareTag("Left Hand"))
        {
            Debug.Log("Left");
            i_attachTransform = leftAttachTransform;
        }
        if (interactor.transform.CompareTag("Right Hand"))
        {
            Debug.Log("Right");
            i_attachTransform = rightAttachTransform;
        }
        return i_attachTransform != null ? i_attachTransform : base.GetAttachTransform(interactor);
    }
}
