using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class ModMenu : MonoBehaviour
{
    public string folderPath = "..\\SYNERGY-main\\Mods";
    private TMP_Text modCountText;

    void Start()
    {
        modCountText = GetComponent<TMP_Text>();
        if (modCountText == null)
        {
            modCountText = GameObject.Find("ModCountText").GetComponent<TMP_Text>();
        }
        DirectoryInfo modFolder = new DirectoryInfo(folderPath);
        FileInfo[] modFiles = modFolder.GetFiles();
        string modNames = "";
        foreach (FileInfo modFile in modFiles)
        {
            modNames += modFile.Name + "\n";
        }
        modCountText.text = "Mods Installed:\n" + modNames;
    }
}