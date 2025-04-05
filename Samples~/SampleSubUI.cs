using SWFrameWork.Tools.AutoRef;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SampleSubUI : MonoBehaviour
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
}
