using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    //CPU Cost of Get Component is high, try to use it once when it needed.

    private void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The Player's score is:" + anotherScript.playerScore);
        Debug.Log("The player has died:" + yetAnotherScript.numberOfPlayerDeaths + "times");
    }
}
