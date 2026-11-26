interface IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
}

class Fahrzeug implements IVerkaufsartikel {
    private fahrzeugtyp: string; // instance variable (member variable)
    private name: string;
    verkaufsNamen: string;
    preis: number;

    get Fahrzeugtyp(): string {
        return this.fahrzeugtyp;
    }

    get Name(): string {
        return this.name;
    }

    constructor(fahrzeugtyp: string, name: string, preis: number) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
        this.verkaufsNamen = name;
        this.preis = preis;
    }
}

class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;

    get AnzahlGaenge(): number {
        return this.anzahlGaenge;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name, 500); // Beispielwert für den Preis
        this.anzahlGaenge = anzahlGaenge;
    }
}

class Auto extends Fahrzeug {
    private anzahlTueren: number;

    get AnzahlTueren(): number {
        return this.anzahlTueren;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number) {
        super(fahrzeugtyp, name, 20000); // Beispielwert für den Preis
        this.anzahlTueren = anzahlTueren;
    }
}

class PKW extends Auto {
    private motorTyp: string; // instance variable (member variable)
    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class LKW extends Auto {
    private motorTyp: string; // instance variable (member variable)

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class Reifen implements IVerkaufsartikel {
    verkaufsNamen: string;
    preis: number;
    marke: string;
    groesse: number;
    typ: string;
    constructor(marke: string, groesse: number, typ: string) {
        this.marke = marke;
        this.groesse = groesse;
        this.typ = typ;
        this.verkaufsNamen = marke;
        this.preis = 100; // Beispielwert, sollte entsprechend gesetzt werden
    }
}

class Garage {
    public verkaufbareDinge: IVerkaufsartikel[] = []; // instance variable (member variable)

    public addFahrzeug(fahrzeug: Fahrzeug): void {
        this.verkaufbareDinge.push(fahrzeug);
    }

    public getFahrzeuge(): Fahrzeug[] {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug) as Fahrzeug[];
    }

    public addReifen(reifen: Reifen): void {
        this.verkaufbareDinge.push(reifen);
    }

    public getReifen(): Reifen[] {
        return this.verkaufbareDinge.filter(item => item instanceof Reifen) as Reifen[];
    }

    public anzahlFahrzeuge(): number {
        return this.verkaufbareDinge.filter(item => item instanceof Fahrzeug).length;
    }

    get anzahlAutos(): number {
        let anzahlAutos: number = 0;
        for (const ding of this.verkaufbareDinge) {
            if (ding instanceof Auto) {
                anzahlAutos++;
            }
        }
        return anzahlAutos;
    }
}


var myBWMWith4Doors = new PKW("BMW", 4, "Benzin"); // lokale variable
console.log(myBWMWith4Doors.Fahrzeugtyp);
console.log(myBWMWith4Doors.AnzahlTueren);
var myBWMWith2Doors = new PKW("BMW", 2, "Benzin"); // lokale variable
console.log(myBWMWith2Doors.Fahrzeugtyp);
console.log(myBWMWith2Doors.AnzahlTueren);
var myMANWith2Doors = new LKW("MAN", 2, "Diesel"); // lokale variable
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

var myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21); // lokale variable
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

var myGarage = new Garage(); // lokale variable
myGarage.addFahrzeug(myBWMWith4Doors);
myGarage.addFahrzeug(myBWMWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);
console.log(`Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge()} davon Autos: ${myGarage.anzahlAutos}`);

myGarage.addReifen(new Reifen("Michelin", 16, "Sommerreifen"));
myGarage.addReifen(new Reifen("Continental", 17, "Winterreifen"));

console.log(`Verkaufbare Dinge in der Garage: ${myGarage.verkaufbareDinge.length}`);