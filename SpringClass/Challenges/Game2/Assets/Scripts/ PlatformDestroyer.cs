using System.Collections;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject platformDestructionPoint;


    // Start is called before the first frame update
    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint");
    }

    // Update is called once per frame
    void Update()
    {
     if(transform.position.x <platformDestructionPoint.transform.position.x)
        {
            //Destroy(gameObect);
            gameObject.SetActive(false);
        }
    }
}
