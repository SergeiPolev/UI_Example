using System;
using UnityEngine;

public class TutorialUIScreen : UIScreen
{
    [SerializeField] private UIScreenType[] _openOnClose;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Close();
        }
    }

    public override void Close()
    {
        base.Close();

        foreach (var item in _openOnClose)
        {
            gameCanvas.Open(item);
        }
    }

    public override UIScreenType GetUIType()
    {
        return UIScreenType.TUTORIAL;
    }
}