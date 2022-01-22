import "phaser";
import { MainScene } from "./scene/main";
var config={
    title: "Space Invaders",
    backgroundColor: 'rgb(47,52,55)',
    type: Phaser.AUTO,
    width: 512,
    height: 512,
    physics:{
        default: 'arcade',
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
