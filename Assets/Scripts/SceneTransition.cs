using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    private bool isGoodBehavior = true;
    
    public string goodbehaviorscene;

    public string rebelbehaviorscene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBadBehavior()
    {
        isGoodBehavior = false;
    }
    
    public void SetGoodBehavior()
    {
        isGoodBehavior = true;
    }

    public void TransferToNextScene()
    {
        if (isGoodBehavior)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(goodbehaviorscene);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(rebelbehaviorscene);
        }
    }

}
