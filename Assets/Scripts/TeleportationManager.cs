using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TeleportationManager : MonoBehaviour
{
    public XRRayInteractor teleportInteractor;
    public InputActionProperty teleportAction;

    void Start()
    {
        teleportInteractor.gameObject.SetActive(false);

        teleportAction.action.performed += ActionPerformed;
    }

    private void ActionPerformed(InputAction.CallbackContext obj)
    {
        teleportInteractor.gameObject.SetActive(true);
    }

    void Update()
    {
        if(teleportAction.action.WasReleasedThisFrame())
        {
            teleportInteractor.gameObject.SetActive(false);
        }
    }
}
