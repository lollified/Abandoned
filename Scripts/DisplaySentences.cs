using System.Collections;
using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class DisplaySentences : MonoBehaviour
{
    public TextMeshProUGUI displayText; // Change the field type to TextMeshProUGUI
    public float displayDuration = 5.0f;
    public string[] sentences = {
        "Welcome back!",
        "You're finally awake",
        "You've been trapped in this lab for so long",
        "Now it's just an abandoned facility filled with toxic radiations and enemies in the shadows",
        "Escape the facility with your cure.",
    };
    private int currentIndex = 0;

    private void Start()
    {
        StartCoroutine(DisplaySentencesCoroutine());
    }

    private IEnumerator DisplaySentencesCoroutine()
    {
        while (currentIndex < sentences.Length)
        {
            displayText.text = sentences[currentIndex];
            yield return new WaitForSeconds(displayDuration);
            currentIndex++;
        }

        displayText.text = "START THE GAME ->";
    }
}
