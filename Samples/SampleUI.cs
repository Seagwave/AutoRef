using System;
using SWFrameWork.Tools.AutoRef;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Debug;
public class SampleUI : AutoRefMonoBehaviour
{
    [SerializeField, Child(name: "StartBtn")]
    private Button startButton;
    [SerializeField, Child(name: "ExitBtn")]
    private Button exitButton;
    [SerializeField, Child(name: "StartBtn")]
    private Image exitBtnImage;
    
    [SerializeField, Child(name: "Title")]
    private TextMeshProUGUI titleTmp;
    
    [SerializeField, Child(name: "TitleDesc")]
    private TextMeshProUGUI titleDescTmp;

    [SerializeField, Child(name: "SampleSubUI")]
    private SampleUI subUI;
    
    void Start()
    {
        startButton.onClick.AddListener(() =>
        {
            Log("Start Button Clicked");
        });        
        exitButton.onClick.AddListener(() =>
        {
            Log("Exit Button Clicked");
        });

        titleTmp.text = "title";
        titleDescTmp.text = "title desc";
    }
}
