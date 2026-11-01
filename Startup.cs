using HarmonyLib;
using UnityEngine;

namespace IndividualRCS
{
    [KSPAddon(KSPAddon.Startup.Instantly, true)]
    internal sealed class Startup : MonoBehaviour
    {
        #pragma warning disable CA1822
        private void Awake()
        {
            Debug.Log("[IndividualRCS]: Loaded");

            try
            {
                Harmony harmony = new Harmony("IndividualRCS");
                harmony.PatchAll(typeof(Startup).Assembly);
            }
            catch (System.Exception e)
            {
                Debug.Log("IndividualRCS");
                Debug.Log(e.ToString());
            }
        }
    }
}
