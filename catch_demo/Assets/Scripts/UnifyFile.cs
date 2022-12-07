using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnifyFile : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject addBox;

    public GameObject prefabObj;

    DateTime dt;
    string time;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        //addBox.SetActive(false);
        Canvas.SetActive(false);

        foreach (GameObject file in FileDataBase.instance.addfileList)
        {
            if (file.gameObject.name == "Attack.cs")
            {
                file.gameObject.SetActive(false);
            }

            if (file.gameObject.name == "Hero.cs")
            {
                file.gameObject.SetActive(false);
            }
        }

        //現在日時を代入
        dt = DateTime.Now;
        time = dt.ToString();

        // プレハブを元にオブジェクトを生成する
        GameObject obj = Instantiate(prefabObj, new Vector3(-19.0f, 1.0f, -10.0f), Quaternion.Euler(0, 0, 0));
        obj.GetComponent<Text>().text = time + "\n" +
                                        "create Attack.cs\n" +
                                        "create Hero.cs";

    }
}
