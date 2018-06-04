using UnityEngine;
using System.Collections;

public class DontDestroyThis : MonoBehaviour {

    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Audio").Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
    }
}
