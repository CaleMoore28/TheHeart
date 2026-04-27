using UnityEngine;
using UnityEngine.UI;

public class SettingsHighlight : MonoBehaviour
{
  public Image bg; //buttonBG

  Color regColor = new Color(0.729f, 0.455f, 0.090f, 0.22f);
  Color hoverColor = new Color(0.729f, 0.455f, 0.090f, 0.55f);

  public void OnHoverEnter()
  {
    bg.color = hoverColor;
  }

  public void OnHoverExit()
  {
    bg.color = regColor;
  }


}
