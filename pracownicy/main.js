let numer = 1
function zmiana(){
    numer +=1
    if(numer > 3) numer = 1
    let q1 = document.getElementById("q1")
    let q2 = document.getElementById("q2")
    let q3 = document.getElementById("q3")
    switch(numer){
        case 1:
            q3.style.display = "none"
            q1.style.display = "block"
            break
        case 2:
            q1.style.display = "none"
            q2.style.display = "block"
            break
        case 3:
            q2.style.display = "none"
            q3.style.display = "block" 
            break
    }
}