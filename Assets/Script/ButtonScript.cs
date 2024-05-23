using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject Knife;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        Debug.Log("suckkkkk");
        Instantiate(Knife, transform.position + transform.forward * 0.1F, Quaternion.identity);
    }
}
