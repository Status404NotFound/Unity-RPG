using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {
        const float waipointGizmoRadius = .3f;
        private void OnDrawGizmos()
        {

            for (int i = 0; i < transform.childCount; i++)
            {
                int j = GetNaxtIndex(i);
                Gizmos.DrawSphere(GetWaypoint(i), waipointGizmoRadius);
                Gizmos.DrawLine(GetWaypoint(i), GetWaypoint(j));
            }
        }

        public int GetNaxtIndex(int i)
        {
            if (i + 1 == transform.childCount)
            {
                return 0;
            }
            return i + 1;
        }

        public Vector3 GetWaypoint(int i)
        {
            return transform.GetChild(i).position;
        }
    }
}
