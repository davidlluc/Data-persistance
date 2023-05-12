using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject fname;
    //private TextMeshProUGUI introscore;
    private GameObject introscore;
    void Start()
    {
        introscore = GameObject.Find("score intro");
        introscore.GetComponent<TextMeshProUGUI>().text = "Best Score : " + manager.Instance.PlayerName + " : " + manager.Instance.highscore;
    }
    public void newStart()
    {
        
        fname = GameObject.Find("nameinput");
        manager.Instance.Player= fname.GetComponent<TMP_InputField>().text;

        
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
