using UnityEngine;
using UnityEngine.Pool;

public class RevisedProjectile : MonoBehaviour
{
    private IObjectPool<RevisedProjectile> objectPool;

    // public property to give the projectile a reference to its ObjectPool

    public IObjectPool<RevisedProjectile> ObjectPool
    {
        set => objectPool = value;
    }
}
