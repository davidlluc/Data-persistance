using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class manager : MonoBehaviour
{
    public static manager Instance;
    public string Player;
    public string PlayerName;
    public int highscore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        highscore = 0;
        Loaddata();
        DontDestroyOnLoad(gameObject);
    }
    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int highscore;
    }

    public void Savedata()
    {
        SaveData data = new SaveData();
        data.PlayerName = PlayerName;
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void Loaddata()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName= data.PlayerName;
            highscore= data.highscore;
        }
    }
}
