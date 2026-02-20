using UnityEngine;
using Yarn.Unity;

public class ObjetoClickeable : MonoBehaviour
{
    [Header("Yarn")]
    public DialogueRunner dialogueRunner; 
    public string nodeName; 

    private bool yaClickeado = false; 

    private void OnMouseDown()
    {
        if (yaClickeado) return; 
        yaClickeado = true;

        Debug.Log($"Se hizo clic en {gameObject.name}");

        if (dialogueRunner == null)
        {
            Debug.LogError("No has asignado el DialogueRunner!");
            return;
        }

        dialogueRunner.VariableStorage.SetValue("$bookRead", true);
        Debug.Log("Variable $bookRead puesta en TRUE");

        if (!dialogueRunner.IsDialogueRunning)
        {
            dialogueRunner.StartDialogue(nodeName);
        }
    }
}
