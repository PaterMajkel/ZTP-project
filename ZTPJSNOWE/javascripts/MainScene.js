import { Player } from "./Player.js";

export class MainScene extends Phaser.Scene {
    constructor() {
        super("MainScene")
    }
    preload() {
        Player.preload(this)
        this.load.image('tiles', './Assets/terrain.png');
        this.load.tilemapTiledJSON('map', './Assets/map1.json');
    }
    create() {
        const map = this.make.tilemap({ key: 'map', tileWidth: 16, tileHeight: 16 });
        const tileset = map.addTilesetImage('terrain', 'tiles');
        this.background = map.createLayer('background', tileset);
        this.wall = map.createLayer('wall', tileset);
        this.wall.setCollisionByExclusion(-1, true);
        this.player = new Player(
            {
                scene: this,
                x: 344,
                y: 600,
                points: 0,

            });
        this.cursors = this.input.keyboard.createCursorKeys();
        this.physics.add.collider(this.player, this.wall);
        this.wallColider = this.physics.add.collider(this.player, this.wall)
        // console.log(this.player.this.collision)
    }
    update() {
        this.player.update(this.cursors)

    }
    collision() {
        switch (player.key) {
            case 'Arrow Left':
                if (this.player.this.collision)


                    break;

            default:
                break;
        }


    }

}