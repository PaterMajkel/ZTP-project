export class preBigAssBullet{
    constructor(type) {
        this.type=type
      }

      shoot(x,y){
        this.bullet = this.type.get()

          this.bullet.shoot(x,y)
      }
}

export class BigAssBullet extends Phaser.Physics.Arcade.Sprite {

    constructor(scene) {
      super(scene, 0, 0, 'bullet');
    }
  
    shoot(x, y) {
    this.setScale(7)
      this.setCollideWorldBounds(true);
      this.body.onWorldBounds = true;
      this.enableBody(true, x, y, true, true);
      this.setVelocityY(-300);
    }
  
    deactivate() {
      this.disableBody (true, true);
    }
  }
  