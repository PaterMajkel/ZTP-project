export class StartGame extends Phaser.Scene{
    constructor()
    {
        super("startGame")
    }
    preload()
    {
    }
    create()
    {
        this.add.text(290,100,"Hello Champ").setScrollFactor(0)
        this.add.text(100,140,`It's time to chew some bubblegum and kick some asses`).setScrollFactor(0)
        this.reset_text=this.add.text(200,180, `Click here to Start Playing`).setInteractive().setScrollFactor(0);
        this.reset_text.on('pointerup',()=>{
            this.scene.start('MainScene')
        })
        localStorage.score=0;
        localStorage.level=0;
    }
    update()
    {

    }
}