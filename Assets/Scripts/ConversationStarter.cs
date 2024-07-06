

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter2D : MonoBehaviour
{
    [SerializeField] private NPCConversation myConversation;
    private bool playerInTriggerZone = false;

    private void Update()
    {
        if (playerInTriggerZone && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F key pressed.");
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger zone.");
            playerInTriggerZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited trigger zone.");
            playerInTriggerZone = false;
        }
    }
}