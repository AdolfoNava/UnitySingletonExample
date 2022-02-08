using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAssetSingleton : Singleton<TextAssetSingleton>
{
    public TextAsset text;
    public Text hashcode;
    protected TextAssetSingleton() { }
    // Start is called before the first frame update
    void Start() 
    {
        text = (TextAsset)Resources.Load("TextToCall");
        info.text = text.text;
        hashcode.text = Instance.GetHashCode().ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
