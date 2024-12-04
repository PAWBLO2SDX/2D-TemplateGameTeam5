using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPC : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public GameObject contButton;
    public float wordSpeed;
    public bool playerIsClose;
    private int indez;

    void Update()
    {
<<<<<<< HEAD:2D Template/Assets/Scripts/Dialogue.cs
        if(Input.GetKeyDown(KeyCode.E)  && playerIsClose)
=======
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
>>>>>>> bc65054e6e624a7a5533fa831cd39050fb0e9f9b:2D Template/Assets/Scripts(Movement)/NPC.cs
        {

            if (dialoguePanel.activeInHierarchy)
            {
                zeroText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (dialogueText.text == dialogue[index])
        {
            contButton.SetActive(true);
        }
    }

    public void zeroText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
<<<<<<< HEAD:2D Template/Assets/Scripts/Dialogue.cs
        foreach (char letter in dialogue[indez].ToCharArray())
=======
        foreach (char letter in dialogue[index].ToCharArray())
>>>>>>> bc65054e6e624a7a5533fa831cd39050fb0e9f9b:2D Template/Assets/Scripts(Movement)/NPC.cs
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }

    }

    public void NextLine()
    {
        contButton.SetActive(false);

        if (index < dialogue.Length - 1)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            zeroText();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
            zeroText();
        }
    }

    // Update is called once per frame


}
