class AlienFire implements IAlien
{
    
    constructor(scene: Phaser.Scene, x: number, y: number) {
    }
        createEnemy(): IAlien {
            return new AlienFire(new Phaser.Scene.arguments,10, 10);
        }
}