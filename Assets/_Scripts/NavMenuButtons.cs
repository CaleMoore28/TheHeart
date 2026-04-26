using UnityEngine;

public class NavMenuButtons : MonoBehaviour
{
  // SceneChanger
  public SceneChanger sceneChanger;

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
    Debug.Log("Credits Clicked");
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
}
