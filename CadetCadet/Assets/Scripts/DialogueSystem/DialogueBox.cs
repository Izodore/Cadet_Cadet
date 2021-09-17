using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class DialogueBox : MonoBehaviour
{
    public TextMeshProUGUI dialogue;
    
    // Start is called before the first frame update
    void Start()
    {
        string testString = "test.txt";
        Dialogue testDiag = new Dialogue();
        testDiag.key = new List<string>();
        testDiag.value = new List<string>();
        StreamWriter test = new StreamWriter("Dialogue/text.txt");
        
        testDiag.key.Add("test");
        testDiag.key.Add("test2");
        testDiag.value.Add(testString);
        testDiag.value.Add(testString);
        //string json = JsonUtility.ToJson(testDict);
        //test.WriteLine(json);
        //test.Close();

        test.WriteLine(JsonUtility.ToJson(testDiag));
        test.Close();

        StreamReader testRead = new StreamReader("Dialogue/text.txt");
        testString = testRead.ReadLine();

        //Debug.LogError(json);
        Debug.LogError(testString);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
