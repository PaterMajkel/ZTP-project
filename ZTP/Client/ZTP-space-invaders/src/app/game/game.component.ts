import { Component, OnInit } from '@angular/core';
import * as Phaser from 'phaser';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.scss']
})
export class GameComponent implements OnInit {
  game!: Phaser.Game;
  config!: Phaser.Types.Core.GameConfig;

  constructor() { var config={
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
};}

  ngOnInit(): void {
    this.game = new Phaser.Game(this.config);
  }

}


export class MainScene extends Phaser.Scene {
  constructor()
  {
      super('MainScene')
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
