
import { MainScene } from './MainScene.js';
import { GameOver } from './GameOver.js';
import { StartGame } from './StartGame.js';
var config = {
  parent: "phaser-game",
  type: Phaser.AUTO,
  backgroundColor: 'rgb(47, 52, 55)',
  width: 688,
  height: 688,
  fps: 60,
  physics: {
      default: 'arcade',
      arcade: {
        gravity: { y: 0 },
        debug: false
    }
  },
  scene:[
    StartGame,
    MainScene,
    GameOver
  ]
};

new Phaser.Game(config);

