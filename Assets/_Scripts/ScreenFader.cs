using System.Collections;
using UnityEngine;

public class ScreenFader : MonoBehaviour
{
    public float fadeDuration = 2f;
    public Color fadeColor;
    private Renderer renderer;
    
    public bool fadeOnStart = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<Renderer>();

        if (fadeOnStart)
        {
            FadeIn();
        }
    }

    public void FadeIn()
    {
        Fade(1, 0);
    }

    public void FadeOut()
    {
        Fade(0, 1);
    }

    public void Fade(float alphaIn, float alphaOut)
    {
        StartCoroutine(FadeTime(alphaIn, alphaOut));
    }

    private IEnumerator FadeTime(float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color targetColor = fadeColor;
            targetColor.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

            renderer.material.SetColor("_BaseColor", targetColor);

            timer = timer + Time.deltaTime;
            yield return null;
        }

        Color targetColor2 = fadeColor;
        targetColor2.a = Mathf.Lerp(alphaIn, alphaOut, timer / fadeDuration);

        renderer.material.SetColor("_BaseColor", targetColor2);
    }
}
