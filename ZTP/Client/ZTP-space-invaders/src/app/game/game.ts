import * as Phaser from "phaser";
import { MainScene } from "./Main";
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

new Phaser.Game(config);