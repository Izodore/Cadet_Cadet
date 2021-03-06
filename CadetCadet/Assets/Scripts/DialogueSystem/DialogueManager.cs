
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite;

    private int currentIndex; //Current line of dialogue index
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Animator anim;
    private Coroutine typing;

    //Intialization
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            anim = GetComponent<Animator>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void StartConnversation(Conversation convo)
    {
        instance.anim.SetBool("isOpen", true); //Open window

        //Intialize conversation
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = "->";

        //First line of dialogue read
        instance.ReadNext();
    }

    public void ReadNext()
    {
        //Close dialogue window
        if (currentIndex > currentConvo.GetLength()) 
        {
            instance.anim.SetBool("isOpen", false);
            return; 
        }

        speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName;

        //dialogue.text = |Now in a coroutine
        typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));

        //Prevent dialogue being smashed together when the user skips portions via the nav button
        if(typing == null)
        {
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }
        else
        {
            instance.StopCoroutine(typing);
            typing = null;
            typing = instance.StartCoroutine(TypeText(currentConvo.GetLineByIndex(currentIndex).dialogue));
        }

        speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite;
        currentIndex++;

        if(currentIndex > currentConvo.GetLength())
        {
            navButtonText.text = "X"; //End conversation icon
        }
    }

    //Corutine that allows the char by char display of dialogue lines
    private IEnumerator TypeText(string text)
    {
        dialogue.text = "";
        bool complete = false;
        int index = 0;
        
        while(!complete)
        {
            dialogue.text += text[index++];
            string temp = dialogue.text;
            yield return new WaitForSeconds(0.04f);

            if (index > text.Length)
            { complete = true; }
        }

        typing = null;
    }    
}