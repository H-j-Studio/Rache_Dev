using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Bt : MonoBehaviour
{
    public Button Start_Bt;
    public Button Option_Bt;
    public Button Exit_Bt;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;

    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);

        Start_Bt.onClick.AddListener(UpPanel1);
        Option_Bt.onClick.AddListener(UpPanel2);
        Exit_Bt.onClick.AddListener(UpPanel3);
    }

    private void UpPanel1()
    {
        panel1.SetActive(true);
    }
    private void UpPanel2()
    {
        panel2.SetActive(true);
    }

    private void UpPanel3()
    {
        panel3.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}