import {BigAssBullet, preBigAssBullet} from "./bullets/BigAssBullet.js";
import {Bullet, preBullet} from "./bullets/Bullet.js";
import { Player } from "./Player.js";
import { preDoubleBullet } from "./bullets/doubleBullet.js";
import { Factory, FireAlien } from "./Factory.js";
//import { Factory } from "./Factory.js";
export class MainScene extends Phaser.Scene {
  constructor() {
    super("MainScene");
  }
  preload() {
    Player.preload(this);
    this.load.image("tiles", "./Assets/terrain.png");
    //this.load.image('alienFire','./Assets/alienFire.png');
    this.load.image('alienNormal','./Assets/alienNormal.png');
    this.load.image('alienPoison','./Assets/alienPoison.png');
    this.load.image("bullet", "./Assets/bullet1.png");
    this.load.tilemapTiledJSON("map", "./Assets/map1.json");
  }
  normalState()
  {
      console.log("I AM NORMAL");
    this.player.movmentSpeed=160
  }
  poisonedState()
  {
    console.log("Poison");
    timedEvent=this.time.delayedCall(3000,this.normalState,[],this);
    this.player.movmentSpeed=80
    this.player.damage(5)
    timedEvent
  }
  inFlameState()
  {
    console.log("OH NO I AM IN FLAME")
    for(var i=1;i<=3;i++)
    {
        firetime[i]=this.time.delayedCall(2000*i,this.playerDamageInFire,[],this);
        firetime[i];
    }


  }
  playerDamageInFire()///idk why it needs to be in different function to work with time 
  {
      this.player.damage(4)
  }
  create() {
    localStorage.setItem("score", "0")
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
    this.alienFire=this.physics.add.group({
      classType:FireAlien,
      runChildUpdate:true,
    })
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
      movmentSpeed: 160
    });
    this.alienFire=this.physics.add.group({
        allowGravity:false,
    })
    map.getObjectLayer('alienFire').objects.forEach((alienFire)=>{
    
      //  const alienSprite=this.alienFire.create(alienFire.x,alienFire.y,'alienFire').setOrigin();
        //alienSprite.body.setSize(alienFire.width,alienFire.height).setOffset(0,0);
       // let factory=new Factory();
       // const alien=factory.createEnemy("fireAlien")

    })
    this.alienNormal=this.physics.add.group({
        allowGravity:false,
    })
    map.getObjectLayer('alienNormal').objects.forEach((alienNormal)=>{
        const alienNormalSprite=this.alienNormal.create(alienNormal.x,alienNormal.y,'alienNormal').setOrigin();
        alienNormalSprite.body.setSize(alienNormal.width,alienNormal.height).setOffset(0,0);
    })
    this.alienPoison=this.physics.add.group({
        allowGravity:false,
    })
    map.getObjectLayer('alienPoison').objects.forEach((alienPoison)=>{
        const alienPoisonSprite=this.alienPoison.create(alienPoison.x,alienPoison.y,'alienPoison').setOrigin();
        alienPoisonSprite.body.setSize(alienPoison.width,alienPoison.height).setOffset(0,0);
    })
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
    this.point_text=this.add.text(550,40,`Points: ${this.player.points}`)
    this.point_text.setDepth(99)
  }
  update() {
    this.player.update(this.cursors);
    this.point_text.setText(`Points: ${this.player.points}`)
    if(this.testCursors.four.isDown)//testowanie zatrucia
    {
        this.poisonedState()
    }
    if(this.testCursors.five.isDown && flipFlop)//testowanie podpalenia
    {
        this.inFlameState()
    }
    if (this.testCursors.one.isDown && flipFlop) {
        this.player.setStrategy(this.normalBulletStrat);
        flipFlop = false;
    } else if (this.testCursors.two.isDown && flipFlop) {
        this.player.setStrategy(this.bigAssBulletStrat);
        flipFlop = false;
    } else if (this.testCursors.three.isDown)
     {
        this.player.setStrategy(this.doubleBulletStrat);
        localStorage.setItem("score", (+localStorage.getItem("score")+1).toString())
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
var timedEvent;
var firetime=[];

