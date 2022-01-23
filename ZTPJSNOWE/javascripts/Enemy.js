var EnemyFactory=function(){
    this.createEnemy=function(enemyType){
        var alien;

        if(enemyType==="fireEnemy"){
            alien=new FireEnemy();
        }
        else if(enemyType==="poisonEnemy")
        {
            alien=new PoisonEnemy();
        }
        else if(enemyType===normalEnemy){
            alien=new NormalEnemy();
        }

    }
    alien.enemyType=enemyType;
    return alien;
}
var FireEnemy=function(){
    
}

var PoisonEnemy=function() {
    
}
var NormalEnemy=function(){

}