using UnityEngine;
using System.Collections.Generic;

public class DialogueManager2 : MonoBehaviour
{
    public TextAsset csvFile11;
    public TextAsset csvFile14;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }
    public static List<DialogueLine> lines11 = new List<DialogueLine>();
    public static List<DialogueLine> lines14 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV11();
        LoadCSV14();
    }
    void LoadCSV11()
    {
        string[] rows = csvFile11.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines11.Add(dialogue);
        }
    }
    
    void LoadCSV14()
    {
        string[] rows = csvFile14.text.Split('\n');
        for(int i=1; i<rows.Length; i++) 
        {
            if(string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1]; 
            lines14.Add(dialogue);
        }
    }
}
