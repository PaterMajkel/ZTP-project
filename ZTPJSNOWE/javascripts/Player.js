var flipFlop;
import { HealthBar } from "./healthBar.js";
export class Player extends Phaser.Physics.Arcade.Sprite{

    constructor(data)
    {
        let{
            scene,
            x,
            y,
            points,
            movmentSpeed,
            level
        }=data
        super(scene, x,y,'player_sprite')
        scene.physics.add.existing(this)
        this.scene.add.existing(this, true) 
        this.body.setSize(this.body.width,this.body.height-30)
        this.setDepth(99);
        this.points = points
        this.movmentSpeed=movmentSpeed
        this.hp=new HealthBar(this.scene,30,40)
        this.level=level;

    }
    setStrategy(shootType) {
        this.shootType = shootType
    }
    shoot(){
        this.shootType.shoot(this.x,this.y)
    }
    static preload(scene)
    {
        scene.load.spritesheet('player_sprite', './Assets/ship.png',{frameWidth: 52, frameHeight: 36})
    }
    create()
    {
        this.setVelocity(100, 200);
        this.setBounce(0.2);
        this.setCollideWorldBounds(true);
    }
    update(cursors)
    {
        if(this.visible)
        {
            if(cursors.left.isDown)
            {
                this.setVelocityX(-this.movmentSpeed);
            }
            else if(cursors.right.isDown)
            {
                this.setVelocityX(this.movmentSpeed);
            }
            else
            {
                this.setVelocityX(0);
            }
            if(cursors.space.isDown && flipFlop)
                {
                    this.shoot()
                    flipFlop=false
                }
                else if(cursors.space.isUp && !flipFlop)
                {
                    flipFlop=true
                }
           
        }
        else
        {
            this.setVelocityX(0);
        }

    }
    addPoints(value)
    {
        this.points=this.points+value
    }
    damage(amount,scene)
    {
        this.newScene=scene
        this.playernew=this
        console.log("OUCH");
        if(this.hp.decreaseHealth(amount))
        {
           this.newScene.start('level1',{
                points: this.playernew.points
               })
        }
    }
    healing(amount)
    {
        console.log("MEDIC!!!")
        this.hp.increasHealth(amount);
    }
}
