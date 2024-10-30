using UnityEngine;

namespace ChangeShapeMiniGame.Sys.DeathChecker
{
    public class DeadCheck : MonoBehaviour
    {
        public GameObject modal;
        private void Update()
        {
            if (!Player.IsAlive)
            {
                modal.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
