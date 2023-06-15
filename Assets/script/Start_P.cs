using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Start_P : MonoBehaviour
{
    public Button Quit_bt;
    public GameObject panel;

    void Start()
    {
        Quit_bt.onClick.AddListener(DownPanel);
    }

    private void DownPanel()
    {
        panel.SetActive(false);
    }
}
