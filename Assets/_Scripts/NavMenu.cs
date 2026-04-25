
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NavMenu : MonoBehaviour
{
  [System.Serializable]
  public class NavItem
  {
    public Button button;
    public Image activeIndicator;
    public TMP_Text number;
    public TMP_Text label;
  }

  [SerializeField] NavItem[] items;

  Color xActive = new Color(0.729f, 0.455f, 0.090f, 1f);
  Color xDim = new Color(0.729f, 0.455f, 0.090f, 0.30f);
  Color yActive = new Color(0.961f, 0.894f, 0.753f, 1f);
  Color yDim = new Color(0.784f, 0.663f, 0.416f, 0.55f);

  void Start()
  {
    // loops thru nav
    for (int i = 0; i < items.Length; i++)
    {
      int index = i;
      items[i].button.onClick.AddListener(() => SetActive(index));
    }

    // index 0 -> Start: nav default when menu loads up
    SetActive(0);
  }

  public void SetActive(int activeIndex)
  {
    // loop thru items, update colors based on which one is active 
    for (int i = 0; i < items.Length; i++)
    {
      bool on = i == activeIndex;

      items[i].activeIndicator.color = on ? xActive : Color.clear;
      items[i].label.color = on ? yActive : yDim;
      items[i].number.color = on ? xActive : xDim;
    }
  }
}
