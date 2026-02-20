/*using UnityEngine;
using Yarn.Unity;

public class ClickableDialog : MonoBehaviour
{
    [Header("Configuración de Yarn")]
    public DialogueRunner dialogueRunner;
    public string nodeName;

    private void OnMouseDown()
    {
        Debug.Log($"<color=cyan>Interacción:</color> Se hizo clic en {gameObject.name}");

        if (dialogueRunner == null)
        {
            Debug.LogError("¡Error! No has asignado el DialogueRunner en el inspector.");
            return;
        }

        if (!dialogueRunner.IsDialogueRunning)
        {
            Debug.Log($"<color=green>Lanzando diálogo:</color> Nodo '{nodeName}'");
            dialogueRunner.StartDialogue(nodeName);
        }
        else
        {
            Debug.LogWarning("El diálogo no se inició porque ya hay uno ejecutándose.");
        }
    }
}*/


using UnityEngine;
using Yarn.Unity;

public class ClickableDialog : MonoBehaviour
{
    [Header("Configuración de Yarn")]
    public DialogueRunner dialogueRunner;
    public string nodeName;
    

    private void OnMouseDown()
    {
    
        Debug.Log($"Se hizo clic en {gameObject.name}");

        if (dialogueRunner == null)
        {
            Debug.LogError("No has asignado el DialogueRunner.");
            return;
        }

        if (!dialogueRunner.IsDialogueRunning)
        {
            dialogueRunner.StartDialogue(nodeName);
        }

    }
}

