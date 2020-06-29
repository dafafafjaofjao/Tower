using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
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
        StateManager.Instance.SwitchState(StateManager.Instance.battleSceneState);
    }

    public void OnReturnButtonlik()
    {
        StateManager.Instance.SwitchState(StateManager.Instance.startSceneState);
    }
    public void CaoZuoShuoMing()
    {
        SceneManager.LoadScene(3);
    }

}

