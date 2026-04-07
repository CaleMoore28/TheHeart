using UnityEngine;

public class PhotographNodeStuff : MonoBehaviour
{
    public bool isHoldingAFragment;

    private void Start()
    {
        isHoldingAFragment = false;
    }

    public void SetToSuccess()
    {
        isHoldingAFragment = true;
        Debug.Log(gameObject + " is now true");
    }

    public void SetToFail()
    {
        isHoldingAFragment = false;
        Debug.Log(gameObject + " is now false");
    }
}