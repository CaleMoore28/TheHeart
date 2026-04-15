using UnityEngine;
public class SceneData : MonoBehaviour
{
    public bool kingArthurSceneVisited;

    public bool photographSceneVisited;

    private void Awake()
    {
        photographSceneVisited = false;
        kingArthurSceneVisited = false;
        DontDestroyOnLoad(gameObject);
    }
}