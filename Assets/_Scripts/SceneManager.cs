using Unity.XR.CoreUtils;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject[] kingArthurMods;
    public GameObject[] photographMods;

    public GameObject hello;

    public static SceneManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void UpdateRoom()
    {
        kingArthurMods = new GameObject[2];
        photographMods = new GameObject[2];

        kingArthurMods[0] = GameObject.Find("KInitialActive");
        kingArthurMods[1] = GameObject.Find("KFutureActive");
        photographMods[0] = GameObject.Find("PInitialActive");
        photographMods[1] = GameObject.Find("PFutureActive");

        // Changes bedrooom scene for King Arthur changes
        if (SceneData.instance.kingArthurSceneVisited)
        {
            kingArthurMods[0].SetActive(false);
            kingArthurMods[1].SetActive(true);
        }
        else
        {
            kingArthurMods[0].SetActive(true);
            kingArthurMods[1].SetActive(false);
        }

        // Changes bedroom scene for Photograph changes
        if (SceneData.instance.photographSceneVisited)
        {
            photographMods[0].SetActive(false);
            photographMods[1].SetActive(true);
        }
        else
        {
            photographMods[0].SetActive(true);
            photographMods[1].SetActive(false);
        }
    }
}
