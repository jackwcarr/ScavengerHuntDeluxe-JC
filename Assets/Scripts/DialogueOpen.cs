using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOpen : MonoBehaviour
{

    public string dialogue;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    } 

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialogue();
    }

    public void searchDialogue()
    {
        dialogue = "Hi! Can you help me find my " + collectibles[clue] + "?";
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialogue, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialogue = "Thankyou kindly, You have succesfully found my " + collectibles[clue] + ".";
            end = true;
        }
        else
        {
            dialogue = "Sorry, you must know that what you collected isn't my " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
