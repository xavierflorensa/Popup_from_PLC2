#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
        //var popUpWindow = Project.Current.Get<DialogBox1>("UI/Panels/DialogBox1");
        //popUpWindow.OpenDialog();
        
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
