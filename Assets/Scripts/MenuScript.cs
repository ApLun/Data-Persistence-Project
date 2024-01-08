using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.IO;
using UnityEditor;
using TMPro;

public class MenuScript : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI highScoreMenuText;


    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.LoadStats();
        highScoreMenuText.text = "Best Score : " + GameManager.Instance.name + $"({GameManager.Instance.points})";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartNew()
    {
        GameManager.Instance.name = nameText.text;
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
