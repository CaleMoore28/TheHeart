using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    public static GameManager gameManagerInstance { get; private set; }

    public GameObject[] photographNodes;

    public SceneChanger changer;

    private bool isSceneChanging;

    void Awake()
    {
        if (gameManagerInstance == null)
        {
            gameManagerInstance = this;
        }

        isSceneChanging = false;
    }

    private void Update()
    {
        if (AreAllFragmentsPlaced() || Keyboard.current.tKey.wasPressedThisFrame)
        {
            Debug.Log("Puzzle done");

            if (!isSceneChanging)
            {
                isSceneChanging = true;

                SceneData.instance.photographSceneVisited = true;

                changer.ChangeSceneAsync();
            }
        }
    }

    private bool AreAllFragmentsPlaced()
    {
        foreach (GameObject node in photographNodes)
        {
            PhotographNodeStuff nodeScript = node.GetComponent<PhotographNodeStuff>();
            if (nodeScript.isHoldingAFragment == false)
            {
                return false;
            }
        }
        return true;
    }
}
