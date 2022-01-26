export class GameOver extends Phaser.Scene{
    constructor()
    {
        super("level1")
    }
    init(data)
    {
        let{points, player}=data;
        this.points=points;
        player.deleteInstance()
    }
    preload()
    {
    }
    create()
    {

        this.add.text(250,100,"Game Over Champ").setScrollFactor(0)
        this.add.text(130,140,`You manage to get ${this.points} points Champ Good Job!!`).setScrollFactor(0)
        this.reset_text=this.add.text(140,200, `Click here to destroy more aliens Brother`).setInteractive().setScrollFactor(0);
        this.reset_text.on('pointerup',()=>{
            localStorage.score=0
            localStorage.level=1
            this.scene.start('MainScene')
        })
    }
    update()
    {

    }
}