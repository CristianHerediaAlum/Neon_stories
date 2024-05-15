using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    [SerializeField] private GameObject dialogueMark;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Text dialogueText;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;
    // Start is called before the first frame update

    private float typingTime = 0.05f;

    private bool didDialogueStart;
    private int lineIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if(!didDialogueStart){
                StartDialogue();
            }
        }
    }
    private void StartDialogue(){
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        dialogueMark.SetActive(false);
        lineIndex = 0;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine(){
        dialogueText.text = string.Empty;

        foreach (char ch in dialogueLines[lineIndex]){
            dialogueText.text += ch;
            yield return new WaitForSeconds(typingTime);
        }
    }

}
