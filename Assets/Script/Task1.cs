using System;
using System.Threading.Tasks;
using UnityEngine;
using File = System.IO.File;

public class Task1 : MonoBehaviour

{
    private static async Task EnterText()
    {
        // {Это метод EnterText(), который является асинхронным методом. Мы используем ключевое слово async, чтобы обозначить, 
        //     что метод асинхронный. Затем мы используем ключевое слово await, чтобы дождаться выполнения асинхронной операции 
        //     чтения содержимого файла textTask1.txt. Мы используем статический метод ReadAllTextAsync() класса File,
        //         чтобы асинхронно прочитать содержимое файла в строку file
        var file = await File.ReadAllTextAsync(@"Assets/File/textTask1.txt");
        Debug.Log(file);
    }

    public void Awake()
    {
        EnterText();
    }
}