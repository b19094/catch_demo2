using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileDataBase : MonoBehaviour
{
    static public FileDataBase instance;
    public List<GameObject> addfileList = new List<GameObject>();
    public List<GameObject> commitfileList = new List<GameObject>();

    public GameObject firstFile;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        commitfileList.Add(firstFile);
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
