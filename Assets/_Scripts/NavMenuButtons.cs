using UnityEngine;

public class NavMenuButtons : MonoBehaviour
{
  // SceneChanger
  public SceneChanger sceneChanger;
  public GameObject creditsScreen;
  public GameObject[] menuPanels;

  private NavMenu navMenu;

  void Start()
  {
    navMenu = GetComponent<NavMenu>();
  }
  public void Hover(int index)
  {
    if (navMenu != null)
      navMenu.SetActive(index);
  }

  public void ClickStart()
  {
    sceneChanger.ChangeSceneAsync();
  }

  public void ClickSettings()
  {
    Debug.Log("Settings Clicked");
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
