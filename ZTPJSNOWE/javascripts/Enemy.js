/*class Enemy{
    //  constructor(type){
    //      this.type=type
    //  }

    createEnemy();

}
class FireEnemy extends Enemy{
    
    createEnemy(scene){
        scene.load.spritesheet('f_alien_sprite', './Assets/spaceinvaders.png',{frameWidth: 52, frameHeight: 36})
        return new FireEnemy;
    }
}
class NormalEnemy extends Enemy{
    createEnemy(scene){
        scene.load.spritesheet('n_alien_sprite', './Assets/spaceinvades.png',{frameWidth: 52, frameHeight: 36})
        return new NormalEnemy;
    }
}
class PoisonEnemy extends Enemy{
    createEnemy(scene){
        scene.load.spritesheet('p_alien_sprite', './Assets/sinvaders.png',{frameWidth: 52, frameHeight: 36})
        return new PoisonEnemy;
    }
}

function getNormalEnemy(){
    return NormalEnemy.createEnemy();
}
function getFireEnemy(){
    return FireEnemy.createEnemy();
}
function getPoisonEnemy(){
    return PoisonEnemy.createEnemy();
}*/

/*var AlienFactory = function (aliens) {
    this.createAlien = function (type) {
        let alien
        alien.body.setSize(aliens.width, aliens.height).setOffSet(0, 0)
        if (type === "fireAlien") {
            alien = new FireAlien(aliens)
        }
        else if (type === "normalAlien") {
            alien = new NormalAlien(aliens)
        }
        else if (type === "poisonAlien") {
            alien = new PoisonAlien(aliens)
        }
        alien.type = type;
        return alien
    }
}
var FireAlien = function (aliens) {
    this.load.image('alienFire', './Assets/alienFire.png');
    this.alien = aliens.create(aliens.x, aliens.y, 'alienFire').setOrigin();
    this.attckType = "fire"
}
var NormalAlien = function (aliens) {
    this.load.image('alienNormal', './Assets/alienNormal.png');
    this.alien = aliens.create(aliens.x, aliens.y, 'alienNormal').setOrigin();
    this.attckType = "normal"
}
var PoisonAlien = function (aliens) {
    this.load.image('alienPoison', './Assets/alienPoison.png');
    this.alien = aliens.create(aliens.x, aliens.y, 'alienPoison').setOrigin();
    this.attckType = "poison"
}*/
class Alien extends Phaser.Physics.Arcade.Sprite {
    constructor(scean, alienType) {
        super(scean, 0, 0, alienType);
        this.alienType = alienType;
    }
    preload() {
        this.load.image('alienFire', './Assets/alienFire.png');
        this.load.image('alienNormal', './Assets/alienNormal.png');
        this.load.image('alienPoison', './Assets/alienPoison.png');
    }
    activate(x, y) {
        this.setCollideWorldBounds(true);
        this.body.onWorldBounds = true;
        this.enableBody(true, x, y, true, true);
    }
    deactivate() {
        this.disableBody(true, true);
    }
}
export class AlienFire extends Alien {
    constructor(scean) {
        super(scean, 'alienFire');
    }
}
export class AlienNormal extends Alien {
    constructor(scean) {
        super(scean, 'alienNormal');
    }
}
export class AlienPoison extends Alien {
    constructor(scean) {
        super(scean, 'alienPoison');
    }
}

