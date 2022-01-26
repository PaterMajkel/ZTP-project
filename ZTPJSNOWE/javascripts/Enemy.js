class Alien extends Phaser.Physics.Arcade.Sprite {
    constructor(scene, alienType) {
        super(scene, 0, 0, alienType);
        this.alienType = alienType;
    }
    activate(x, y, multiplier=1) {
        this.setCollideWorldBounds(true);
        this.body.onWorldBounds = true;
        this.enableBody(true, x, y, true, true);
        this.setVelocityX(10*multiplier)
        this.velocity=this.body.velocity.x
    }
    deactivate() {
        this.disableBody(true, true);
    }
    colidedWithWall(){
        this.y+=10
        if(this.velocity<0){
            this.x+=5
        }
        else
            this.y-=5
        this.setVelocityX(this.velocity*-1.05)
        this.velocity=this.velocity*-1.05
    }
    shoot(){}
}
export class AlienFire extends Alien {
    constructor(scene) {
        super(scene, 'alienFire');
        this.modifier=localStorage.level
    }
    shoot(){
        if(!this.active)
            return
        if(Math.random()>0.15)
            return
        let bullet = this.scene.alienBullets.get()
        bullet.shoot(this.x, this.y, 250, Math.PI )
    }
}
export class AlienNormal extends Alien {
    constructor(scene) {
        super(scene, 'alienNormal');
    }
    shoot(){
        if(!this.active)
            return
        if(Math.random()>0.1)
            return
        let bullet = this.scene.alienBullets.get()
        bullet.shoot(this.x, this.y, 250, Math.PI, 'bulletBlue' )
    }
}
export class AlienPoison extends Alien {
    constructor(scene) {
        super(scene, 'alienPoison');
    }
    shoot(){
        if(!this.active)
            return
        if(Math.random()>0.1*this.modifier)
            return
        let bullet = this.scene.alienBullets.get()
        bullet.shoot(this.x, this.y, 250, Math.PI, 'bulletGreen' )
    }
}

