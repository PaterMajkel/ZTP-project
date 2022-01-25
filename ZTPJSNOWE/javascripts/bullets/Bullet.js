export class preBullet{
    constructor(type) {
        this.type=type
      }

      shoot(x,y){
        this.type.get().shoot(x,y)
      }
}


export class Bullet extends Phaser.Physics.Arcade.Sprite {

    constructor(scene) {
      super(scene, 0, 0, 'bullet');

    }

    shoot(x, y, speed=-300, orientation = 0, color = 0 ) {
        this.setScale(3)
      this.setCollideWorldBounds(true);
      this.body.onWorldBounds = true;
      this.enableBody(true, x, y, true, true);
      this.setVelocityY(speed);
      this.rotation = orientation
      if(color!=0)
        this.setTexture(color);
    }
  
    deactivate() {
      this.disableBody (true, true);
    }
  }
  