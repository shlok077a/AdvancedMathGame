using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
