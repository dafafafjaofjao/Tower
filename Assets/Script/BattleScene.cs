using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("switchScene", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void switchScene()
    {

        StateManager.Instance.SwitchState(StateManager.Instance.mainSceneState);

    }

}