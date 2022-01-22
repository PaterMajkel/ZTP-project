import { PreloadAllModules } from "@angular/router"
import { AssetType } from "../interface/assets";
export class MainScene extends Phaser.Scene {
    constructor()
    {
        super("MainScene")
    }
    preload()
    {
        this.load.setBaseURL("/assets");
        this.load.spritesheet('alien', "/images/invader.png", {
            frameWidth: 32,
            frameHeight: 32,
        });
        this.load.image('player', "/images/player.png");

    }
    create()
    {
        this.cameras.main.setBounds(0, 0, 1920, 1080);
        this.physics.world.setBounds(0, 0, 1920, 1080);
    }
}