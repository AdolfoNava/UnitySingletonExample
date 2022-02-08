using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class PersistentDataPath : Singleton<PersistentDataPath>
{
    public Text hashcode;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Application.persistentDataPath);
        Save();
        Load();
        hashcode.text = Instance.GetHashCode().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open($"{Application.persistentDataPath}/TextToCall.dat", FileMode.Create);
        Content c = new Content();
        c.TextFile = "This is Persistent data";
        bf.Serialize(file, c);
        file.Close();
    }
    void Load()
    {
        if (File.Exists($"{Application.persistentDataPath}/TextToCall.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open($"{Application.persistentDataPath}/TextToCall.dat",FileMode.Open);
            Content c = (Content)bf.Deserialize(file);
            file.Close();
            info.text = c.TextFile;
        }
    }
}
[Serializable]
public class Content
{
    public string TextFile;
}
