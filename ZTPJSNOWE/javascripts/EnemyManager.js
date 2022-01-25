import { AlienFire, AlienNormal, AlienPoison } from "./Enemy.js";
function deactivateAlien(alien) {
    alien.deactivate();
}
export class EnemyManager {
    constructor(scean,) {
        this.scean = scean
        this.maxHight = 650;
        this.alienVelocity1 = 50;
        this.aliensFires = scean.physics.add.group({
            maxSize: 30,
            classType: AlienFire,
            runChildUpdate: true
        })
        this.aliensNormals = scean.physics.add.group({
            maxSize: 30,
            classType: AlienNormal,
            runChildUpdate: true
        })
        this.aliensPoisons = scean.physics.add.group({
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
    init() {
        //this.makeAlienRow(0, this.aliensFires);
        //this.makeAlienRow(1, this.aliensFires);
        //this.makeAlienRow(2, this.aliensNormals);
        //this.makeAlienRow(3, this.aliensNormals);
        //this.makeAlienRow(4, this.aliensPoisons);
        //this.makeAlienRow(5, this.aliensPoisons);

        //this.aliensVelocity = this.aliensVelocity1 + (5 * (level - 1));
        //this.aliens1.setVelocityX(this.aliensVelocity);
        //this.aliens2.setVelocityX(this.aliensVelocity);
        //this.aliens3.setVelocityX(this.aliensVelocity);
        for(var row=0;row<5;row++)
        {
            for(var column=0;column<9;column++)
            {
                let x=70+(column*60)
                let y=100+(row*50)
                let rand=Math.floor(Math.random()*(3-1+1)+1)
                if(rand==1)
                {
                    this.aliensFires.get().activate(x,y);
                }
                else if(rand==2)
                {
                    this.aliensNormals.get().activate(x,y);
                }
                else if(rand==3)
                {
                    this.aliensPoisons.get().activate(x,y);
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
