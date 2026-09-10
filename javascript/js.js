const dodaj = document.querySelector('.add');
const usun = document.querySelector('.remove');
const toggle = document.querySelector('.toggle');
const text = document.querySelector('p');

const addClass = () => {
    text.classList.add('test')
}

const removeClass = () => {
    text.classList.remove('test')
}

const toggleClass = () => {
    text.classList.toggle('test')
}

dodaj.addEventListener('click', addClass);
usun.addEventListener('click', removeClass);
toggle.addEventListener('click', toggleClass);