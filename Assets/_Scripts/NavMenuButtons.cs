using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class NavMenuButtons : MonoBehaviour
{
  // SceneChanger
  public SceneChanger sceneChanger;
  public GameObject creditsScreen;
  public GameObject settingsScreen;
  public GameObject[] menuPanels;

  private NavMenu navMenu;

  void Start()
  {
    navMenu = GetComponent<NavMenu>();
  }
  public void Hover(int index)
  {
    navMenu.SetActive(index);
  }

  public void ClickStart()
  {
    sceneChanger.ChangeSceneAsync();
  }

  public void ClickSettings()
  {
    settingsScreen.SetActive(true);
    SetMenuPanels(false);
  }

  public void ClickCredits()
  {
    creditsScreen.SetActive(true);
    SetMenuPanels(false);
  }

  public void CloseCreditsScreen()
  {
    creditsScreen.SetActive(false);
    SetMenuPanels(true);
  }

  public void CloseSettingsScreen()
  {
    settingsScreen.SetActive(false);
    SetMenuPanels(true);
  }

  public void ClickExit()
  {
    // works in unity editor for testing
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
  }

  private void SetMenuPanels(bool active)
  {
    foreach (GameObject panel in menuPanels)
    {
      panel.SetActive(active);
    }
  }

}
