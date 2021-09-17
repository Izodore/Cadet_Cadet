//#pragma warning disable 0649
using UnityEngine;

[CreateAssetMenu(fileName = "New Conversation", menuName ="Dialogue/New Conversation")]
public class Conversation : ScriptableObject
{
    [SerializeField] private DialogueLine[] lines;


    public DialogueLine GetLineByIndex(int index)
    {
        return lines[index];
    }

    public int GetLength()
    {
        return lines.Length - 1;
    }
}