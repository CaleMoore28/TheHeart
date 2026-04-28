using UnityEngine;
public class SceneData : MonoBehaviour
{
    public bool kingArthurSceneVisited;

    public bool photographSceneVisited;

    public static SceneData instance { get; private set; }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        photographSceneVisited = false;
        kingArthurSceneVisited = false;
;
    }
}