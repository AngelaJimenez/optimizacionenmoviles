using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR.Interaction.Toolkit;
public class teleportationAreaOnChangeMoviles : TeleportationArea
{
    public int id;
    // public teleportmodification tpcontroller;
    
      public void teleporting()
      {
      }

      protected override void OnSelectExited(SelectExitEventArgs args)
      {
       
         base.OnSelectExited(args);
      }
}
