using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class State
{
    public virtual void OnEnter()
    {

    }

    public virtual void OnExit()
    {

    }
}


public class StartSceneState : State
{
    public override void OnEnter()
    {
        base.OnEnter();

        SceneManager.LoadScene(0);
        Debug.Log("进入开始场景");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("退出开始场景");
    }
}

public class MainSceneState : State
{
    public override void OnEnter()
    {
        base.OnEnter();

        SceneManager.LoadScene(1);
        Debug.Log("进入主场景");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("退出主场景");
    }
}

public class BattleSceneState : State
{
    public override void OnEnter()
    {
        base.OnEnter();

        SceneManager.LoadScene(2);
        Debug.Log("进入战斗场景");
    }

    public override void OnExit()
    {
        base.OnExit();
        Debug.Log("退出战斗场景");
    }
}
