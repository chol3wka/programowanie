//2.5


let owoce: string[] = ['jabłko','arbuz','banan','gruszka'];

//a
console.log("Długość: " + owoce.length);

//b
console.log("Posortowane: " + [...owoce].sort());

//c
owoce.push('ananas');
console.log("Po dodaniu wartości: " + owoce);

//d
owoce.shift();
console.log("Po usunięciu pierwszego: "+ owoce);

//e
owoce.pop();
console.log("Po usunięciu ostatniego: "+ owoce);

//f
owoce.unshift('ananas');
console.log("Po dodaniu pierwszego elementu: "+ owoce);

//g
owoce.reverse();
console.log("Po odwróceniu: "+ owoce);

//2.7

let warzywa: string[] = ['marchew', 'burak', 'pietruszka', 'kalafior'];

//a
let polaczoneTablice = owoce.concat(warzywa);
console.log("Połączone tablice: " + polaczoneTablice);

//b
let dodawanieTablic = (owoce as any) + (warzywa as any);
console.log("Dodane tablice: " + dodawanieTablic);

//c
let polaczoneTablice2 = [...owoce, ...warzywa];
console.log("Połączone tablice: " + polaczoneTablice2);