// Pseudocode:
// 1. Define a private boolean field to track if the player is in the trigger zone.
// 2. In the Update method, check if the player is in the trigger zone and if the F key is pressed.
//    If both conditions are true, log "F key pressed" and start the conversation.
// 3. In the OnTriggerEnter2D method, check if the colliding object has the "Player" tag.
//    If it does, log "Player entered trigger zone" and set the playerInTriggerZone flag to true.
// 4. In the OnTriggerExit2D method, check if the exiting object has the "Player" tag.
//    If it does, log "Player exited trigger zone" and set the playerInTriggerZone flag to false.

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