using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileDataBase : MonoBehaviour
{
    static public FileDataBase instance;
    public List<GameObject> addfileList = new List<GameObject>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
