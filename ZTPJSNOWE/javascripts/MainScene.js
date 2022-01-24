import {BigAssBullet, preBigAssBullet} from "./bullets/BigAssBullet.js";
import {Bullet, preBullet} from "./bullets/Bullet.js";
import { Player } from "./Player.js";
import { preDoubleBullet } from "./bullets/doubleBullet.js";
export class MainScene extends Phaser.Scene {
  constructor() {
    super("MainScene");
  }
  preload() {
    Player.preload(this);
    this.load.image("tiles", "./Assets/terrain.png");
    this.load.image("bullet", "./Assets/bullet1.png");
    this.load.tilemapTiledJSON("map", "./Assets/map1.json");
  }
  create() {
    const map = this.make.tilemap({
      key: "map",
      tileWidth: 16,
      tileHeight: 16,
    });
    const tileset = map.addTilesetImage("terrain", "tiles");
    this.physics.world.on('worldbounds', this.onWorldbounds, this);
    this.background = map.createLayer("background", tileset);
    this.wall = map.createLayer("wall", tileset);
    this.wall.setCollisionByExclusion(-1, true);
    this.bullets = this.physics.add.group({
      classType: Bullet,
      runChildUpdate: true,
    });
    this.normalBulletStrat = new preBullet(this.bullets)
    this.bigBullets = this.physics.add.group({
      classType: BigAssBullet,
      runChildUpdate: true,
    });
    this.bigAssBulletStrat = new preBullet(this.bigBullets)
    this.doubleBulletStrat = new preDoubleBullet(this.bullets)

    this.player = new Player({
      scene: this,
      x: 344,
      y: 600,
      points: 0,
    });
    this.player.setStrategy(this.normalBulletStrat);

    this.cursors = this.input.keyboard.createCursorKeys();
    this.testCursors = this.input.keyboard.addKeys({
      one: Phaser.Input.Keyboard.KeyCodes.ONE,
      two: Phaser.Input.Keyboard.KeyCodes.TWO,
      three: Phaser.Input.Keyboard.KeyCodes.THREE,
      four: Phaser.Input.Keyboard.KeyCodes.FOUR,
      five: Phaser.Input.Keyboard.KeyCodes.FIVE,

    });
    this.physics.add.collider(this.player, this.wall);
    this.wallColider = this.physics.add.collider(this.player, this.wall);
    // console.log(this.player.this.collision)
  }
  update() {
    this.player.update(this.cursors);

    if (this.testCursors.one.isDown && flipFlop) {
        this.player.setStrategy(this.normalBulletStrat);
        flipFlop = false;
    } else if (this.testCursors.two.isDown && flipFlop) {
        this.player.setStrategy(this.bigAssBulletStrat);
        flipFlop = false;
    } else if (this.testCursors.three.isDown)
     {
        this.player.setStrategy(this.doubleBulletStrat);
        flipFlop = false;
     }
     else if (this.testCursors.three.isUp && !flipFlop) {
        flipFlop = true;
     }
    else if (this.testCursors.two.isUp && !flipFlop) {
      flipFlop = true;
    } else if (this.testCursors.one.isUp && !flipFlop) {
      flipFlop = true;
    }
    if (this.testCursors.four.isDown && flipFlop) {
        this.player.setStrategy(this.normalBulletStrat);
        flipFlop = false;
    } else if (this.testCursors.two.isDown && flipFlop) {
        this.player.setStrategy(this.bigAssBulletStrat);
        flipFlop = false;
    }
  }
  collision() {
    switch (player.key) {
      case "Arrow Left":
        if (this.player.this.collision) break;

      default:
        break;
    }
  }
  onWorldbounds(element){
      if(this.bullets.contains(element.gameObject) || this.bigBullets.contains(element.gameObject))
        element.gameObject.deactivate()
  }
}
var flipFlop;
