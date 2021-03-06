export class AlienIterator{
    constructor(elements){
        this.index = 0;
        this.elements = elements;
    }
    next(){
        return this.elements[this.index++];
    }
    hasNextElement() {
        return this.index < this.elements.length;
    }
    first(){
        this.index = 0;
        return this.next()
    }
    reset(){
        this.index = 0;
    }
}