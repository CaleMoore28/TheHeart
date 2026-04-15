using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class AnimateHandOninput : MonoBehaviour
{
    public InputActionProperty triggerValue;
    public InputActionProperty gripValue;

    public Animator handAnimator;

    private int TriggerHash = Animator.StringToHash("Trigger");
    private int GripHash = Animator.StringToHash("Grip");

    private void Update()
    {
        float trigger = triggerValue.action.ReadValue<float>();
        float grip = gripValue.action.ReadValue<float>();

        handAnimator.SetFloat(TriggerHash, trigger);
        handAnimator.SetFloat(GripHash, grip);
    }
}