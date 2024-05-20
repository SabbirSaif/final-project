using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    int buildindex;
    int exp;

    void Start()
    {
        buildindex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("wellcome to world " +4 );
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exp == 4)
        {
            Debug.Log("Ex :" + exp);
            Debug.Log("You are now Lv: 1");
            Debug.Log("you win!");
            SceneManager.LoadScene(0);

        }
    }
    void OnTriggerEnter(Collider myCollision)
    {
        //take you to next lvl.
        exp = 4;
       
    }
}
