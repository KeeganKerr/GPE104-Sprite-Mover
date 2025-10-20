using UnityEngine;

public class GunBullet : Gun
{
    public GameObject Bullet;
    public Pawn pawn;
    
    //Overrides the parent and shoots
    public override void Shoot()
    {
        //Spawns bullets relative to where the pawn is facing    
        Instantiate(Bullet, pawn.transform.position, pawn.transform.rotation);
    }
}
