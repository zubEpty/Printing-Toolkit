using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_PrintingTool : MonoBehaviour {

    public string filePath = "";
    public Button Print;
    public PrintingTool printingTool;

    void Start()
    {
        Print.onClick.AddListener(PrintDocument);  
    }


    void PrintDocument()
    {
        printingTool.CmdPrintThreaded(filePath);
        printingTool.StartCheckIsPrintingDone();
    }
    void Update()
    {
        
    }
}
