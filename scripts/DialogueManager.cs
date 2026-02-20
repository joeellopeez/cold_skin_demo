using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueOption
{
    public string textoOpcion;
    public int siguienteNodo; // índice del siguiente diálogo
}

[System.Serializable]
public class DialogueNode
{
    public string textoNPC;
    public DialogueOption[] opciones;
}

public class DialogueManager : MonoBehaviour
{
    public DialogueNode[] nodos;
    public Text textoNPC;
    public Button botonOpcionPrefab;
    public Transform contenedorOpciones;

    private int nodoActual;

    void Start()
    {
        MostrarNodo(0); // Empezamos en el nodo 0
    }

    public void MostrarNodo(int index)
    {
        nodoActual = index;
        var nodo = nodos[nodoActual];

        textoNPC.text = nodo.textoNPC;

        // Borrar botones anteriores
        foreach (Transform child in contenedorOpciones)
        {
            Destroy(child.gameObject);
        }

        // Crear botones nuevos
        foreach (var opcion in nodo.opciones)
        {
            var boton = Instantiate(botonOpcionPrefab, contenedorOpciones);
            boton.GetComponentInChildren<Text>().text = opcion.textoOpcion;

            int siguiente = opcion.siguienteNodo; // copiar a variable local
            boton.onClick.AddListener(() =>
            {
                MostrarNodo(siguiente);
            });
        }
    }
}
