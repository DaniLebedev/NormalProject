using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
[System.Serializable]
public class Haptic
{
    [Range(0, 1)]
    public float intencity;
    public float duration;

    public void TriggerHaptic(BaseInteractionEventArgs eventArgs)
    {
        if (eventArgs.interactableObject is XRBaseControllerInteractor controllerInteraction)
        {
            TriggerHaptic(controllerInteraction.xrController);
        }
    }
    public void TriggerHaptic(XRBaseController controller)
    {
        if (intencity > 0)
        {
            controller.SendHapticImpulse(intencity, duration);
        }
    }

}
public class HapticInteractable : MonoBehaviour
{
    public Haptic hapticOnActivated;
    public Haptic hapticHoverEntered;
    public Haptic hapticHoverExited;
    public Haptic hapticSelectEntered;
    public Haptic hapticSelectExited;
    void Start()
    {
        XRBaseInteractable interactable = GetComponent<XRBaseInteractable>();
        interactable.activated.AddListener(hapticOnActivated.TriggerHaptic);
        interactable.hoverEntered.AddListener(hapticOnActivated.TriggerHaptic);
        interactable.hoverExited.AddListener(hapticOnActivated.TriggerHaptic);
        interactable.selectEntered.AddListener(hapticOnActivated.TriggerHaptic);
        interactable.selectExited.AddListener(hapticOnActivated.TriggerHaptic);

    }

    
    
}
