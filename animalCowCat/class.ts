abstract class Animal { //Basisklasse für Tiere

    private _name: string = "";
    private _colour: string = "";

    constructor(name: string, colour: string) { // Konstruktor => "konstruiert" ein Tier
        this._name = name;
        this._colour = colour;
    }

    public get Name(): string { return this._name; } // öffentliche Methode, um den Namen abzurufen

    public get Colour(): string { return this._colour; } // öffentliche Methode, um die Farbe abzurufen
    public set Colour(value: string) { this._colour = value; } // öffentliche Methode, um die Farbe zu setzen

    public describe(): void { // gemeinsame Methode für alle Tiere
        console.log(`${this._name} ist ${this._colour}`);
    }

    public abstract makeSound(): void; // muss von jeder abgeleiteten Klasse implementiert werden
}

class Cow extends Animal { // abgeleitete Klasse von Animal
    public makeSound(): void { console.log("Muuuuh"); }
}

class Cat extends Animal { // abgeleitete Klasse von Animal
    public makeSound(): void { console.log("Miau"); }
}

let myKuh = new Cow("Kuh1", "weiß"); // erstellt eine Instanz der Cow-Klasse
let myKuh2 = myKuh;
console.log(myKuh2 == myKuh);
console.log(myKuh.Name);
myKuh.Colour = "braun";
console.log(myKuh2.Colour);

let myKatze = new Cat("Tommy", "grau");

let tiere: Animal[] = [myKuh, myKatze];
for (let tier of tiere) {
    tier.describe();
    tier.makeSound();
}
