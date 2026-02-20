using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    private int index = 0;

    void Start()
    {
        ShowSentence();
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            ShowSentence();
        }
        else
        {
            dialogueText.text = "";
            // Aquí puedes ocultar el panel o lanzar un evento
        }
    }

    void ShowSentence()
    {
        dialogueText.text = sentences[index];
    }
}
