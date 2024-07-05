using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1f;  // Duration of the fade effect

    private bool isFading = false;
    private float fadeTargetAlpha = 0f;
    private float currentAlpha = 0f;
    private float fadeSpeed = 0f;

    void Start()
    {
        // Initialize the alpha
        SetAlpha(0f);
    }

    void Update()
    {
        if (isFading)
        {
            currentAlpha = Mathf.MoveTowards(currentAlpha, fadeTargetAlpha, fadeSpeed * Time.deltaTime);
            SetAlpha(currentAlpha);

            if (Mathf.Approximately(currentAlpha, fadeTargetAlpha))
            {
                isFading = false;
            }
        }
    }

    public void FadeIn()
    {
        if (!isFading || fadeTargetAlpha == 0f)
        {
            isFading = true;
            fadeTargetAlpha = 1f;
            fadeSpeed = Mathf.Abs(fadeTargetAlpha - currentAlpha) / fadeDuration;
        }
    }

    public void FadeOut()
    {
        if (!isFading || fadeTargetAlpha == 1f)
        {
            isFading = true;
            fadeTargetAlpha = 0f;
            fadeSpeed = Mathf.Abs(fadeTargetAlpha - currentAlpha) / fadeDuration;
        }
    }

    private void SetAlpha(float alpha)
    {
        Color color = fadeImage.color;
        color.a = alpha;
        fadeImage.color = color;
    }
}