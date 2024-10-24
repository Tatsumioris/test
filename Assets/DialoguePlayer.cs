using UnityEngine;
using TMPro;

public class DialoguePlayer : MonoBehaviour
{
    public DialogueAsset dialogueAsset;
    public TMP_Text dialogueText;
    public GameObject dialogueBox;

    private int dialogueLineIndex;

    private void Start()
    {
        dialogueText.text = dialogueAsset.dialogue[0];
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            dialogueLineIndex += 1;
            //dialogueLineIndex ++; || Appuyez sur la touche pour passer au dialogue suivant. Il ajoute 1 au Length 

            // Si il y a des dialogues encore, il passe au prochain
            if (dialogueLineIndex < dialogueAsset.dialogue.Length)
            {
                dialogueText.text = dialogueAsset.dialogue[dialogueLineIndex];
            }
            else //Si il y a plus de dialogue à lire, il cache la zone de texte
            {
                dialogueBox.gameObject.SetActive(false);
            }
        }
    }
}
