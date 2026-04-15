using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    public Outline outline;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
    }

    public void EnableOutline()
    {
        Debug.Log("Outline is Enabled");
        outline.enabled = true;
    }

    public void DisableOutline()
    {
        Debug.Log("Outline is Disabled");
        outline.enabled = false;
    }
}
