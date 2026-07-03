using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InterfaceManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public Image seekImage;
    public GameObject npc;
    public GameObject randomSpawn;

    [SerializeField]
    private Sprite[] collectibleSource;

    void Start()
    {
        dialogueBox.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButton("Submit"))
        {
            dialogueBox.SetActive(false);
        }
    }

    public void CollectibleUpdate(int item)
    {

    }

    public void ShowBox(string dialogue, int item)
    {
        dialogueBox.SetActive(true);

        if (npc.GetComponent<DialogueOpen>().begin)
        {
            scatterCoins();
        }
    }

    public void scatterCoins()
    {
        randomSpawn.GetComponent<RandomSpawn>().DistributeCollectibles();
        npc.GetComponent<DialogueOpen>().coinsScattered();
    }
}
