using UnityEngine;

public class FadeTrigger : MonoBehaviour
{
    public FadeEffect fadeEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            fadeEffect.FadeIn();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            fadeEffect.FadeOut();
        }
    }
}