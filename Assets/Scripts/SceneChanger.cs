using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    public float reflectionTime = 2f;

    public ScreenFader screenFaderScript;

    public void ChangeScene()
    {
        StartCoroutine(SceneTime(sceneName));
    }

    private IEnumerator SceneTime(string sceneName)
    {
        screenFaderScript.FadeOut();

        yield return new WaitForSeconds(screenFaderScript.fadeDuration);

        SceneManager.LoadScene(sceneName);
    }


    public void ChangeSceneAsync()
    {
        StartCoroutine(SceneTimeAsync(sceneName));
    }

    private IEnumerator SceneTimeAsync(string sceneName)
    {
        yield return new WaitForSeconds(reflectionTime);

        screenFaderScript.FadeOut();

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);
        asyncOperation.allowSceneActivation = false;

        float timer = 0;
        while (timer <= screenFaderScript.fadeDuration && !asyncOperation.isDone)
        {
            timer = timer + Time.deltaTime;

            yield return null;
        }

        asyncOperation.allowSceneActivation = true;
    }
}
