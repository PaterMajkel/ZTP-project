import Bullet from './Bullet.js';
export class Player extends Phaser.Physics.Arcade.Sprite{
    constructor(data)
    {
        let{
            scene,
            x,
            y,
            points
        }=data
        super(scene, x,y,'player_sprite')
        scene.physics.add.existing(this)
        this.scene.add.existing(this, true) 
        this.body.setSize(this.body.width-10,this.body.height-2)
        this.setDepth(99);
        this.points = points

    }
    setStrategy(shootType) {
        this.shootType = shootType
    }
    shoot(){
        this.shootType.shoot()
    }
    static preload(scene)
    {
        scene.load.spritesheet('player_sprite', './Assets/spaceinvaders.png',{frameWidth: 52, frameHeight: 36})
    }
    create()
    {
        this.setVelocity(100, 200);
        this.setBounce(0.2);
        this.setCollideWorldBounds(true);
        fireButton=game.input.keyboard.addKey(Phaser.Keyboard.SPACEBAR);
        this.bullets=this.physics.add.group({
            maxSize:20,
            classType:Bullet,
            runChildUpdate: true
        });
    }
    update(cursors)
    {
        if(this.visible)
        {
            if(cursors.left.isDown)
            {
                this.setVelocityX(-160);
            }
            else if(cursors.right.isDown)
            {
                this.setVelocityX(160);
            }
            else
            {
                this.setVelocityX(0);
            }
            if(fireButton.isDown)
            {
                fireBullet();
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
}
function fireBullet()
{
    const bullet
}