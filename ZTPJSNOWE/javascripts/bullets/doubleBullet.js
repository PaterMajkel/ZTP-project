export class preDoubleBullet{
    constructor(type) {
       this.type=type
      }

      shoot(x,y){
        this.type.get().shoot(x-20,y, -250)
        this.type.get().shoot(x+20,y-3, -250)
      }
}
