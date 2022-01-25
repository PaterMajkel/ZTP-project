export class Factory extends Phaser.Physics.Arcade.Sprite{
    createEnemy=function(type){
        var alien;
        if(type==="fireAlien"){
            alien=new FireAlien();
        }
        alien.type=type;

        alien.say=function(){
            console.log(this.type+"to ja")
        }
        return alien;

    }
}
export class FireAlien extends Factory{
    constructor(type)
    {
        super(type)
       // super(type)
        this.type="fireAlien"
        this.load.image('alienFire','./Assets/alienFire.png');
    }
    wypisz(params) {
        console.log(this.type)
       
   }
    
   // var factory=new Factory();
  // console.log(1)
   // this.load.image('alienFire','./Assets/alienFire.png');
    //console.log("2")
}
function sprawdz(){
    var alieni=[]
    var factory=new Factory()
    alieni.push(factory.createEnemy("fireAlien"))
    console.log(alieni)
}