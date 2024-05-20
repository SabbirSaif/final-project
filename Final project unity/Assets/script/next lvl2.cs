using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlvl2 : MonoBehaviour
{
    // Start is called before the first frame update
    int buildindex;
    int exp;

    void Start()
    {
        buildindex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("wellcome to world " + 2 );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider myCollision)
    {
        //take you to next lvl.
        SceneManager.LoadScene(2);
        exp = 2;
        Debug.Log("Ex :" + exp);
    }
}
