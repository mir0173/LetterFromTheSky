using UnityEngine;
using System.Collections.Generic;

public class DialogueManagerEnd : MonoBehaviour
{
    public TextAsset csvFile51;
    public TextAsset csvFile52;
    public TextAsset csvFile53;
    public TextAsset csvFile54;
    public TextAsset csvFile55;
    public TextAsset csvFile56;

    public class DialogueLine
    {
        public int id;
        public string detail;
    }
    public static List<DialogueLine> lines51 = new List<DialogueLine>();
    public static List<DialogueLine> lines52 = new List<DialogueLine>();
    public static List<DialogueLine> lines53 = new List<DialogueLine>();
    public static List<DialogueLine> lines54 = new List<DialogueLine>();
    public static List<DialogueLine> lines55 = new List<DialogueLine>();
    public static List<DialogueLine> lines56 = new List<DialogueLine>();

    void Start()
    {
        LoadCSV51();
        LoadCSV52();
        LoadCSV53();
        LoadCSV54();
        LoadCSV55();
        LoadCSV56();
    }
    void LoadCSV51()
    {
        string[] rows = csvFile51.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines51.Add(dialogue);
        }
    }
    void LoadCSV52()
    {
        string[] rows = csvFile52.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines52.Add(dialogue);
        }
    }
    void LoadCSV53()
    {
        string[] rows = csvFile53.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines53.Add(dialogue);
        }
    }
    void LoadCSV54()
    {
        string[] rows = csvFile54.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines54.Add(dialogue);
        }
    }
    void LoadCSV55()
    {
        string[] rows = csvFile55.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines55.Add(dialogue);
        }
    }
    void LoadCSV56()
    {
        string[] rows = csvFile56.text.Split('\n');
        for (int i = 1; i < rows.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(rows[i])) continue;
            string[] cols = rows[i].Split(',');
            DialogueLine dialogue = new DialogueLine();
            dialogue.id = int.Parse(cols[0]);
            dialogue.detail = cols[1];
            lines56.Add(dialogue);
        }
    }
}
