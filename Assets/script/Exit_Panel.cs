using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit_Panel : MonoBehaviour
{
    public Button Yes_bt;
    public Button No_bt;
    public GameObject panel;

    void Start()
    {
        Yes_bt.onClick.AddListener(QuitGame);
        No_bt.onClick.AddListener(DownPanel);
    }

    private void DownPanel()
    {
        panel.SetActive(false);
        Debug.Log("창닫기");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("게임 종료");
    }
}