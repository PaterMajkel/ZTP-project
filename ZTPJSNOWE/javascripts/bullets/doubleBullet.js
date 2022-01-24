export class preDoubleBullet{
    constructor(type) {
       this.type=type
      }

      shoot(x,y){
        this.type.get().shoot(x-20,y)
        this.type.get().shoot(x+20,y)
      }
}
