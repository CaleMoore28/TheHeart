using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    public Outline outline;

    public bool isBeingSelected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
    }

    // Disables outline and ability to make outline while holding
    public void DisableOnSelect()
    {
        outline.enabled = false;
        isBeingSelected = false;
    }

    // Creates outline when hovering over if not already selected
    public void EnableOutline()
    {
        if (!isBeingSelected)
        {
            outline.enabled = true;
        }
    }

    // Disables outline after not hovering over
    public void DisableOutline()
    {
        outline.enabled = false;
    }

    // Enables both outline and ability to enable after dropping
    public void EnableAfterSelect()
    {
        outline.enabled = true;
        isBeingSelected = true;
    }
}
