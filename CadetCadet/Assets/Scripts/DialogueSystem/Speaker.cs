#pragma warning disable 0649
using UnityEngine;

[CreateAssetMenu(fileName ="Speaker_1", menuName = "Dialogue/New Speaker")]
public class Speaker : ScriptableObject
{
    [SerializeField] private string speakerName;
    [SerializeField] private Sprite speakerSprite;

    public string GetName
    {
        get
        {
            return speakerName;
        }
    }

    public Sprite GetSprite
    {
        get
        {
            return speakerSprite;
        }
    }
}
