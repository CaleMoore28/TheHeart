using UnityEngine;
using UnityEngine.UI;

public class SettingsHighlight : MonoBehaviour
{
  public Image bg; //buttonBG

  Color regColor;
  Color hoverColor = new Color(0.729f, 0.455f, 0.090f, 0.55f);

  void Start()
  {
    regColor = bg.color;
  }

  public void OnHoverEnter()
  {
    bg.color = hoverColor;
  }

  public void OnHoverExit()
  {
    bg.color = regColor;
  }


}
