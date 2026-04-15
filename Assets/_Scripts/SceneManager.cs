using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public SceneData sceneData;

    public GameObject[] kingArthurMods;
    public GameObject[] photographMods;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Sets to the opposite active state for swapping in/out objects

        // Changes bedrooom scene for King Arthur changes
        if (sceneData.kingArthurSceneVisited == true)
        {
            foreach (GameObject mod in kingArthurMods)
            {
                mod.SetActive(!mod.activeSelf);
            }
        }

        // Changes bedroom scene for Photograph changes
        if (sceneData.photographSceneVisited == true)
        {
            foreach (GameObject mod in photographMods)
            {
                Debug.Log("reading " + mod + " with an active value of " + mod.activeSelf);
                mod.SetActive(!mod.activeSelf);
            }
        }
    }
}
