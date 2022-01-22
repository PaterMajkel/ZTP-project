import * as Phaser from "phaser";
import { MainScene } from "./scene/main";
var config={
    type: Phaser.AUTO,
    width: 512,
    height: 512,
    physics:{
        default: 'arcade',
        arcade:{
            debug:true
        }
    },
    scene:[
        MainScene,
    ]
};
class SpaceInvadersGame extends Phaser.Game {
    constructor(config: Phaser.Types.Core.GameConfig) {
        super(config)
    }
}

const game = new SpaceInvadersGame(config);
