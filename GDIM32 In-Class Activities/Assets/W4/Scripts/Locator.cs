using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//static class to locate player object in the scene
public class Locator : MonoBehaviour
{
    public static Locator instance { get; private set; }
    public W4Pigeon player { get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        GameObject playerObject = GameObject.FindWithTag("Player");
        player = playerObject.GetComponent<W4Pigeon>();
    }
}
