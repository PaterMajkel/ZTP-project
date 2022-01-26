import { AlienFire, AlienNormal, AlienPoison } from "./Enemy.js";
function deactivateAlien(alien) {
    alien.deactivate();
}
export class EnemyManager {
    constructor(scene, multiplier) {
        this.multiplier=multiplier
        this.scene = scene
        this.maxHight = 650;
        this.alienVelocity1 = 50;
        this.aliensFires = scene.physics.add.group({
            maxSize: 30,
            classType: AlienFire,
            runChildUpdate: true
        })
        this.aliensNormals = scene.physics.add.group({
            maxSize: 30,
            classType: AlienNormal,
            runChildUpdate: true
        })
        this.aliensPoisons = scene.physics.add.group({
            maxSize: 30,
            classType: AlienPoison,
            runChildUpdate: true
        })
        this.init();
    }
    addColider(other, eventHandler, scene) {
        scene.physics.add.collider(this.aliensFires, other, eventHandler, null, scene);
        scene.physics.add.collider(this.aliensNormals, other, eventHandler, null, scene);
        scene.physics.add.collider(this.aliensPoisons, other, eventHandler, null, scene);
    }
    getAlienContainer(){
        return this.alienList
    }
    init() {
        this.alienList=[]
        
        for(var row=0;row<5;row++)
        {
            for(var column=0;column<9;column++)
            {
                let x=70+(column*60)
                let y=100+(row*50)
                let rand=Math.floor(Math.random()*(3-1+1)+1)
                if(rand==1)
                {
                    this.alienList.push(this.aliensFires.get());
                    this.alienList.at(-1).activate(x,y,this.multiplier)
                }
                else if(rand==2)
                {
                    this.alienList.push(this.aliensNormals.get());
                    this.alienList.at(-1).activate(x,y, this.multiplier)
                }
                else if(rand==3)
                {
                    this.alienList.push(this.aliensPoisons.get());
                    this.alienList.at(-1).activate(x,y, this.multiplier)
                }
            }
        }
    }
    makeAlienRow(row,aliens)
    {
        for(var column=0;column<9;column++)
        {
            let x=50+(column*54);
            let y = 70 + (row * 50);
            aliens.get().activate(x, y);
        }
    }
}
