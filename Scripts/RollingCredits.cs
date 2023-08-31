using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollingCredits : MonoBehaviour
{
    public TextMeshProUGUI creditsText;
    public float scrollSpeed = 30.0f; // Adjust this to control the scroll speed
    private Vector2 initialPosition;
    private bool isScrolling = true;

    private void Start()
    {
        initialPosition = creditsText.rectTransform.anchoredPosition;
        StartCoroutine(RollCredits());
    }

    private IEnumerator RollCredits()
    {
        while (isScrolling)
        {
            creditsText.rectTransform.anchoredPosition += Vector2.up * scrollSpeed * Time.deltaTime;

            if (creditsText.rectTransform.anchoredPosition.y > initialPosition.y + creditsText.preferredHeight)
            {
                isScrolling = false;
                break;
            }

            yield return null;
        }
    }
}
