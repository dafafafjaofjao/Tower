using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : GenericSingle<StateManager>
{
    State currentState;
    public State startSceneState, mainSceneState, battleSceneState;

    // Start is called before the first frame update
    public override void Init()
    {
        base.Init();

        startSceneState = new StartSceneState();
        mainSceneState = new MainSceneState();
        battleSceneState = new BattleSceneState();

        //GameObject.DontDestroyOnLoad(gameObject);

    }



    public void SwitchState(State pState)
    {
        currentState?.OnExit();
        currentState = pState;
        currentState?.OnEnter();
    }

}
