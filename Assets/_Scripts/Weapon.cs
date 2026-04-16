using UnityEngine;

public class Weapon : MonoBehaviour
{
    public void WinTime()
    {
        SceneData.instance.kingArthurSceneVisited = true;
    }
}
