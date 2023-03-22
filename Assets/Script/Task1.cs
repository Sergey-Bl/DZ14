using System;
using System.Threading.Tasks;
using UnityEngine;
using File = System.IO.File;

public class Task1 : MonoBehaviour

{
    private static async Task EnterText()
    {
        var file = await File.ReadAllTextAsync(@"Assets/File/textTask1.txt");
        Debug.Log(file);
    }

    public void Awake()
    {
        EnterText();
    }
}