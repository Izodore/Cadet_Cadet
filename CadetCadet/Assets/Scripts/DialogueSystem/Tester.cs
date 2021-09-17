using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public Conversation testConvo;
    public void StartConvo()
    {

        DialogueManager.StartConnversation(testConvo);
    }
}
