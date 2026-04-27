using UnityEngine;
using UnityEngine.InputSystem;

public class UIRayToggle : MonoBehaviour
{
  [SerializeField] GameObject UIRay;

  // Assign whichever button you want — 
  // e.g. XRI RightHand/Secondary Button (B button)
  [SerializeField] InputActionProperty toggleAction;

  void Start()
  {
    UIRay.SetActive(false);
    toggleAction.action.performed += OnTogglePressed;
    toggleAction.action.canceled += OnToggleReleased;
  }

  void OnDestroy()
  {
    toggleAction.action.performed -= OnTogglePressed;
    toggleAction.action.canceled -= OnToggleReleased;
  }

  private void OnTogglePressed(InputAction.CallbackContext ctx)
  {
    UIRay.SetActive(true);
  }

  private void OnToggleReleased(InputAction.CallbackContext ctx)
  {
    UIRay.SetActive(false);
  }
}
