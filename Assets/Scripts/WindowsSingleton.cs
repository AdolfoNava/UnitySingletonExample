using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Reflection;

public class WindowsSingleton : Singleton<WindowsSingleton>
{
    string path;
    string[] filepull;
    public Text hashcode;
    // Start is called before the first frame update
    void Start()
    {
        //D:\Programming projects\GameProgramming2\Singleton\SingletonDemo\Library\ScriptAssemblies
        path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        
        hashcode.text = Instance.GetHashCode().ToString();
        filepull = File.ReadAllLines($"{path}\\..\\..\\Assets\\Resources\\TextToCall.txt");
        info.text = filepull[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
