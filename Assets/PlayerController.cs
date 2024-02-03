using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Tablica
    string[] arr = { "Meg", "Beg", "Bob", "Greg", "Elon" };
    List<int> list1 = new List<int>();
    [SerializeField] List<string> cars;

    // Start is called before the first frame update
    void Start()
    {
        list1.Add(12);
        list1.Add(3);
        list1.Add(14);

        list1.Sort();
        foreach (int i in list1)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
   
    }

}
