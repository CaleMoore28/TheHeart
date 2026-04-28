using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class UIRayToggle : MonoBehaviour
{
  [SerializeField] GameObject UIRay;
  [SerializeField] InputActionProperty toggleAction;
  [SerializeField] InputActionProperty settingsAction;

  [SerializeField] NavMenuButtons navMenuButtons;

  void Start()
  {
    UIRay.SetActive(false);
    toggleAction.action.performed += OnTogglePressed;
    toggleAction.action.canceled += OnToggleReleased;
    settingsAction.action.performed += OnSettingsClicked;
  }

  void OnDestroy()
  {
    toggleAction.action.performed -= OnTogglePressed;
    toggleAction.action.canceled -= OnToggleReleased;
    settingsAction.action.performed -= OnSettingsClicked;
  }

  private void OnTogglePressed(InputAction.CallbackContext ctx)
  {
    UIRay.SetActive(true);
  }

  private void OnToggleReleased(InputAction.CallbackContext ctx)
  {
    UIRay.SetActive(false);
  }

  private void OnSettingsClicked(InputAction.CallbackContext ctx)
  {
    navMenuButtons.ClickSettings();
  }
}
