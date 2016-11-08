using UnityEngine;
using System.Collections;

namespace Jifeng.DemoSoftVr
{
    // a simple on event listener.it receives slide button submit event.
    public class PlayButton : MonoBehaviour
    {

        public void OnButtonConfirmed()
        {
            switch(gameObject.transform.parent.gameObject.name.ToLower())
            {
            case "front":
            {
					Application.LoadLevel("EscenaDos");

            }
            break;
            case "right":
            {
					Application.LoadLevel("NuevoEntorno");
            }
            break;
            case "left":
            {
               // Application.LoadLevel("JfAgileDemo");
            }
            break;
            case "back":
            {
                //Application.LoadLevel("JfExperienceDemo");
            }
            break;
            }
        }
    }    
}
