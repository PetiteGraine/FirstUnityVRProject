using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;
    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;
    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;


    void Update()
    {
        leftTeleportation.SetActive(leftCancel.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>() > 0.1);
        rightTeleportation.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1);
    }
}
