using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class FileManger : MonoBehaviour
{
    string path;
    string[] filters = { "All printable files","png,jpeg,pdf,docx,doc"};


    public Button fileExplorer;

    private void Start() => fileExplorer.onClick.AddListener(OpenFileExplorer);
   
    public void OpenFileExplorer()
    {
        path = EditorUtility.OpenFilePanelWithFilters("Show all files (.png,.doc,.pdf)", "", filters);
        UIManager.instance.Pathtext.text = path.ToString();
    }
        

  
}
