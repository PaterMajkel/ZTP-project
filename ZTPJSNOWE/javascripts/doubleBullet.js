export class preDoubleBullet{
    constructor(type) {
       this.type=type
      }

      shoot(x,y){
        this.bullets = []
        this.bullets.push(this.type.get())
        this.bullets.push(this.type.get())
          this.bullets[0].shoot(x-20,y)
          this.bullets[1].shoot(x+20,y)

      }
}
