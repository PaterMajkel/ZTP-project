import { Scene } from "phaser";
import { config } from "process";

class AlienNormal implements IAlien 
{
   // private alienNormal=new IAlien();
   constructor(scene: Phaser.Scene, x: number, y: number) {
}
    createEnemy(): IAlien {
        return new AlienNormal(new Phaser.Scene.arguments,10, 10);
    }
    
}