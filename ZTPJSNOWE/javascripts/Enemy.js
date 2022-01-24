class Enemy{
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
}