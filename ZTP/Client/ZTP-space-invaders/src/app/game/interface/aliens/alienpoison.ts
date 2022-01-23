import { Scene } from "phaser";
import { AssetType } from "../assets";
class AlienPoison implements IAlien 
{
  constructor(scene: Phaser.Scene, x: number, y: number) {
  }
      createEnemy(): IAlien {
          return new AlienPoison(new Phaser.Scene.arguments,10, 10);
      }

}