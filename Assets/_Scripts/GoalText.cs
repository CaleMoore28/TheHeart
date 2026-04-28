using UnityEngine;
using TMPro;

public class GoalText : MonoBehaviour
{
  private TextMeshProUGUI text;

  void Start()
  {
    text = GetComponent<TextMeshProUGUI>();
    text.text = "Goal: Pull the sword from the stone...";
  }

  public void OnSwordPickup()
  {
    text.text = "Goal: Win against the knights!";
  }
}
